#Region "References"

Imports HTLFW
Imports HTLFW.HTLLib
Imports HTLFW.HTLLib.HTLComFuncs
Imports HTLFW.HTLLib.HTLStringFuncs
Imports HTLFW.HTLLib.HTLLayoutDefinition

Imports DBs

#End Region

Public Class frmTOL_ItemPickList

#Region "Declares"

    Private tblData As DataTable
    Private IsRunning As Boolean = False
    Private _OriginItems As New ListKeyValues
    Private _Items As New ListKeyValues
    Private _SelectMethod As AppRoot.ResponseListItemSelector.eSelectMethod = AppRoot.ResponseListItemSelector.eSelectMethod.GetListForUpdate

    Private _Key As String = ""
    Private _SqlString As String = ""
    Private _Where As String = ""
    Private _VisibleColumns As New List(Of String)

    Public Event ListItemSelected(ByVal e As AppRoot.ResponseListItemSelector)
#End Region

#Region "Proerties"

    Public Property SelectMethod() As AppRoot.ResponseListItemSelector.eSelectMethod
        Get
            Return _SelectMethod
        End Get
        Set(ByVal value As AppRoot.ResponseListItemSelector.eSelectMethod)
            _SelectMethod = value
        End Set
    End Property

    Public Property OriginItems() As ListKeyValues
        Get
            Return _OriginItems
        End Get
        Set(ByVal value As ListKeyValues)
            _OriginItems.Clear()
            If Not value Is Nothing Then
                _OriginItems.GetValues(value)
            End If
        End Set
    End Property

    Public Property Items() As ListKeyValues
        Get
            Return _Items
        End Get
        Set(ByVal value As ListKeyValues)
            _Items.Clear()
            If Not value Is Nothing Then
                _Items.GetValues(value)
            End If
        End Set
    End Property

    Public Function SetItems(ByVal pComboCheckboxEditValue As String) As Boolean
        Try
            If HTLFW.HTLLib.HTLComFuncs.Nz(pComboCheckboxEditValue, "") = "" Then Return False
            Dim mArr As String() = pComboCheckboxEditValue.Split(",")
            _Items.Clear()

            For i As Integer = 0 To mArr.Length - 1
                _Items.Add(New ListKeyValues.KeyValueObj(Trim(mArr(i)).ToString, Trim(mArr(i))))
            Next
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

#End Region

#Region "Constructors"

    Public Sub New(ByVal pKey As String, ByVal pSqlString As String, ByVal pWhere As String, ByVal pItem As String) ', ByVal pItemSelect As List(Of String))
        InitializeComponent()
        _Key = pKey
        _SelectMethod = AppRoot.ResponseListItemSelector.eSelectMethod.GetListForInsert
        _SqlString = pSqlString
        _Where = pWhere
        CurrValue.EditValue = pItem
        SetItems(pItem)
        OriginItems = Items
    End Sub
    Public Sub New(ByVal pKey As String, ByVal pSqlString As String, ByVal pWhere As String, ByVal pItem As String, ByVal ParamArray pVisibleColumns() As String) ', ByVal pItemSelect As List(Of String))
        InitializeComponent()

        _Key = pKey
        _SelectMethod = AppRoot.ResponseListItemSelector.eSelectMethod.GetListForInsert
        _SqlString = pSqlString
        _Where = pWhere
        CurrValue.EditValue = pItem
        SetItems(pItem)
        OriginItems = Items
        If pVisibleColumns.Count > 0 Then
            For i As Integer = 1 To pVisibleColumns.Count
                _VisibleColumns.Add(pVisibleColumns(i - 1))
            Next
        End If
    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AddKeyCodeRegister(HTLFW.KeyInfor.eControlShiftAlt.None, Windows.Forms.Keys.Escape)
        AddKeyCodeRegister(HTLFW.KeyInfor.eControlShiftAlt.None, Windows.Forms.Keys.Enter)
        LoadData()
    End Sub

    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.Left = (HTLFW.AppBase.AppFullScreenSize.Width - Me.Width) / 2
    End Sub

    Private Sub Me_KeyCodePressed(ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyCodePressed
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            cmdExit.PerformClick()
        ElseIf e.KeyCode = Windows.Forms.Keys.Enter Then
            If gcData.IsFocused Then
                If gvData.RowCount = 1 Then
                    DoCheck(0)
                End If
            End If
        End If
    End Sub

    Private Sub Me_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        _VisibleColumns.Release()
        tblData.Release()
        ReleaseMemory()
    End Sub

#End Region

#Region "Subs"

    Private Sub LoadData()
        If DesignMode Then Exit Sub
        If Me.IsDisposed OrElse Me.Disposing Then Exit Sub
        'If Not IsHandleCreated Then Exit Sub
        If Not AppIsReady() Then Exit Sub
        If IsRunning Then Exit Sub
        IsRunning = True
        If Not FirstLoad Then AppDevWaitingForm.Show()
        tblData.Release()
        Using mConnection = AppConnectionCreateNew()
            Try
                tblData = mConnection.ExecuteDataTableEditable("SELECT *, CONVERT(BIT,0) as IsPicked FROM (" & _SqlString & ") AS D " & IIf(_Where <> "", " WHERE ", "") & _Where)
            Catch ex As Exception
                AppDevWaitingForm.Hide()
                Throw New System.Exception(ex.Message)
            End Try

            'Dim mCol As New DataColumn("IsPicked", GetType(Boolean))
            'mCol.DefaultValue = False
            'CType(tblData, DataTable).Columns.Add(mCol)
            For Each mItem As ListKeyValues.KeyValueObj In Items
                Try
                    Dim mRow As DataRow = CType(tblData, DataTable).Rows.OfType(Of DataRow)().FirstOrDefault(Function(pp) String.Compare(pp.Item(_Key), mItem.KeyValue.ToString, True) = 0)
                    If Not mRow Is Nothing Then
                        mRow.Item("IsPicked") = True
                        mRow = Nothing
                    End If
                Catch ex As Exception

                End Try
            Next
            grdColCode.FieldName = _Key
            For Each mColumn As System.Data.DataColumn In CType(tblData, DataTable).Columns
                If mColumn.ColumnName <> _Key And mColumn.ColumnName <> "IsPicked" Then
                    Dim mNewColumn As New DevExpress.XtraGrid.Columns.GridColumn
                    mNewColumn.Name = mColumn.ColumnName
                    mNewColumn.FieldName = mColumn.ColumnName
                    mNewColumn.Caption = mColumn.ColumnName
                    mNewColumn.OptionsColumn.AllowEdit = False
                    mNewColumn.OptionsColumn.AllowFocus = False
                    mNewColumn.OptionsColumn.ReadOnly = True
                    'Select Case mNewColumn.FieldName
                    '    Case "EMFullName", "Họ - Tên", "Họ và tên", "Tháng", "ThangFormat"
                    '        mNewColumn.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom
                    '    Case Else
                    mNewColumn.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default
                    'End Select
                    Select Case mColumn.DataType.ToString()
                        Case "System.DateTime", "System.Date"
                            mNewColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                            mNewColumn.DisplayFormat.FormatString = "dd/MM/yyyy"
                            mNewColumn.Width = 90
                            mNewColumn.AppearanceCell.Options.UseTextOptions = True
                            mNewColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                            mNewColumn.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.List
                            mNewColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals
                        Case "System.Double"
                            mNewColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                            mNewColumn.DisplayFormat.FormatString = DBs.SystemValues.GridFormatStringAdv(2)
                            mNewColumn.Width = 100
                            mNewColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals
                        Case "System.Decimal", "System.Integer"
                            mNewColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                            mNewColumn.DisplayFormat.FormatString = DBs.SystemValues.GridFormatStringAdv(0)
                            mNewColumn.Width = 100
                            mNewColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals
                        Case "System.Boolean"
                            mNewColumn.Width = 75
                            mNewColumn.AppearanceCell.Options.UseTextOptions = True
                            mNewColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                            mNewColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals
                        Case Else
                            mNewColumn.Width = 250
                            mNewColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
                    End Select
                    If _VisibleColumns IsNot Nothing AndAlso _VisibleColumns.Count > 0 Then
                        If Nz(_VisibleColumns.FirstOrDefault(Function(pp) String.Compare(pp, mColumn.ColumnName) = 0), "") <> "" Then
                            mNewColumn.VisibleIndex = grdColIsPicked.VisibleIndex - 1
                        End If
                    Else
                        mNewColumn.VisibleIndex = grdColIsPicked.VisibleIndex - 1
                    End If
                    gvData.Columns.Add(mNewColumn)
                End If
            Next

            mConnection.Release()
        End Using
        gcData.DataSource = tblData
        Dim mWidth As Integer = 0
        For Each mColumn As DevExpress.XtraGrid.Columns.GridColumn In gvData.Columns
            If mColumn.Visible Then
                mColumn.Width = mColumn.GetBestWidth + 10
                mWidth = mWidth + mColumn.Width
            End If
        Next
        If Me.Width < mWidth Then
            If mWidth <= HTLFW.AppBase.AppFullScreenSize.Width Then
                Me.Width = mWidth
                gvData.OptionsView.ColumnAutoWidth = True
            Else
                Me.Width = HTLFW.AppBase.AppFullScreenSize.Width
            End If
        Else
            gvData.OptionsView.ColumnAutoWidth = True
        End If
        IsRunning = False
        AppDevWaitingForm.Hide()
    End Sub

    Private Sub DoCheckAll()
        Try
            For i As Integer = 0 To gvData.RowCount - 1
                gvData.SetRowCellValue(i, "IsPicked", True)
            Next
            gvData.RefreshData()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DoUnCheckAll()
        Try
            For i As Integer = 0 To gvData.RowCount - 1
                gvData.SetRowCellValue(i, "IsPicked", False)
            Next
            gvData.RefreshData()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DoCheck()
        Try
            gvData.SetFocusedRowCellValue("IsPicked", True)
            gvData.RefreshData()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DoCheck(ByVal pRowHandle As Integer)
        Try
            gvData.SetRowCellValue(pRowHandle, "IsPicked", True)
            gvData.RefreshData()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DoUnCheck()
        Try
            gvData.SetFocusedRowCellValue("IsPicked", False)
            gvData.RefreshData()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DoReverse()
        Try
            gvData.SetFocusedRowCellValue("IsPicked", Not gvData.GetFocusedRowCellValue("IsPicked"))
            gvData.RefreshData()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DoReverseAll()
        Try
            For i As Integer = 0 To gvData.RowCount - 1
                gvData.SetRowCellValue(i, "IsPicked", Not gvData.GetRowCellValue(i, "IsPicked"))
            Next
            gvData.RefreshData()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub RefreshData()
        Items.Clear()
        For Each mRow As DataRow In tblData.Rows.OfType(Of DataRow).Where(Function(pp) pp.Item("IsPicked") = True).ToList
            Items.Add(New ListKeyValues.KeyValueObj(_Key, mRow.Item(_Key), mRow.Item(_Key)))
        Next
    End Sub

#End Region

#Region "Functions"

    Public Function GetItems() As String
        Try
            Dim mResult As String = ""
            For Each mItem In Items
                mResult = mResult + If(mResult <> "", ", ", "") + mItem.KeyName
            Next
            Return mResult
        Catch ex As Exception
            Return ""
        End Try
    End Function

#End Region

#Region "Controls Events"

#Region "Popup Menus"

    Private Sub mnuCheck_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuCheck.ItemClick
        DoCheck()
    End Sub

    Private Sub mnuUnCheck_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuUnCheck.ItemClick
        DoUnCheck()
    End Sub

    Private Sub mnuCheckAll_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuCheckAll.ItemClick
        DoCheckAll()
    End Sub

    Private Sub mnuUnCheckAll_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuUnCheckAll.ItemClick
        DoUnCheckAll()
    End Sub

    Private Sub mnuReverse_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuReverse.ItemClick
        DoReverse()
    End Sub

    Private Sub mnuReverseAll_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuReverseAll.ItemClick
        DoReverseAll()
    End Sub

#End Region

#Region "Buttons"

    Private Sub cmdCheckAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCheckAll.Click
        DoCheckAll()
    End Sub

    Private Sub cmdUnCheckAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnCheckAll.Click
        DoUnCheckAll()
    End Sub

    Private Sub cmdDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDone.Click
        RefreshData()
        Dim mResponseListItemSelector = New AppRoot.ResponseListItemSelector
        mResponseListItemSelector.SelectMethod = _SelectMethod
        mResponseListItemSelector.ItemList = _Items
        mResponseListItemSelector.ListItemReturn = AppRoot.ResponseListItemSelector.eListItemReturn.PickUp
        RaiseEvent ListItemSelected(mResponseListItemSelector)
        Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Dim mResponseListItemSelector = New AppRoot.ResponseListItemSelector
        mResponseListItemSelector.SelectMethod = SelectMethod
        mResponseListItemSelector.ItemList = OriginItems
        mResponseListItemSelector.ListItemReturn = AppRoot.ResponseListItemSelector.eListItemReturn.Cancel
        RaiseEvent ListItemSelected(mResponseListItemSelector)
        Close()
    End Sub

#End Region

#Region "Grids"

    Private Sub gcData_CommandShowContextMenu(pIsNoCurrentData As Boolean, pIsNoData As Boolean) Handles gcData.CommandShowContextMenu
        popmnuCheck.ShowPopup(Windows.Forms.Control.MousePosition)
    End Sub

    Private Sub gcData_RowDoubleClick(ByVal pRowHandle As Integer) Handles gcData.RowDoubleClick
        DoReverse()
    End Sub

    Dim mCountPicked As Integer = 0
    Private Sub gvListItem_CustomSummaryCalculate(ByVal sender As Object, ByVal e As DevExpress.Data.CustomSummaryEventArgs) Handles gvData.CustomSummaryCalculate
        Dim summaryID As String = CType(e.Item, DevExpress.XtraGrid.GridSummaryItem).Tag.ToString
        Dim mView As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        ' Initialization 
        If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Start Then
            mCountPicked = 0
        End If
        ' Calculation 
        If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Calculate Then
            Select Case summaryID
                Case "IsPicked" ' The total summary calculated against the 'UnitPrice' column. 
                    If CBool(mView.GetRowCellValue(e.RowHandle, "IsPicked")) Then
                        mCountPicked += 1
                    End If
            End Select
        End If
        ' Finalization 
        If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then
            Select Case summaryID
                Case "IsPicked"
                    e.TotalValue = mCountPicked
            End Select
        End If
    End Sub

    Private Sub colEditIsPicked_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles colEditIsPicked.CheckedChanged
        gvData.SetFocusedRowCellValue("IsPicked", CType(sender, DevExpress.XtraEditors.CheckEdit).Checked)
        gvData.RefreshData()
    End Sub

#End Region

#End Region

End Class