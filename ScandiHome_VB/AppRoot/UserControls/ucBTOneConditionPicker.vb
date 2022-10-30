#Region "Refs"

Imports System.ComponentModel
Imports HTLFW
Imports HTLFW.HTLLib.HTLComFuncs
Imports HTLFW.HTLLib.HTLLayoutDefinition

#End Region

<ToolboxItem(True)>
Public Class ucBTOneConditionPicker

#Region "Declares"

    Public Enum eCondition
        eKhac = 0

        eDoiTuong = 1
        eNhomDoiTuong = 2

        eNCC = 3
        eNhomNCC = 4
        eKH = 5
        eNhomKH = 6

        eHangHoa = 7
        eNhomHangHoa = 8

        eLapRap = 9
        eNhomLapRap = 10
        eLapRapLuuKho = 11
        eNhomLapRapLuuKho = 12
        eThuong = 13
        eNhomThuong = 14
        eLuuKho = 15
        eNhomLuuKho = 16

        eHangMucThu = 17
        eHangMucChi = 18

        eNhomGia = 19

        eHangHoaBarCode = 20
        eNhomHangHoaBarCode = 21

        eKhoHang = 22

        eQuay = 23

        eHangHoaDauVao = 24
        eNhomHangHoaDauVao = 25
        eHangHoaDauRa = 26
        eNhomHangHoaDauRa = 27
        eHangHoaTrongKho = 28
        eNhomHangHoaTrongKho = 29
    End Enum

    Private _CodeIDKeyDescription As String = "Key Name"

    Private _IsReadOnly As Boolean = False
    Private _ConditionType As eCondition = eCondition.eKhac

    Public CodeIDNeedLoad As Boolean = True

#End Region

#Region "Properties"

    Public Property ConditionType() As eCondition
        Get
            Return _ConditionType
        End Get
        Set(ByVal value As eCondition)
            If Not _ConditionType.Equals(value) Then
                Select Case value
                    Case eCondition.eDoiTuong
                        CodeIDKey = "Ma"
                        CodeIDKeyName = "Ten"
                        CodeIDKeyDescription = "Đối tượng"
                        CodeIDSource = "lsttbl_DoiTuong"
                        CodeIDSourceFilter = ""
                    Case eCondition.eNhomDoiTuong
                        CodeIDKey = "Ma"
                        CodeIDKeyName = "Ten"
                        CodeIDKeyDescription = "Nhóm"
                        CodeIDSource = "lsttbl_DMChung"
                        CodeIDSourceFilter = "Loai=N'NHOMDOITUONG'"
                    Case eCondition.eNCC
                        CodeIDKey = "Ma"
                        CodeIDKeyName = "Ten"
                        CodeIDKeyDescription = "Nhà C.Cấp"
                        CodeIDSource = "lsttbl_DoiTuong"
                        CodeIDSourceFilter = "(Loai & 1)=1"
                    Case eCondition.eNhomNCC
                        CodeIDKey = "Ma"
                        CodeIDKeyName = "Ten"
                        CodeIDKeyDescription = "Nhóm"
                        CodeIDSource = "lsttbl_DMChung"
                        CodeIDSourceFilter = "Loai=N'NHOMDOITUONG' AND EXISTS (SELECT NULL FROM lsttbl_DoiTuong D WHERE D.Nhom=lsttbl_DMChung.Ma AND (Loai & 1)=1)"
                    Case eCondition.eKH
                        CodeIDKey = "Ma"
                        CodeIDKeyName = "Ten"
                        CodeIDKeyDescription = "Khách hàng"
                        CodeIDSource = "lsttbl_DoiTuong"
                        CodeIDSourceFilter = "(Loai & 2)=2"
                    Case eCondition.eNhomKH
                        CodeIDKey = "Ma"
                        CodeIDKeyName = "Ten"
                        CodeIDKeyDescription = "Nhóm"
                        CodeIDSource = "lsttbl_DMChung"
                        CodeIDSourceFilter = "Loai=N'NHOMDOITUONG' AND EXISTS (SELECT NULL FROM lsttbl_DoiTuong D WHERE D.Nhom=lsttbl_DMChung.Ma AND (Loai & 2)=2)"

                    Case eCondition.eHangHoa
                        CodeIDKey = "MaHang"
                        CodeIDKeyName = "TenHang"
                        CodeIDKeyDescription = "Hàng hóa"
                        CodeIDSource = "lsttbl_HangHoa"
                        CodeIDSourceFilter = ""
                    Case eCondition.eNhomHangHoa
                        CodeIDKey = "MaNhom"
                        CodeIDKeyName = "TenNhom"
                        CodeIDKeyDescription = "Nhóm"
                        CodeIDSource = "lsttbl_NhomHang"
                        CodeIDSourceFilter = ""

                    Case eCondition.eLapRap
                        CodeIDKey = "MaHang"
                        CodeIDKeyName = "TenHang"
                        CodeIDKeyDescription = "Hàng hóa"
                        CodeIDSource = "lsttbl_HangHoa"
                        CodeIDSourceFilter = "LapRap=1 AND TonKho=0"
                    Case eCondition.eNhomLapRap
                        CodeIDKey = "MaNhom"
                        CodeIDKeyName = "TenNhom"
                        CodeIDKeyDescription = "Nhóm"
                        CodeIDSource = "lsttbl_NhomHang"
                        CodeIDSourceFilter = "EXISTS (SELECT NULL FROM lsttbl_HangHoa D WHERE D.Nhom=lsttbl_NhomHang.MaNhom AND (D.LapRap=1 AND D.TonKho=0))"
                    Case eCondition.eLapRapLuuKho
                        CodeIDKey = "MaHang"
                        CodeIDKeyName = "TenHang"
                        CodeIDKeyDescription = "Hàng hóa"
                        CodeIDSource = "lsttbl_HangHoa"
                        CodeIDSourceFilter = "LapRap=1 AND TonKho=1"
                    Case eCondition.eNhomLapRapLuuKho
                        CodeIDKey = "MaNhom"
                        CodeIDKeyName = "TenNhom"
                        CodeIDKeyDescription = "Nhóm"
                        CodeIDSource = "lsttbl_NhomHang"
                        CodeIDSourceFilter = "EXISTS (SELECT NULL FROM lsttbl_HangHoa D WHERE D.Nhom=lsttbl_NhomHang.MaNhom AND (D.LapRap=1 AND D.TonKho=1))"
                    Case eCondition.eThuong
                        CodeIDKey = "MaHang"
                        CodeIDKeyName = "TenHang"
                        CodeIDKeyDescription = "Hàng hóa"
                        CodeIDSource = "lsttbl_HangHoa"
                        CodeIDSourceFilter = "LapRap=0"
                    Case eCondition.eNhomThuong
                        CodeIDKey = "MaNhom"
                        CodeIDKeyName = "TenNhom"
                        CodeIDKeyDescription = "Nhóm"
                        CodeIDSource = "lsttbl_NhomHang"
                        CodeIDSourceFilter = "EXISTS (SELECT NULL FROM lsttbl_HangHoa D WHERE D.Nhom=lsttbl_NhomHang.MaNhom AND D.LapRap=0)"
                    Case eCondition.eLuuKho
                        CodeIDKey = "MaHang"
                        CodeIDKeyName = "TenHang"
                        CodeIDKeyDescription = "Hàng hóa"
                        CodeIDSource = "lsttbl_HangHoa"
                        CodeIDSourceFilter = "TonKho<>0"
                    Case eCondition.eNhomLuuKho
                        CodeIDKey = "MaNhom"
                        CodeIDKeyName = "TenNhom"
                        CodeIDKeyDescription = "Nhóm"
                        CodeIDSource = "lsttbl_NhomHang"
                        CodeIDSourceFilter = "EXISTS (SELECT NULL FROM lsttbl_HangHoa D WHERE D.Nhom=lsttbl_NhomHang.MaNhom AND D.TonKho<>0)"

                    Case eCondition.eHangMucThu
                        CodeIDKey = "Ma"
                        CodeIDKeyName = "Ten"
                        CodeIDKeyDescription = "H.Mục thu"
                        CodeIDSource = "lsttbl_DMChung"
                        CodeIDSourceFilter = "Loai=N'HANGMUC_THU'"
                    Case eCondition.eHangMucChi
                        CodeIDKey = "Ma"
                        CodeIDKeyName = "Ten"
                        CodeIDKeyDescription = "H.Mục chi"
                        CodeIDSource = "lsttbl_DMChung"
                        CodeIDSourceFilter = "Loai=N'HANGMUC_CHI'"

                    Case eCondition.eNhomGia
                        CodeIDKey = "NhomGia"
                        CodeIDKeyName = "TenNhomGia"
                        CodeIDKeyDescription = "Bảng giá"
                        CodeIDSource = "dattbl_NhomGia"
                        CodeIDSourceFilter = ""

                    Case eCondition.eHangHoaBarCode
                        CodeIDKey = "MaHang"
                        CodeIDKeyName = "TenHang"
                        CodeIDKeyDescription = "Hàng hóa"
                        CodeIDSource = "lsttbl_HangHoa"
                        CodeIDSourceFilter = "(NOT MaVach IS NULL OR MaVach='')"
                    Case eCondition.eNhomHangHoaBarCode
                        CodeIDKey = "MaNhom"
                        CodeIDKeyName = "TenNhom"
                        CodeIDKeyDescription = "Nhóm"
                        CodeIDSource = "lsttbl_NhomHang"
                        CodeIDSourceFilter = "EXISTS (SELECT NULL FROM lsttbl_HangHoa DD WHERE DD.Nhom=lsttbl_NhomHang.MaNhom AND (NOT DD.MaVach IS NULL OR DD.MaVach=''))"

                    Case eCondition.eKhoHang
                        CodeIDKey = "MaKho"
                        CodeIDKeyName = "TenKho"
                        CodeIDKeyDescription = "Kho hàng"
                        CodeIDSource = "lsttbl_KhoHang"
                        CodeIDSourceFilter = ""

                    Case eCondition.eQuay
                        CodeIDKey = "Quay"
                        CodeIDKeyName = "TenMayTinh"
                        CodeIDKeyDescription = "Quầy"
                        CodeIDSource = "lsttbl_QuayTinhTien"
                        CodeIDSourceFilter = ""

                    Case eCondition.eHangHoaDauVao
                        CodeIDKey = "MaHang"
                        CodeIDKeyName = "TenHang"
                        CodeIDKeyDescription = "Hàng hóa"
                        CodeIDSource = "lsttbl_HangHoa"
                        CodeIDSourceFilter = "(LapRap=0 AND TonKho<>0)"
                    Case eCondition.eNhomHangHoaDauVao
                        CodeIDKey = "MaNhom"
                        CodeIDKeyName = "TenNhom"
                        CodeIDKeyDescription = "Nhóm"
                        CodeIDSource = "lsttbl_NhomHang"
                        CodeIDSourceFilter = "EXISTS (SELECT NULL FROM lsttbl_HangHoa D WHERE D.Nhom=lsttbl_NhomHang.MaNhom AND (D.LapRap=0 AND D.TonKho<>0)"
                    Case eCondition.eHangHoaDauRa
                        CodeIDKey = "MaHang"
                        CodeIDKeyName = "TenHang"
                        CodeIDKeyDescription = "Hàng hóa"
                        CodeIDSource = "lsttbl_HangHoa"
                        CodeIDSourceFilter = ""
                    Case eCondition.eNhomHangHoaDauRa
                        CodeIDKey = "MaNhom"
                        CodeIDKeyName = "TenNhom"
                        CodeIDKeyDescription = "Nhóm"
                        CodeIDSource = "lsttbl_NhomHang"
                        CodeIDSourceFilter = ""
                    Case eCondition.eHangHoaTrongKho
                        CodeIDKey = "MaHang"
                        CodeIDKeyName = "TenHang"
                        CodeIDKeyDescription = "Hàng hóa"
                        CodeIDSource = "lsttbl_HangHoa"
                        CodeIDSourceFilter = "TonKho<>0"
                    Case eCondition.eNhomHangHoaTrongKho
                        CodeIDKey = "MaNhom"
                        CodeIDKeyName = "TenNhom"
                        CodeIDKeyDescription = "Nhóm"
                        CodeIDSource = "lsttbl_NhomHang"
                        CodeIDSourceFilter = "EXISTS (SELECT NULL FROM lsttbl_HangHoa D WHERE D.Nhom=lsttbl_NhomHang.MaNhom AND D.TonKho<>0)"
                End Select
            End If
            _ConditionType = value
        End Set
    End Property

    Public Property CodeIDKey() As String = "ColCodeFieldName"
    Public Property CodeIDKeyName() As String = "ColNameFieldName"
    Public Property CodeIDKeyDescription() As String
        Get
            Return _CodeIDKeyDescription
        End Get
        Set(ByVal value As String)
            _CodeIDKeyDescription = value
            lblCodeIDFrom.Text = _CodeIDKeyDescription
        End Set
    End Property
    Public Property CodeIDSource() As String = "Table_View_SourceName"
    Public Property CodeIDSourceFilter() As String = ""

    Public Property IsReadOnly() As Boolean
        Get
            Return _IsReadOnly
        End Get
        Set(ByVal value As Boolean)
            _IsReadOnly = value
            cmdPickListCodeIDs.Enabled = Not _IsReadOnly
            cboCodeIDFrom.Properties.ReadOnly = _IsReadOnly
            cboCodeIDTo.Properties.ReadOnly = _IsReadOnly
            chkcboCodeIDs.Properties.ReadOnly = _IsReadOnly
        End Set
    End Property

    Public Property ColumnNameWidhRate() As Double = 2.25

    Public Property CodeFromValue() As Object
        Get
            Return cboCodeIDFrom.EditValue
        End Get
        Set(ByVal value As Object)
            cboCodeIDFrom.EditValue = value
        End Set
    End Property

    Public Property CodeToValue() As Object
        Get
            Return cboCodeIDTo.EditValue
        End Get
        Set(ByVal value As Object)
            cboCodeIDTo.EditValue = value
        End Set
    End Property

    Public Property CodeCheckValue() As Object
        Get
            Return chkcboCodeIDs.EditValue
        End Get
        Set(ByVal value As Object)
            chkcboCodeIDs.EditValue = value
            If Not DesignMode Then
                chkcboCodeIDs.RefreshEditValue()
            End If
        End Set
    End Property

#End Region

#Region "Constructors"

    Public Sub New()
        InitializeComponent()
    End Sub

#End Region

#Region "Overrides"

    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        MyBase.OnResize(e)
        Me.Height = 49
        RefreshCodeIDComboWidth()
    End Sub

#End Region

#Region "Subs"

    Private Sub RefreshCodeIDComboWidth()
        If DesignMode Then Exit Sub
        If Me.IsDisposed OrElse Me.Disposing Then Exit Sub
        If Not IsHandleCreated Then Exit Sub
        If Not AppIsReady() Then Exit Sub
        If Not cboCodeIDFrom.Properties.DataSource Is Nothing Then
            Dim mDataCount = CType(cboCodeIDTo.Properties.DataSource, DataTable).Rows.Count
            ApplyComboSize(cboCodeIDFrom, mDataCount, New Integer() {cboCodeIDFrom.Width, cboCodeIDFrom.Width * ColumnNameWidhRate}, True)
            ApplyComboSize(cboCodeIDTo, mDataCount, New Integer() {cboCodeIDTo.Width, cboCodeIDTo.Width * ColumnNameWidhRate}, True)
            ApplyComboSize(chkcboCodeIDs, mDataCount, New Integer() {0, 0, chkcboCodeIDs.Width}, True)
        End If
    End Sub

    Public Sub LoadComboData_CodeID()
        Using mConnection = AppConnectionCreateNew()
            Using mData = mConnection.ExecuteDataTable("SELECT " & CodeIDKey & " as ColCode, " & CodeIDKeyName & " as ColName, " & CodeIDKey & " + ' - ' + " & CodeIDKeyName & " as ColName2 FROM " & _CodeIDSource & If(_CodeIDSourceFilter <> "", " WHERE " & _CodeIDSourceFilter, ""))
                cboCodeIDFrom.Properties.DataSource = mData
                cboCodeIDTo.Properties.DataSource = mData
                chkcboCodeIDs.Properties.DataSource = mData
            End Using
            mConnection.Release()
        End Using
        RefreshCodeIDComboWidth()
    End Sub

    Public Sub ResetValue()
        cboCodeIDFrom.EditValue = Nothing
        cboCodeIDTo.EditValue = Nothing
        chkcboCodeIDs.EditValue = Nothing
        chkcboCodeIDs.Refresh()
    End Sub

#End Region

#Region "Functions"

    Public Function GetSQL_CodeIDConditionFrom() As String
        If Not IsNoValue(cboCodeIDFrom.EditValue) Then
            Return "N'" & cboCodeIDFrom.EditValue.ToString & "'"
        Else
            Return "NULL"
        End If
    End Function
    Public Function GetSQL_CodeIDConditionTo() As String
        If Not IsNoValue(cboCodeIDTo.EditValue) Then
            Return "N'" & cboCodeIDTo.EditValue.ToString & "'"
        Else
            Return "NULL"
        End If
    End Function
    Public Function GetSQL_CodeIDCheck() As String
        If Not IsNoValue(chkcboCodeIDs.EditValue) Then
            Return "N'" & Replace(chkcboCodeIDs.EditValue.ToString, ", ", ",") & "'"
        Else
            Return "NULL"
        End If
    End Function
    Public Function Get_CodeIDCondition() As String
        Dim mResult As String = ""
        If Not IsNoValue(cboCodeIDFrom.EditValue) Then
            mResult = mResult & If(mResult <> "", " AND ", "") & CodeIDKey & " BETWEEN N'" & cboCodeIDFrom.EditValue.ToString & "' AND N'" & cboCodeIDTo.EditValue.ToString & "'"
        End If
        If Not IsNoValue(chkcboCodeIDs.EditValue) Then
            mResult = mResult & If(mResult <> "", " AND ", "") & CodeIDKey & " IN (" & "N'" & Replace(chkcboCodeIDs.EditValue.ToString, ", ", "',N'") & "'" & ")"
        End If
        Return mResult
    End Function
    Public Function Get_CodeIDCondition(ByVal pCodeIDKey As String) As String
        Dim mResult As String = ""
        If Not IsNoValue(cboCodeIDFrom.EditValue) Then
            mResult = mResult & If(mResult <> "", " AND ", "") & pCodeIDKey & " BETWEEN N'" & cboCodeIDFrom.EditValue.ToString & "' AND N'" & cboCodeIDTo.EditValue.ToString & "'"
        End If
        If Not IsNoValue(chkcboCodeIDs.EditValue) Then
            mResult = mResult & If(mResult <> "", " AND ", "") & pCodeIDKey & " IN (" & "N'" & Replace(chkcboCodeIDs.EditValue.ToString, ", ", "',N'") & "'" & ")"
        End If
        Return mResult
    End Function

#End Region

#Region "Controls Events"

    Private Sub cmdPickListCodeIDs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPickListCodeIDs.Click
        AppDevWaitingForm.Show()
        If CodeIDNeedLoad Then
            LoadComboData_CodeID()
            CodeIDNeedLoad = False
        End If
        Using mForm As New frmTOL_ItemPickList(CodeIDKey, "SELECT " & CodeIDKey & ", " & CodeIDKeyName & " as [" & CodeIDKeyDescription & "] FROM " & _CodeIDSource & If(_CodeIDSourceFilter <> "", " WHERE " & _CodeIDSourceFilter, ""), "", chkcboCodeIDs.EditValue)
            AddHandler mForm.ListItemSelected, AddressOf ProcessCodeIDListItemPicked
            mForm.ShowDialog(Me)
            mForm.Release()
        End Using
        AppDevWaitingForm.Hide()
    End Sub
    Private Sub ProcessCodeIDListItemPicked(ByVal pValue As AppRoot.ResponseListItemSelector)
        If pValue.ListItemReturn = AppRoot.ResponseListItemSelector.eListItemReturn.PickUp Then
            chkcboCodeIDs.EditValue = pValue.GetItems
            chkcboCodeIDs.RefreshEditValue()
        End If
    End Sub

    Private Sub cboCodeIDFrom_AfterUpdateWithSender(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCodeIDFrom.AfterUpdateWithSender
        HTLFW.HTLLib.HTLComFuncs.InValidRangeEditValueFrom(cboCodeIDFrom, cboCodeIDTo, cboCodeIDFrom.MyDataType)
    End Sub

    Private Sub cboCodeIDFrom_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCodeIDFrom.GotFocus
        If CodeIDNeedLoad Then
            LoadComboData_CodeID()
            CodeIDNeedLoad = False
        End If
    End Sub

    Private Sub cboCodeIDFrom_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboCodeIDFrom.QueryPopUp
        If CodeIDNeedLoad Then
            LoadComboData_CodeID()
            CodeIDNeedLoad = False
        End If
    End Sub

    Private Sub cboCodeIDTo_AfterUpdateWithSender(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCodeIDTo.AfterUpdateWithSender
        HTLFW.HTLLib.HTLComFuncs.InValidRangeEditValueTo(cboCodeIDFrom, cboCodeIDTo, cboCodeIDFrom.MyDataType)
    End Sub

    Private Sub cboCodeIDTo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCodeIDTo.GotFocus
        If CodeIDNeedLoad Then
            LoadComboData_CodeID()
            CodeIDNeedLoad = False
        End If
    End Sub

    Private Sub cboCodeIDTo_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboCodeIDTo.QueryPopUp
        If CodeIDNeedLoad Then
            LoadComboData_CodeID()
            CodeIDNeedLoad = False
        End If
    End Sub

    Private Sub chkcboCodeIDs_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkcboCodeIDs.GotFocus
        If CodeIDNeedLoad Then
            LoadComboData_CodeID()
            CodeIDNeedLoad = False
        End If
    End Sub

#End Region

End Class