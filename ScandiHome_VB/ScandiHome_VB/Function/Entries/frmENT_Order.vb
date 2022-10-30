#Region "References"

Imports HTLFW
Imports HTLFW.HTLLib
Imports HTLFW.HTLLib.HTLComFuncs
Imports HTLFW.HTLLib.HTLStringFuncs
Imports HTLFW.HTLLib.HTLLayoutDefinition

Imports DBs
Imports AppRoot
Imports AppRoot.AppVars
Imports DevExpress.XtraGrid.Views.Base
Imports ScandiHome_VB.AppConfig
Imports System.Data.OleDb
Imports System.Data.Linq

#End Region

Public Class frmENT_Order

#Region "Declares"

#End Region

#Region "Structors"

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmENT_Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDateFrom.EditValue = NgayBatDau()
        txtDateTo.EditValue = NgayKetThuc()
        'Run_OnRefreshData()
    End Sub

    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        If Me.Modal Then Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Me_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        ReleaseMemory()
    End Sub

#End Region

#Region "Overrides"

    Public Overrides Sub Run_OnRefreshData()
        Try
            AppDevWaitingForm.Show()
            gcData.DataSource = AppConfigHelper.GetDataTable("SELECT * FROM dbo.SHC_view_GetAllOrder D ")
        Catch ex As Exception
            AppDevWaitingForm.Hide()
            ShowErrorStop(ex.Message)
        End Try
        AppDevWaitingForm.Hide()
        gvData.Focus()
    End Sub

#End Region

    Private Function ReadExcelFile(ByVal path As String, ByVal sheetName As String) As DataTable
        Dim dt As DataTable = New DataTable()
        Try
            Using conn As System.Data.OleDb.OleDbConnection = New System.Data.OleDb.OleDbConnection()
                Dim Import_FileName As String = path
                conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & path & ";Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1;MAXSCANROWS=0'"

                Using comm As OleDbCommand = New OleDbCommand()
                    comm.CommandText = "Select * from [" & sheetName & "$]"
                    comm.Connection = conn

                    Using da As OleDbDataAdapter = New OleDbDataAdapter()
                        da.SelectCommand = comm
                        da.Fill(dt)
                        Return dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ShowErrorStop(ex.Message)
            Return dt
        End Try
    End Function

    Private Function InitDataTable() As DataTable
        Dim tblData As New DataTable
        tblData.Release
        tblData = New DataTable
        tblData.Columns.Add("Code", GetType(String))
        tblData.Columns.Add("SKU", GetType(String))
        tblData.Columns.Add("Quantiy", GetType(System.Double))
        tblData.Columns.Add("Phone", GetType(String))
        tblData.Columns.Add("CustomerName", GetType(String))
        tblData.Columns.Add("Address", GetType(String))
        tblData.Columns.Add("Region", GetType(String))
        tblData.Columns.Add("OrderStatus", GetType(String))
        tblData.Columns.Add("PaymentNote", GetType(String))
        tblData.Columns.Add("Description", GetType(String))
        tblData.Columns.Add("CODAmount", GetType(System.Double))
        tblData.Columns.Add("Source", GetType(String))
        Return tblData
    End Function

    Private Sub Do_ImportExcel(pType As Integer)
        Try
            Dim mFileName As String = ""
            Me.openFileDlg.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm|All File|*.*"
            Dim mDialogResult As DialogResult = openFileDlg.ShowDialog()

            Dim tblData_Detail = InitDataTable()
            If mDialogResult = DialogResult.OK Then
                mFileName = openFileDlg.FileName

                Dim mDatatable_FromExcel = ReadExcelFile(mFileName, "Sheet1") 'Lấy path file để get Datatable từ excel
                If mDatatable_FromExcel IsNot Nothing Then
                    For Each mData As DataRow In mDatatable_FromExcel.Rows
                        Dim Code As String = String.Empty
                        Dim SKU As String = String.Empty
                        Dim Quantiy As System.Double = 1
                        Dim Phone As String = String.Empty
                        Dim CustomerName As String = String.Empty
                        Dim Address As String = String.Empty
                        Dim Region As String = String.Empty
                        Dim OrderStatus As String = "i"
                        Dim PaymentNote As String = String.Empty
                        Dim Description As String = String.Empty
                        Dim CODAmount As System.Double = 0

                        Select Case pType
                            Case 1
                                Code = mData.Item("orderNumber").ToString()
                                SKU = mData.Item("sellerSku").ToString()
                                Phone = RightString(If(IsNoValue(mData.Item("shippingPhone").ToString()), mData.Item("billingPhone").ToString(), mData.Item("shippingPhone").ToString()), 10)
                                CustomerName = mData.Item("shippingName").ToString()
                                Address = mData.Item("shippingAddress").ToString() & ", " & mData.Item("shippingAddress5").ToString() & ", " & mData.Item("shippingAddress4").ToString()
                                Region = If(String.Compare(mData.Item("shippingAddress3").ToString(), "Hồ Chí Minh", True) = 0, "HCM", mData.Item("shippingAddress3").ToString())
                                PaymentNote = If(String.Compare(mData.Item("payMethod").ToString(), "COD", True) = 0, "Thu tiền khi nhận hàng", "Đã thanh toán")
                                Description = If(mData.Item("taxCode").ToString().Equals(""), "", "Xuất hóa đơn VAT, " & mData.Item("taxCode").ToString())
                                CODAmount = Double.Parse(If(mData.Item("paidPrice").ToString().Equals(""), "0", mData.Item("paidPrice").ToString()))
                            Case 2
                                Code = mData.Item("orderNumber").ToString()
                                SKU = mData.Item("sellerSku").ToString()
                                Phone = RightString(If(IsNoValue(mData.Item("shippingPhone").ToString()), mData.Item("billingPhone").ToString(), mData.Item("shippingPhone").ToString()), 10)
                                CustomerName = mData.Item("shippingName").ToString()
                                Address = mData.Item("shippingAddress").ToString() & ", " & mData.Item("shippingAddress5").ToString() & ", " & mData.Item("shippingAddress4").ToString()
                                Region = If(String.Compare(mData.Item("shippingAddress3").ToString(), "Hồ Chí Minh", True) = 0, "HCM", mData.Item("shippingAddress3").ToString())
                                PaymentNote = If(String.Compare(mData.Item("payMethod").ToString(), "COD", True) = 0, "Thu tiền khi nhận hàng", "Đã thanh toán")
                                Description = If(mData.Item("taxCode").ToString().Equals(""), "", "Xuất hóa đơn VAT, " & mData.Item("taxCode").ToString())
                                CODAmount = Double.Parse(If(mData.Item("paidPrice").ToString().Equals(""), "0", mData.Item("paidPrice").ToString()))
                            Case 3

                            Case 4

                        End Select
                    Next
                Else
                    ShowErrorStop("Không có dữ liệu!")
                End If
            End If
        Catch ex As Exception
            ShowErrorStop(ex.Message)
        End Try
    End Sub

    Public Sub Do_ImportExcel_Lazada()
        Try
            Dim mFileName As String = ""
            Me.openFileDlg.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm|All File|*.*"
            Dim mDialogResult As DialogResult = openFileDlg.ShowDialog()

            Dim tblData_Detail = InitDataTable()

            If mDialogResult = DialogResult.OK Then
                mFileName = openFileDlg.FileName

                Dim mDT_Excel = ReadExcelFile(mFileName, "Sheet1")

                If mDT_Excel IsNot Nothing Then
                    For Each mData As DataRow In mDT_Excel.Rows
                        Dim paidPrice = If(mData.Item("paidPrice").ToString().Equals(""), "0", mData.Item("paidPrice").ToString())

                        tblData_Detail.Rows.Add(mData.Item("orderNumber").ToString() _
                                                , mData.Item("sellerSku").ToString() _
                                                , 1 _
                                                , RightString(If(IsNoValue(mData.Item("shippingPhone").ToString()), mData.Item("billingPhone").ToString(), mData.Item("shippingPhone").ToString()), 10) _
                                                , mData.Item("shippingName").ToString() _
                                                , mData.Item("shippingAddress").ToString() & ", " & mData.Item("shippingAddress5").ToString() & ", " & mData.Item("shippingAddress4").ToString() _
                                                , If(String.Compare(mData.Item("shippingAddress3").ToString(), "Hồ Chí Minh", True) = 0, "HCM", mData.Item("shippingAddress3").ToString()) _
                                                , "pending" _
                                                , If(String.Compare(mData.Item("payMethod").ToString(), "COD", True) = 0, "Thu tiền khi nhận hàng", "Đã thanh toán") _
                                                , If(mData.Item("taxCode").ToString().Equals(""), "", "Xuất hóa đơn VAT, " & mData.Item("taxCode").ToString()) _
                                                , Double.Parse(paidPrice.ToString()) _
                                                , "Lazada")
                    Next

                    Dim mDataHeader = (
                                        From pp In tblData_Detail.Rows.OfType(Of DataRow)()
                                        Group By
                                            Code = Nz(pp.Item("Code"), Nothing) _
                                            , Phone = Nz(pp.Item("Phone"), Nothing)
                                        Into mGroup = Group
                                        Select New With
                                        {
                                            Code _
                                            , Phone
                                        }
                                      ).ToList()

                    Dim mDataGroups = (
                                        From pp In tblData_Detail.Rows.OfType(Of DataRow)()
                                        Group By
                                            Code = Nz(pp.Item("Code"), Nothing) _
                                            , SKU = Nz(pp.Item("SKU"), Nothing)
                                        Into mGroup = Group
                                        Select New With
                                        {
                                            Code _
                                            , SKU _
                                            , .Quantiy = mGroup.Count(Function(p) p.Item("Quantiy"))
                                        }
                                      ).ToList()

                    For Each mRow In mDataHeader
                        Dim mDBContext = DBContextCreateNew(AppConfigHelper.GetSQLConnection())
                        mDBContext.TransactionStart()

                        Dim mNewObject = New Order

                        Dim mOrderCode = String.Empty
                        Dim mNgayGioHeThong = NgayGioHeThong().ToString("yyyyMMdd")

                        If IsNoValue(AppConfigHelper.DMax("OrderCode", "dbo.[Order]")) OrElse Not AppConfigHelper.DMax("OrderCode", "dbo.[Order]").ToString().Contains(mNgayGioHeThong) Then
                            mOrderCode = "DDH." & NgayGioHeThong().ToString("yyyyMMdd") & "0001"
                        Else
                            mOrderCode = "DDH." & CType(RightString(AppConfigHelper.DMax("OrderCode", "dbo.[Order]"), 12), System.Double) + 1
                        End If

                        With mNewObject
                            .OrderCode = mOrderCode
                            .Phone = mRow.Phone
                            .Description = Nothing
                            .CreatedBy = "admin"
                            .Created = NgayGioHeThong()

                            Dim mNewObjectDetails As New List(Of OrderDetail)
                            Dim i As Integer = 0
                            Dim mOrderCodeItem = String.Empty
                            For Each mDataGroup In mDataGroups.Where(Function(pp) pp.Code = mRow.Code).ToList()
                                i += 1

                                If IsNoValue(mOrderCodeItem) AndAlso (IsNoValue(AppConfigHelper.DMax("OrderCodeItem", "dbo.[OrderDetail]")) OrElse Not AppConfigHelper.DMax("OrderCodeItem", "dbo.[OrderDetail]").ToString().Contains(mNgayGioHeThong)) Then
                                    mOrderCodeItem = NgayGioHeThong().ToString("yyyyMMdd") & "0001"
                                ElseIf IsNoValue(mOrderCodeItem) Then
                                    mOrderCodeItem = CType(AppConfigHelper.DMax("OrderCodeItem", "dbo.[OrderDetail]"), System.Double) + 1
                                Else
                                    mOrderCodeItem = CType(mOrderCodeItem, System.Double) + 1
                                End If

                                Dim DetailObject = (
                                                        From pp In tblData_Detail.Rows.OfType(Of DataRow)()
                                                        Where
                                                            Nz(pp.Item("Code"), Nothing) = mDataGroup.Code And Nz(pp.Item("SKU"), Nothing) = mDataGroup.SKU
                                                        Select New With
                                                        {
                                                            mDataGroup.Code _
                                                            , mDataGroup.Quantiy _
                                                            , .CustomerName = pp.Item("CustomerName") _
                                                            , .Address = pp.Item("Address") _
                                                            , .Region = pp.Item("Region") _
                                                            , .OrderStatus = pp.Item("OrderStatus") _
                                                            , .PaymentNote = Nz(pp.Item("PaymentNote"), Nothing) _
                                                            , .Description = Nz(pp.Item("Description"), Nothing) _
                                                            , .CODAmount = pp.Item("CODAmount") _
                                                            , .Source = pp.Item("Source")
                                                        }
                                                    ).ToList

                                Dim mNewObjectDetail As New OrderDetail
                                With mNewObjectDetail
                                    .OrderCode = mNewObject.OrderCode
                                    .OrderCodeItem = mOrderCodeItem
                                    .OrderType = "Bán lẻ"
                                    .Customer = DetailObject(0).CustomerName
                                    .Phone = mRow.Phone
                                    .Address = Nz(DetailObject(0).Address, Nothing)
                                    .Region = Nz(DetailObject(0).Region, Nothing)
                                    .DeliveryDate = Nothing
                                    .Manufacturing = Nothing
                                    .Manufacturer = Nothing
                                    .Description = Nz(DetailObject(0).Description, Nothing)
                                    .DeliveryTime = Nothing
                                    .DeliveryMethod = Nothing
                                    .Staff = Nothing
                                    .PaymentNote = Nz(DetailObject(0).PaymentNote, Nothing)
                                    .SKU = Nz(mDataGroup.SKU, Nothing)
                                    .Price = Nz(DetailObject(0).CODAmount, 0.0)
                                    .Quantity = Nz(DetailObject(0).Quantiy, 0.0)
                                    .CODAmountPaid = Nz(If(String.Compare(DetailObject(0).PaymentNote, "Thu tiền khi nhận hàng", True) = 0, 0, .Price), 0.0)
                                    .CODAmount = (.Price * .Quantity) - .CODAmountPaid
                                    .ReferenceOrder = Nz(DetailObject(0).Code, Nothing)
                                    .ShippingFee = 0
                                    .Confirm = Nothing
                                    .Design = Nothing
                                    .Materials = Nothing
                                    .Production = Nothing
                                    .Delivery = Nothing
                                    .Payment = If(.CODAmount = 0, "d", Nothing)
                                    .Source = DetailObject(0).Source
                                End With
                                mNewObjectDetails.Add(mNewObjectDetail)
                            Next
                            Try
                                mDBContext.Orders.InsertOnSubmit(mNewObject)
                                mDBContext.OrderDetails.InsertAllOnSubmit(mNewObjectDetails)
                                mDBContext.SubmitChanges()

                                mDBContext.TransactionCommit()
                            Catch ex As Exception
                                mDBContext.TransactionRollback()
                                mDBContext.Release()
                                mNewObject.Release()
                                mNewObjectDetails.Release()
                            End Try
                        End With
                    Next
                End If
            Else
                Run_OnRefreshData()
            End If
            Run_OnRefreshData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Run_OnRefreshData()
        End Try
        Return
    End Sub

    Public Sub Do_ImportExcel2()
        Try
            Dim mFileName As String = ""
            Me.openFileDlg.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm|All File|*.*"
            Dim mDialogResult As DialogResult = openFileDlg.ShowDialog()

            Dim tblData_Detail = InitDataTable()

            If mDialogResult = DialogResult.OK Then
                mFileName = openFileDlg.FileName

                Dim mDT_Excel = ReadExcelFile(mFileName, "Sheet1")

                If mDT_Excel IsNot Nothing Then
                    For Each mData As DataRow In mDT_Excel.Rows
                        Dim paidPrice = If(mData.Item("Đơn giá").ToString().Equals(""), "0", mData.Item("Đơn giá").ToString())
                        Dim mRegion = If(IsNoValue(mData.Item("Địa chỉ").ToString()), "", mData.Item("Địa chỉ").ToString().Substring(mData.Item("Địa chỉ").ToString().LastIndexOf("-") + 2))

                        tblData_Detail.Rows.Add(mData.Item("Mã đơn hàng").ToString() _
                                                , mData.Item("Mã sản phẩm").ToString() _
                                                , CType(mData.Item("SL bán").ToString(), Double) _
                                                , "0" & mData.Item("Số điện thoại").ToString() _
                                                , mData.Item("Tên khách hàng").ToString() _
                                                , mData.Item("Địa chỉ").ToString() _
                                                , If(String.Compare(mRegion, "Hồ Chí Minh", True) = 0, "HCM", mRegion) _
                                                , "pending" _
                                                , If(String.Compare(mData.Item("Phương thức thanh toán").ToString(), "COD", True) = 0, "Thu tiền khi nhận hàng", "Đã thanh toán") _
                                                , If(mData.Item("Xuất VAT").ToString().Equals("Có"), "", "Xuất hóa đơn VAT, " & mData.Item("Xuất VAT").ToString()) _
                                                , Double.Parse(paidPrice.ToString()) _
                                                , "Tiki")
                    Next

                    Dim mDataHeader = (
                                        From pp In tblData_Detail.Rows.OfType(Of DataRow)()
                                        Group By
                                            Code = Nz(pp.Item("Code"), Nothing) _
                                            , Phone = Nz(pp.Item("Phone"), Nothing)
                                        Into mGroup = Group
                                        Select New With
                                        {
                                            Code _
                                            , Phone
                                        }
                                      ).ToList()

                    For Each mRow In mDataHeader
                        Dim mDBContext = DBContextCreateNew(AppConfigHelper.GetSQLConnection())
                        mDBContext.TransactionStart()

                        Dim mNewObject = New Order

                        Dim mOrderCode = String.Empty
                        Dim mNgayGioHeThong = NgayGioHeThong().ToString("yyyyMMdd")

                        If IsNoValue(AppConfigHelper.DMax("OrderCode", "dbo.[Order]")) OrElse Not AppConfigHelper.DMax("OrderCode", "dbo.[Order]").ToString().Contains(mNgayGioHeThong) Then
                            mOrderCode = "DDH." & NgayGioHeThong().ToString("yyyyMMdd") & "0001"
                        Else
                            mOrderCode = "DDH." & CType(RightString(AppConfigHelper.DMax("OrderCode", "dbo.[Order]"), 12), System.Double) + 1
                        End If

                        With mNewObject
                            .OrderCode = mOrderCode
                            .Phone = mRow.Phone
                            .Description = Nothing
                            .CreatedBy = "admin"
                            .Created = NgayGioHeThong()

                            Dim DetailObject = (
                                                    From pp In tblData_Detail.Rows.OfType(Of DataRow)()
                                                    Where
                                                        Nz(pp.Item("Code"), Nothing) = mRow.Code
                                                    Select New With
                                                    {
                                                        mRow.Code _
                                                        , .SKU = pp.Item("SKU") _
                                                        , .Quantiy = pp.Item("Quantiy") _
                                                        , .CustomerName = pp.Item("CustomerName") _
                                                        , .Address = pp.Item("Address") _
                                                        , .Region = pp.Item("Region") _
                                                        , .OrderStatus = pp.Item("OrderStatus") _
                                                        , .PaymentNote = Nz(pp.Item("PaymentNote"), Nothing) _
                                                        , .Description = Nz(pp.Item("Description"), Nothing) _
                                                        , .CODAmount = pp.Item("CODAmount") _
                                                        , .Source = pp.Item("Source")
                                                    }
                                                ).ToList

                            Dim mNewObjectDetails As New List(Of OrderDetail)
                            Dim i As Integer = 0
                            Dim mOrderCodeItem = String.Empty

                            For Each mDataDetail In DetailObject
                                i += 1

                                If IsNoValue(mOrderCodeItem) AndAlso (IsNoValue(AppConfigHelper.DMax("OrderCodeItem", "dbo.[OrderDetail]")) OrElse Not AppConfigHelper.DMax("OrderCodeItem", "dbo.[OrderDetail]").ToString().Contains(mNgayGioHeThong)) Then
                                    mOrderCodeItem = NgayGioHeThong().ToString("yyyyMMdd") & "0001"
                                ElseIf IsNoValue(mOrderCodeItem) Then
                                    mOrderCodeItem = CType(AppConfigHelper.DMax("OrderCodeItem", "dbo.[OrderDetail]"), System.Double) + 1
                                Else
                                    mOrderCodeItem = CType(mOrderCodeItem, System.Double) + 1
                                End If
                            Next

                            Dim mNewObjectDetail As New OrderDetail
                            With mNewObjectDetail
                                .OrderCode = mNewObject.OrderCode
                                .OrderCodeItem = mOrderCodeItem
                                .OrderType = "Bán lẻ"
                                .Customer = DetailObject(0).CustomerName
                                .Phone = mRow.Phone
                                .Address = Nz(DetailObject(0).Address, Nothing)
                                .Region = Nz(DetailObject(0).Region, Nothing)
                                .DeliveryDate = Nothing
                                .Manufacturing = Nothing
                                .Manufacturer = Nothing
                                .Description = Nz(DetailObject(0).Description, Nothing)
                                .DeliveryTime = Nothing
                                .DeliveryMethod = Nothing
                                .Staff = Nothing
                                .PaymentNote = Nz(DetailObject(0).PaymentNote, Nothing)
                                .SKU = Nz(DetailObject(0).SKU, Nothing)
                                .Price = Nz(DetailObject(0).CODAmount, 0.0)
                                .Quantity = Nz(DetailObject(0).Quantiy, 0.0)
                                .CODAmountPaid = Nz(If(String.Compare(DetailObject(0).PaymentNote, "Thu tiền khi nhận hàng", True) = 0, 0, .Price), 0.0)
                                .CODAmount = (.Price * .Quantity) - .CODAmountPaid
                                .ReferenceOrder = Nz(DetailObject(0).Code, Nothing)
                                .ShippingFee = 0
                                .Confirm = Nothing
                                .Design = Nothing
                                .Materials = Nothing
                                .Production = Nothing
                                .Delivery = Nothing
                                .Payment = If(.CODAmount = 0, "d", Nothing)
                                .Source = DetailObject(0).Source
                            End With
                            mNewObjectDetails.Add(mNewObjectDetail)

                            Try
                                mDBContext.Orders.InsertOnSubmit(mNewObject)
                                mDBContext.OrderDetails.InsertAllOnSubmit(mNewObjectDetails)
                                mDBContext.SubmitChanges()

                                mDBContext.TransactionCommit()
                            Catch ex As Exception
                                mDBContext.TransactionRollback()
                                mDBContext.Release()
                                mNewObject.Release()
                                mNewObjectDetails.Release()
                            End Try
                        End With
                    Next
                End If
            Else
                Run_OnRefreshData()
            End If
            Run_OnRefreshData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Run_OnRefreshData()
        End Try
        Return
    End Sub

    Public Sub Do_ImportExcel3()
        Try
            Dim mFileName As String = ""
            Me.openFileDlg.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm|All File|*.*"
            Dim mDialogResult As DialogResult = openFileDlg.ShowDialog()

            Dim tblData_Detail = InitDataTable()

            If mDialogResult = DialogResult.OK Then
                mFileName = openFileDlg.FileName

                Dim mDT_Excel = ReadExcelFile(mFileName, "Sheet1")

                If mDT_Excel IsNot Nothing Then
                    For Each mData As DataRow In mDT_Excel.Rows
                        Dim paidPrice = If(mData.Item("Đơn giá").ToString().Equals(""), "0", mData.Item("Đơn giá").ToString())

                        Dim mRegion = If(IsNoValue(mData.Item("Địa chỉ KH").ToString()), "", mData.Item("Địa chỉ KH").ToString().Substring(mData.Item("Địa chỉ KH").ToString().LastIndexOf(",") + 2))

                        tblData_Detail.Rows.Add(mData.Item("Mã ĐH").ToString() _
                                                , mData.Item("Mã hàng").ToString() _
                                                , 1 _
                                                , "0" & RightString(mData.Item("Điện thoại KH").ToString(), 9) _
                                                , mData.Item("Tên khách hàng").ToString() _
                                                , mData.Item("Địa chỉ KH").ToString() _
                                                , If(String.Compare(mRegion, "TP Hồ Chí Minh", True) = 0, "HCM", mRegion) _
                                                , "pending" _
                                                , If(String.Compare(mData.Item("Trạng thái thanh toán").ToString(), "Chưa thanh toán", True) = 0, "Thu tiền khi nhận hàng", "Đã thanh toán") _
                                                , Nothing _
                                                , Double.Parse(paidPrice.ToString()) _
                                                , "Sapo")

                    Next

                    Dim mDataHeader = (
                                        From pp In tblData_Detail.Rows.OfType(Of DataRow)()
                                        Group By
                                            Code = Nz(pp.Item("Code"), Nothing) _
                                            , Phone = Nz(pp.Item("Phone"), Nothing)
                                        Into mGroup = Group
                                        Select New With
                                        {
                                            Code _
                                            , Phone
                                        }
                                      ).ToList()

                    Dim mDataGroups = (
                                        From pp In tblData_Detail.Rows.OfType(Of DataRow)()
                                        Group By
                                            Code = Nz(pp.Item("Code"), Nothing) _
                                            , SKU = Nz(pp.Item("SKU"), Nothing)
                                        Into mGroup = Group
                                        Select New With
                                        {
                                            Code _
                                            , SKU _
                                            , .Quantiy = mGroup.Count(Function(p) p.Item("Quantiy"))
                                        }
                                      ).ToList()

                    For Each mRow In mDataHeader
                        Dim mDBContext = DBContextCreateNew(AppConfigHelper.GetSQLConnection())
                        mDBContext.TransactionStart()

                        Dim mNewObject = New Order

                        Dim mOrderCode = String.Empty
                        Dim mNgayGioHeThong = NgayGioHeThong().ToString("yyyyMMdd")

                        If IsNoValue(AppConfigHelper.DMax("OrderCode", "dbo.[Order]")) OrElse Not AppConfigHelper.DMax("OrderCode", "dbo.[Order]").ToString().Contains(mNgayGioHeThong) Then
                            mOrderCode = "DDH." & NgayGioHeThong().ToString("yyyyMMdd") & "0001"
                        Else
                            mOrderCode = "DDH." & CType(RightString(AppConfigHelper.DMax("OrderCode", "dbo.[Order]"), 12), System.Double) + 1
                        End If

                        With mNewObject
                            .OrderCode = mOrderCode
                            .Phone = mRow.Phone
                            .Description = Nothing
                            .CreatedBy = "admin"
                            .Created = NgayGioHeThong()

                            Dim mNewObjectDetails As New List(Of OrderDetail)
                            Dim i As Integer = 0
                            Dim mOrderCodeItem = String.Empty
                            For Each mDataGroup In mDataGroups.Where(Function(pp) pp.Code = mRow.Code).ToList()
                                i += 1

                                If IsNoValue(mOrderCodeItem) AndAlso (IsNoValue(AppConfigHelper.DMax("OrderCodeItem", "dbo.[OrderDetail]")) OrElse Not AppConfigHelper.DMax("OrderCodeItem", "dbo.[OrderDetail]").ToString().Contains(mNgayGioHeThong)) Then
                                    mOrderCodeItem = NgayGioHeThong().ToString("yyyyMMdd") & "0001"
                                ElseIf IsNoValue(mOrderCodeItem) Then
                                    mOrderCodeItem = CType(AppConfigHelper.DMax("OrderCodeItem", "dbo.[OrderDetail]"), System.Double) + 1
                                Else
                                    mOrderCodeItem = CType(mOrderCodeItem, System.Double) + 1
                                End If

                                Dim DetailObject = (
                                                        From pp In tblData_Detail.Rows.OfType(Of DataRow)()
                                                        Where
                                                            Nz(pp.Item("Code"), Nothing) = mDataGroup.Code And Nz(pp.Item("SKU"), Nothing) = mDataGroup.SKU
                                                        Select New With
                                                        {
                                                            mDataGroup.Code _
                                                            , mDataGroup.Quantiy _
                                                            , .CustomerName = pp.Item("CustomerName") _
                                                            , .Address = pp.Item("Address") _
                                                            , .Region = pp.Item("Region") _
                                                            , .OrderStatus = pp.Item("OrderStatus") _
                                                            , .PaymentNote = Nz(pp.Item("PaymentNote"), Nothing) _
                                                            , .Description = Nz(pp.Item("Description"), Nothing) _
                                                            , .CODAmount = pp.Item("CODAmount") _
                                                            , .Source = pp.Item("Source")
                                                        }
                                                    ).ToList

                                Dim mNewObjectDetail As New OrderDetail
                                With mNewObjectDetail
                                    .OrderCode = mNewObject.OrderCode
                                    .OrderCodeItem = mOrderCodeItem
                                    .OrderType = "Bán lẻ"
                                    .Customer = DetailObject(0).CustomerName
                                    .Phone = mRow.Phone
                                    .Address = Nz(DetailObject(0).Address, Nothing)
                                    .Region = Nz(DetailObject(0).Region, Nothing)
                                    .DeliveryDate = Nothing
                                    .Manufacturing = Nothing
                                    .Manufacturer = Nothing
                                    .Description = Nz(DetailObject(0).Description, Nothing)
                                    .DeliveryTime = Nothing
                                    .DeliveryMethod = Nothing
                                    .Staff = Nothing
                                    .PaymentNote = Nz(DetailObject(0).PaymentNote, Nothing)
                                    .SKU = Nz(mDataGroup.SKU, Nothing)
                                    .Price = Nz(DetailObject(0).CODAmount, 0.0)
                                    .Quantity = Nz(DetailObject(0).Quantiy, 0.0)
                                    .CODAmountPaid = Nz(If(String.Compare(DetailObject(0).PaymentNote, "Thu tiền khi nhận hàng", True) = 0, 0, .Price), 0.0)
                                    .CODAmount = (.Price * .Quantity) - .CODAmountPaid
                                    .ReferenceOrder = Nz(DetailObject(0).Code, Nothing)
                                    .ShippingFee = 0
                                    .Confirm = Nothing
                                    .Design = Nothing
                                    .Materials = Nothing
                                    .Production = Nothing
                                    .Delivery = Nothing
                                    .Payment = If(.CODAmount = 0, "d", Nothing)
                                    .Source = DetailObject(0).Source
                                End With
                                mNewObjectDetails.Add(mNewObjectDetail)
                            Next
                            Try
                                mDBContext.Orders.InsertOnSubmit(mNewObject)
                                mDBContext.OrderDetails.InsertAllOnSubmit(mNewObjectDetails)
                                mDBContext.SubmitChanges()

                                mDBContext.TransactionCommit()
                            Catch ex As Exception
                                mDBContext.TransactionRollback()
                                mDBContext.Release()
                                mNewObject.Release()
                                mNewObjectDetails.Release()
                            End Try
                        End With
                    Next
                End If
            Else
                Run_OnRefreshData()
            End If
            Run_OnRefreshData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Run_OnRefreshData()
        End Try
        Return
    End Sub

    Public Sub Do_ImportExcel4()
        Try
            Dim mFileName As String = ""
            Me.openFileDlg.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm|All File|*.*"
            Dim mDialogResult As DialogResult = openFileDlg.ShowDialog()

            Dim tblData_Detail = InitDataTable()

            If mDialogResult = DialogResult.OK Then
                mFileName = openFileDlg.FileName

                Dim mDT_Excel = ReadExcelFile(mFileName, "Sheet1")

                If mDT_Excel IsNot Nothing Then
                    For Each mData As DataRow In mDT_Excel.Rows
                        Dim price_after_discount = CType(mData.Item("Giá ưu đãi").ToString(), Double) + CType(mData.Item("Được Shopee trợ giá").ToString(), Double)
                        Dim voucher_value = CType(mData.Item("Tổng giá bán (sản phẩm)").ToString(), Double) _
                                                            /
                                                            (CType(mData.Item("Tổng giá trị đơn hàng (VND)").ToString(), Double) _
                                                             + CType(mData.Item("Mã giảm giá của Shop").ToString(), Double) _
                                                             + CType(mData.Item("Hoàn Xu").ToString(), Double) _
                                                             + CType(mData.Item("Mã giảm giá của Shopee").ToString(), Double)) _
                                                             *
                                                             (CType(mData.Item("Mã giảm giá của Shop").ToString(), Double) _
                                                             + CType(mData.Item("Hoàn Xu").ToString(), Double)) _
                                                             /
                                                             CType(mData.Item("Số lượng").ToString(), Double)

                        Dim price_after_discount_voucher = price_after_discount - voucher_value

                        tblData_Detail.Rows.Add(mData.Item("Mã đơn hàng").ToString() _
                                                , mData.Item("SKU phân loại hàng").ToString() _
                                                , 1 _
                                                , "0" & RightString(mData.Item("Số điện thoại").ToString(), 9) _
                                                , mData.Item("Tên Người nhận").ToString() _
                                                , mData.Item("Địa chỉ nhận hàng").ToString() _
                                                , If(String.Compare(mData.Item("Tỉnh/Thành phố").ToString(), "TP. Hồ Chí Minh", True) = 0, "HCM", mData.Item("Tỉnh/Thành phố").ToString()) _
                                                , "pending" _
                                                , Nothing _
                                                , mData.Item("Nhận xét từ Người mua").ToString() _
                                                , Double.Parse(price_after_discount_voucher.ToString()) _
                                                , "Shoppe")

                    Next

                    Dim mDataHeader = (
                                        From pp In tblData_Detail.Rows.OfType(Of DataRow)()
                                        Group By
                                            Code = Nz(pp.Item("Code"), Nothing) _
                                            , Phone = Nz(pp.Item("Phone"), Nothing)
                                        Into mGroup = Group
                                        Select New With
                                        {
                                            Code _
                                            , Phone
                                        }
                                      ).ToList()

                    Dim mDataGroups = (
                                        From pp In tblData_Detail.Rows.OfType(Of DataRow)()
                                        Group By
                                            Code = Nz(pp.Item("Code"), Nothing) _
                                            , SKU = Nz(pp.Item("SKU"), Nothing)
                                        Into mGroup = Group
                                        Select New With
                                        {
                                            Code _
                                            , SKU _
                                            , .Quantiy = mGroup.Count(Function(p) p.Item("Quantiy"))
                                        }
                                      ).ToList()

                    For Each mRow In mDataHeader
                        Dim mDBContext = DBContextCreateNew(AppConfigHelper.GetSQLConnection())
                        mDBContext.TransactionStart()

                        Dim mNewObject = New Order

                        Dim mOrderCode = String.Empty
                        Dim mNgayGioHeThong = NgayGioHeThong().ToString("yyyyMMdd")

                        If IsNoValue(AppConfigHelper.DMax("OrderCode", "dbo.[Order]")) OrElse Not AppConfigHelper.DMax("OrderCode", "dbo.[Order]").ToString().Contains(mNgayGioHeThong) Then
                            mOrderCode = "DDH." & NgayGioHeThong().ToString("yyyyMMdd") & "0001"
                        Else
                            mOrderCode = "DDH." & CType(RightString(AppConfigHelper.DMax("OrderCode", "dbo.[Order]"), 12), System.Double) + 1
                        End If

                        With mNewObject
                            .OrderCode = mOrderCode
                            .Phone = mRow.Phone
                            .Description = Nothing
                            .CreatedBy = "admin"
                            .Created = NgayGioHeThong()

                            Dim mNewObjectDetails As New List(Of OrderDetail)
                            Dim i As Integer = 0
                            Dim mOrderCodeItem = String.Empty
                            For Each mDataGroup In mDataGroups.Where(Function(pp) pp.Code = mRow.Code).ToList()
                                i += 1

                                If IsNoValue(mOrderCodeItem) AndAlso (IsNoValue(AppConfigHelper.DMax("OrderCodeItem", "dbo.[OrderDetail]")) OrElse Not AppConfigHelper.DMax("OrderCodeItem", "dbo.[OrderDetail]").ToString().Contains(mNgayGioHeThong)) Then
                                    mOrderCodeItem = NgayGioHeThong().ToString("yyyyMMdd") & "0001"
                                ElseIf IsNoValue(mOrderCodeItem) Then
                                    mOrderCodeItem = CType(AppConfigHelper.DMax("OrderCodeItem", "dbo.[OrderDetail]"), System.Double) + 1
                                Else
                                    mOrderCodeItem = CType(mOrderCodeItem, System.Double) + 1
                                End If

                                Dim DetailObject = (
                                                        From pp In tblData_Detail.Rows.OfType(Of DataRow)()
                                                        Where
                                                            Nz(pp.Item("Code"), Nothing) = mDataGroup.Code And Nz(pp.Item("SKU"), Nothing) = mDataGroup.SKU
                                                        Select New With
                                                        {
                                                            mDataGroup.Code _
                                                            , mDataGroup.Quantiy _
                                                            , .CustomerName = pp.Item("CustomerName") _
                                                            , .Address = pp.Item("Address") _
                                                            , .Region = pp.Item("Region") _
                                                            , .OrderStatus = pp.Item("OrderStatus") _
                                                            , .PaymentNote = Nz(pp.Item("PaymentNote"), Nothing) _
                                                            , .Description = Nz(pp.Item("Description"), Nothing) _
                                                            , .CODAmount = pp.Item("CODAmount") _
                                                            , .Source = pp.Item("Source")
                                                        }
                                                    ).ToList

                                Dim mNewObjectDetail As New OrderDetail
                                With mNewObjectDetail
                                    .OrderCode = mNewObject.OrderCode
                                    .OrderCodeItem = mOrderCodeItem
                                    .OrderType = "Bán lẻ"
                                    .Customer = DetailObject(0).CustomerName
                                    .Phone = mRow.Phone
                                    .Address = Nz(DetailObject(0).Address, Nothing)
                                    .Region = Nz(DetailObject(0).Region, Nothing)
                                    .DeliveryDate = Nothing
                                    .Manufacturing = Nothing
                                    .Manufacturer = Nothing
                                    .Description = Nz(DetailObject(0).Description, Nothing)
                                    .DeliveryTime = Nothing
                                    .DeliveryMethod = Nothing
                                    .Staff = Nothing
                                    .PaymentNote = Nz(DetailObject(0).PaymentNote, Nothing)
                                    .SKU = Nz(mDataGroup.SKU, Nothing)
                                    .Price = Nz(DetailObject(0).CODAmount, 0.0)
                                    .Quantity = Nz(DetailObject(0).Quantiy, 0.0)
                                    .CODAmountPaid = Nz(If(String.Compare(DetailObject(0).PaymentNote, "Thu tiền khi nhận hàng", True) = 0, 0, .Price), 0.0)
                                    .CODAmount = (.Price * .Quantity) - .CODAmountPaid
                                    .ReferenceOrder = Nz(DetailObject(0).Code, Nothing)
                                    .ShippingFee = 0
                                    .Confirm = Nothing
                                    .Design = Nothing
                                    .Materials = Nothing
                                    .Production = Nothing
                                    .Delivery = Nothing
                                    .Payment = If(.CODAmount = 0, "d", Nothing)
                                    .Source = DetailObject(0).Source
                                End With
                                mNewObjectDetails.Add(mNewObjectDetail)
                            Next
                            Try
                                mDBContext.Orders.InsertOnSubmit(mNewObject)
                                mDBContext.OrderDetails.InsertAllOnSubmit(mNewObjectDetails)
                                mDBContext.SubmitChanges()

                                mDBContext.TransactionCommit()
                            Catch ex As Exception
                                mDBContext.TransactionRollback()
                                mDBContext.Release()
                                mNewObject.Release()
                                mNewObjectDetails.Release()
                            End Try
                        End With
                    Next
                End If
            Else
                Run_OnRefreshData()
            End If
            Run_OnRefreshData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Run_OnRefreshData()
        End Try
        Return
    End Sub

    Private Sub cmdRefresh_Click_1(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        Run_OnRefreshData()
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click

    End Sub

End Class