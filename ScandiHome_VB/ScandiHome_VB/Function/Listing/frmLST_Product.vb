#Region "References"

Imports HTLFW
Imports HTLFW.HTLLib
Imports HTLFW.HTLLib.HTLComFuncs
Imports HTLFW.HTLLib.HTLStringFuncs
Imports HTLFW.HTLLib.HTLLayoutDefinition
Imports DevExpress.XtraBars
Imports DBs.SystemValues
Imports ScandiHome_VB.AppConfig

#End Region

Public Class frmLST_Product


#Region "Declares"

    Private DataSourceTableName As String = "SCH_view_GetAllProduct"
    Private DataSourceTableNameDetail As String = "SCH_view_QuotaProductWithPrice"

    Protected MyListVisible As Boolean = True
    Protected CurrSKU As String

#End Region

#Region "Properties"

#End Region

#Region "Structors"

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        If DesignMode Then Exit Sub
        If Me.IsDisposed OrElse Me.Disposing Then Exit Sub
        If Me.Modal Then Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Me_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ReleaseMemory()
    End Sub

#End Region

#Region "Overrides"

    Public Overrides Sub RefreshSourceString()
        Dim mWhere As String = String.Empty 'ucCondNhom.Get_CodeIDCondition("Nhom")
        Me.SourceString = "SELECT * FROM lstv_HangHoa " & If(mWhere <> "", " WHERE " & mWhere, "")
    End Sub

    Public Overrides Sub Run_OnRefreshData()
        If Not MyListVisible Then
            Dim mRowHandle As Integer = gvDataDetail.FocusedRowHandle
            If IsNoValue(CurrSKU) Then
                Using mData = AppConfigHelper.GetDataTable("SELECT * FROM " & DataSourceTableName & "")
                    gcData.DataSource = mData
                End Using
            Else
                Using mData = AppConfigHelper.GetDataTable("SELECT " +
                                                                "ROW_NUMBER() OVER (ORDER BY SKU) AS ID " +
                                                                ", * " +
                                                                ", (SELECT PQ.ProductName FROM ProductQuota PQ WHERE D.ProductMaterialCode = PQ.ProductCode) AS ProductMaterialName " +
                                                                ", (SELECT DD.ProductName FROM SCH_view_GetAllProduct DD WHERE DD.SKU = D.SKU) AS ProductName " +
                                                                ", (SELECT DD.CategoryCode FROM SCH_view_GetAllProduct DD WHERE DD.SKU = D.SKU) AS CategoryCode " +
                                                                ", (SELECT DD.ModelSKUCode FROM SCH_view_GetAllProduct DD WHERE DD.SKU = D.SKU) AS ModelSKUCode " +
                                                                ", (SELECT DD.InhouseSeries FROM SCH_view_GetAllProduct DD WHERE DD.SKU = D.SKU) AS SeriesName " +
                                                                ", (SELECT DD.NewProductNote FROM SCH_view_GetAllProduct DD WHERE DD.SKU = D.SKU) AS NewProductNote " +
                                                           "FROM dbo.SCH_view_QuotaProductWithPrice D " +
                                                           "WHERE " +
                                                                "D.SKU = N'" + CurrSKU + "' " +
                                                           "ORDER BY D.SKU, D.BP DESC, D.TP DESC")
                    gcDataDetail.DataSource = mData
                End Using
            End If
            Try
                gvDataDetail.FocusedRowHandle = mRowHandle
            Catch ex As Exception
            End Try
        End If

        cmdView.Visible = MyListVisible
        cmdAdd.Visible = MyListVisible
        cmdDelete.Visible = MyListVisible
        cmdModify.Visible = MyListVisible

        tlpList.ColumnStyles(0).Width = If(MyListVisible, 100.0, 0.0)
        tlpList.ColumnStyles(1).Width = If(Not MyListVisible, 100.0, 0.0)
        If tlpList.ColumnStyles(0).Width <> 0.0 Then
            gvData.Focus()
        Else
            gvDataDetail.Focus()
        End If
    End Sub

    'Public Overrides Sub RefreshPrimaryKeyValue()
    '    PrimaryKey.KeyValue("MaHang") = dSKU()
    'End Sub

    'Public Overrides Sub DoShowContextMenu(pIsNoCurrentData As Boolean, pIsNoData As Boolean)
    '    InitNhomHang()
    '    bbiChangeGroup.Visibility = If(Permission.AllowEDIT AndAlso gvData.GetSelectedRows.Count > 0, DevExpress.XtraBars.BarItemVisibility.Always, DevExpress.XtraBars.BarItemVisibility.Never)
    '    bbiNA.Visibility = If(Permission.AllowEDIT AndAlso gvData.GetSelectedRows.Count > 0, DevExpress.XtraBars.BarItemVisibility.Always, DevExpress.XtraBars.BarItemVisibility.Never)
    '    bbiInMaVach.Visibility = If(SUDUNG_MAVACH() AndAlso Permission_InMaVach.AllowVIEW AndAlso gvData.GetSelectedRows.Count > 0, DevExpress.XtraBars.BarItemVisibility.Always, DevExpress.XtraBars.BarItemVisibility.Never)
    '    MyBase.DoShowContextMenu(pIsNoCurrentData, pIsNoData)
    'End Sub

#End Region

#Region "Events"

    Private Sub Me_NeedDataAdd() Handles Me.NeedDataAdd
        Try
            AppDevWaitingForm.Show()
            'Using mForm As New frmLST_HangHoa_Input(eFormMode.Add, PrimaryKey.ResetValue)
            '    AddHandler mForm.NeedRefreshData, AddressOf Process_InputForm_NeedRefreshData
            '    mForm.FunctionID = FunctionID
            '    mForm.ShowDialog(Me)
            '    mForm.Release()
            'End Using
            AppDevWaitingForm.Hide()
        Catch ex As Exception
            ShowErrorStop(ex.Message)
        End Try
    End Sub

    Private Sub Me_NeedDataDelete() Handles Me.NeedDataDelete
        'Try
        '    AppDevWaitingForm.Show()

        '    RefreshPrimaryKeyValue()

        '    Dim mMaHang As String = dMaHang()
        '    Dim mTenHang As String = dTenHang()

        '    ' Giữ DBContext
        '    Dim mDBContext = DBContext()
        '    mDBContext.TransactionStart()

        '    ' Kiểm tra record hiện hành có dữ liệu hay không
        '    If IsNoValue(mMaHang) OrElse Not mDBContext.DExists(DataSourceTableName, "MaHang=N'" & mMaHang & "'") Then
        '        mDBContext.TransactionRollback()
        '        mDBContext.Release()
        '        ShowNoData()
        '        RefreshData()
        '        Exit Sub
        '    Else
        '        If mDBContext.DExists(DataSourceTableName, "MaHang=N'" & mMaHang & "' AND (RefLocked & 1024)=1024") Then
        '            mDBContext.TransactionRollback()
        '            mDBContext.Release()
        '            ShowErrorStop("Dữ liệu đang bị khóa bởi Kiểm soát! Không thể xóa.")
        '            Exit Sub
        '        ElseIf mDBContext.DExists(DataSourceTableName, "MaHang=N'" & mMaHang & "' AND (RefLocked & 1)=1 AND ComputerName<>HOST_NAME()") Then
        '            mDBContext.TransactionRollback()
        '            mDBContext.Release()
        '            ShowErrorStop("Dữ liệu đang bị khóa cập nhật bởi người dùng khác! Không thể xóa.")
        '            Exit Sub
        '        ElseIf mDBContext.DExists(DataSourceTableName, "MaHang=N'" & mMaHang & "' AND (RefLocked & 2)=2 AND ComputerName<>HOST_NAME()") Then
        '            mDBContext.TransactionRollback()
        '            mDBContext.Release()
        '            ShowErrorStop("Dữ liệu đang được xử lý bởi người dùng khác! Không thể xóa.")
        '            Exit Sub
        '        End If
        '    End If

        '    Dim mWillDelObjs = mDBContext.COM_fGETBIT_ObjectModifyDelete(MyObjectType, dMaHang).OrderBy(Function(pp) pp.ObjectSourceDes)
        '    If Not mWillDelObjs Is Nothing AndAlso mWillDelObjs.Count > 0 Then
        '        Dim mStrSource As String = ""
        '        For Each mWillDelObj In mWillDelObjs
        '            mStrSource = mStrSource + If(mStrSource <> "", vbNewLine, "") + "     " + mWillDelObj.ObjectSourceDes
        '        Next
        '        mDBContext.TransactionRollback()
        '        mDBContext.Release()
        '        mWillDelObjs = Nothing
        '        ShowErrorStop(TranslateResource(HTLFW.My.Resources.MessageContent.infoErrorDeleteFailedInUseAdv, New String() {mStrSource}))
        '        Exit Sub
        '    End If

        '    Try
        '        mDBContext.Execute("UPDATE " & DataSourceTableName & " " &
        '                            "SET " &
        '                                "RefLocked=RefLocked+(CASE WHEN (RefLocked & 2)<>2 THEN 2 ELSE 0 END)" &
        '                                ",ComputerName=HOST_NAME() " &
        '                            "WHERE " &
        '                                "MaHang=N'" & mMaHang & "' " &
        '                            "")
        '        mDBContext.SubmitChanges()
        '        mDBContext.TransactionCommit
        '    Catch ex As Exception
        '        mDBContext.TransactionRollback
        '        mDBContext.Release
        '        ShowUnknownError(ex.Message)
        '        Exit Sub
        '    End Try

        '    ' Xác nhận với User xóa record
        '    If ShowConfirmDelete2(grdCol_MaHang.Caption, mMaHang, grdCol_TenHang.Caption, mTenHang) = Windows.Forms.DialogResult.No Then
        '        mDBContext.TransactionStart
        '        Try
        '            mDBContext.Execute("UPDATE " & DataSourceTableName & " " &
        '                                "SET " &
        '                                    "RefLocked=RefLocked-(CASE WHEN (RefLocked & 2)=2 THEN 2 ELSE 0 END)" &
        '                                    ",ComputerName=HOST_NAME() " &
        '                                "WHERE " &
        '                                    "MaHang=N'" & mMaHang & "' " &
        '                                "")
        '            mDBContext.SubmitChanges()
        '            mDBContext.TransactionCommit()
        '        Catch ex As Exception
        '            mDBContext.TransactionRollback()
        '            mDBContext.Release
        '            ShowUnknownError(ex.Message)
        '            Exit Sub
        '        End Try
        '        mDBContext.Release()
        '        Exit Sub
        '    End If

        '    AppDevWaitingForm.Show()
        '    mDBContext.TransactionStart
        '    Try
        '        mDBContext.Execute("DELETE FROM " & DataSourceTableName & " WHERE MaHang=N'" & mMaHang & "'")
        '        mDBContext.SubmitChanges()

        '        ' Cập nhật history
        '        mDBContext.AppendToAppHistory("DELETE " + DataSourceTableName, "MaHang=[" + mMaHang + "]")
        '        mDBContext.SubmitChanges()

        '        mDBContext.TransactionCommit()
        '    Catch ex As Exception
        '        mDBContext.TransactionRollback()
        '        mDBContext.Release()
        '        ShowUnknownError(ex.Message)
        '        Exit Sub
        '    End Try
        '    mDBContext.Release()

        '    FirstLoad = True
        '    RefreshData()
        '    FirstLoad = False
        '    CatchRelateChanged(Me)
        '    SendRequestToServer(FunctionID)

        '    AppDevWaitingForm.Hide()
        'Catch ex As Exception
        '    ShowErrorStop(ex.Message)
        'End Try
    End Sub

    Private Sub Me_NeedDataEdit() Handles Me.NeedDataEdit
        'Try
        '    AppDevWaitingForm.Show()

        '    RefreshPrimaryKeyValue()

        '    Dim mMaHang As String = dMaHang()

        '    ' Giữ DBContext
        '    Dim mDBContext = DBContext()
        '    mDBContext.TransactionStart()

        '    ' Kiểm tra record hiện hành có dữ liệu hay không
        '    If IsNoValue(mMaHang) OrElse Not mDBContext.DExists(DataSourceTableName, "MaHang=N'" & mMaHang & "'") Then
        '        mDBContext.TransactionRollback()
        '        mDBContext.Release()
        '        ShowNoData()
        '        RefreshData()
        '        Exit Sub
        '    Else
        '        If mDBContext.DExists(DataSourceTableName, "MaHang=N'" & mMaHang & "' AND (RefLocked & 1024)=1024") Then
        '            mDBContext.TransactionRollback()
        '            mDBContext.Release()
        '            ShowErrorStop("Dữ liệu đang bị khóa bởi Kiểm soát! Không thể sửa.")
        '            Exit Sub
        '        ElseIf mDBContext.DExists(DataSourceTableName, "MaHang=N'" & mMaHang & "' AND (RefLocked & 1)=1 AND ComputerName<>HOST_NAME()") Then
        '            mDBContext.TransactionRollback()
        '            mDBContext.Release()
        '            ShowErrorStop("Dữ liệu đang bị khóa cập nhật bởi người dùng khác! Không thể sửa.")
        '            Exit Sub
        '        ElseIf mDBContext.DExists(DataSourceTableName, "MaHang=N'" & mMaHang & "' AND (RefLocked & 2)=2 AND ComputerName<>HOST_NAME()") Then
        '            mDBContext.TransactionRollback()
        '            mDBContext.Release()
        '            ShowErrorStop("Dữ liệu đang được xử lý bởi người dùng khác! Không thể sửa.")
        '            Exit Sub
        '        End If
        '    End If

        '    Try
        '        mDBContext.Execute("UPDATE " & DataSourceTableName & " " &
        '                            "SET " &
        '                                "RefLocked=RefLocked+(CASE WHEN (RefLocked & 1)<>1 THEN 1 ELSE 0 END)" &
        '                                ",ComputerName=HOST_NAME() " &
        '                            "WHERE " &
        '                                "MaHang=N'" & mMaHang & "' " &
        '                            "")
        '        mDBContext.SubmitChanges()
        '        mDBContext.TransactionCommit()
        '    Catch ex As Exception
        '        mDBContext.TransactionRollback()
        '        mDBContext.Release()
        '        ShowErrorStop(ex.Message)
        '        Exit Sub
        '    End Try

        '    Dim mAllowCodeChange As Boolean = True
        '    mAllowCodeChange = If(mDBContext.COM_fGETBIT_ObjectModifyDelete(MyObjectType, mMaHang).FirstOrDefault() Is Nothing, True, False)
        '    mDBContext.Release()

        '    Try
        '        Using mForm As New frmLST_HangHoa_Input(eFormMode.Modify, PrimaryKey, mAllowCodeChange)
        '            AddHandler mForm.NeedRefreshData, AddressOf Process_InputForm_NeedRefreshData
        '            mForm.FunctionID = FunctionID
        '            mForm.ShowDialog(Me)
        '            mForm.Release
        '        End Using
        '    Catch ex As Exception
        '        ShowErrorStop(ex.Message)
        '    End Try

        '    mDBContext = DBContextCreateNew()
        '    mDBContext.TransactionStart()
        '    Try
        '        mDBContext.Execute("UPDATE " & DataSourceTableName & " " &
        '                            "SET " &
        '                                "RefLocked=RefLocked-(CASE WHEN (RefLocked & 1)=1 THEN 1 ELSE 0 END)" &
        '                                ",ComputerName=HOST_NAME() " &
        '                            "WHERE " &
        '                                "MaHang=N'" & mMaHang & "' " &
        '                            "")
        '        mDBContext.SubmitChanges()
        '        mDBContext.TransactionCommit
        '    Catch ex As Exception
        '        mDBContext.TransactionRollback
        '        mDBContext.Release
        '        ShowErrorStop(ex.Message)
        '        Exit Sub
        '    End Try
        '    mDBContext.Release

        '    RefreshPrimaryKeyValue()

        '    AppDevWaitingForm.Hide()
        'Catch ex As Exception
        '    ShowErrorStop(ex.Message)
        'End Try
    End Sub

    Private Sub Me_NeedDataView() Handles Me.NeedDataView
        Try
            'RefreshPrimaryKeyValue()

            'Dim mMaHang As String = dMaHang()

            '' Kiểm tra record hiện hành có dữ liệu hay không
            'If IsNoValue(mMaHang) OrElse Not DExists(DataSourceTableName, "MaHang=N'" & mMaHang & "'") Then
            '    ShowNoData()
            '    RefreshData()
            '    Exit Sub
            'Else
            '    AppDevWaitingForm.Show()
            '    Using mForm As New frmLST_HangHoa_Input(eFormMode.View, PrimaryKey)
            '        mForm.FunctionID = FunctionID
            '        mForm.ShowDialog(Me)
            '        mForm.Release()
            '    End Using
            '    AppDevWaitingForm.Hide()
            'End If
        Catch ex As Exception
            ShowErrorStop(ex.Message)
        End Try
    End Sub

    Private Sub Me_NeedDataExportExcel() Handles Me.NeedDataExportExcel
        Try
            If MyGridView.RowCount = 0 Then
                ShowNoData()
                RefreshData()
                Exit Sub
            End If
            AppDevWaitingForm.Show()
            If MyListVisible Then
                HTLLib.HTLComFuncs.DataExcelByGrid(MyGridView, Text)
            Else
                HTLLib.HTLComFuncs.DataExcelByGrid(gvDataDetail, Text)
            End If
            AppDevWaitingForm.Hide()
        Catch ex As Exception
            ShowErrorStop(ex.Message)
        End Try
    End Sub

#End Region

#Region "Functions"

    Public Overridable Function dSKU() As String
        If MyListVisible Then
            If gvData.FocusedRowHandle < 0 Then
                Return Nothing
            Else
                Try
                    Return gvData.GetRowCellValue(gvData.FocusedRowHandle, "SKU").ToString
                Catch ex As Exception
                    Return Nothing
                End Try
            End If
        Else
            If gvDataDetail.FocusedRowHandle < 0 Then
                Return Nothing
            Else
                Try
                    Return gvDataDetail.GetRowCellValue(gvDataDetail.FocusedRowHandle, "SKU").ToString
                Catch ex As Exception
                    Return Nothing
                End Try
            End If
        End If
    End Function

    Private Sub frmLST_Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AppDevWaitingForm.Show()
        Using mData = AppConfigHelper.GetDataTable("SELECT * FROM " & DataSourceTableName & "")
            gcData.DataSource = mData
        End Using
        tlpList.ColumnStyles(0).Width = 100.0
        tlpList.ColumnStyles(1).Width = 0.0
        If tlpList.ColumnStyles(0).Width <> 0.0 Then
            gvData.Focus()
        Else
            gvDataDetail.Focus()
        End If
        AppDevWaitingForm.Hide()
    End Sub

    Private Sub frmLST_Product_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F4 Then
            CurrSKU = dSKU()
            MyListVisible = Not MyListVisible
            If Not MyListVisible Then AppDevWaitingForm.Show()
            Run_OnRefreshData()
            If Not MyListVisible Then AppDevWaitingForm.Hide()
        End If
    End Sub

    Private Sub cmdRefresh_Click_1(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        Run_OnRefreshData()
    End Sub

#End Region


End Class