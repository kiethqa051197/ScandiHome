Public Class AppVars

    Public Const gc_NoValueConfig As String = "No Value"

    Public Const gc_GridView_FilterRowHandle As Integer = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle
    Public Const gc_GridView_NewRowHandle As Integer = DevExpress.XtraGrid.GridControl.NewItemRowHandle
    Public Const gc_GridView_InvalidRowHandle As Integer = DevExpress.XtraGrid.GridControl.InvalidRowHandle

    Public Shared gv_LineMachine As HTLLineDisplay
    Public Shared gv_IsTerminalManager As Boolean = False
    Public Shared gv_IsLockedShift As Boolean = False

    'Public Shared gv_AppUserPermissions As AppUserPermissions

    Public Shared gv_MarkedObjects As String = "iSale_ztbl_MarkedObjects"
    Public Shared gv_MarkedObjectIDs As String = "iSale_ztbl_MarkedObjectIDs"
    Public Shared gv_RefDetail_Params As String = "iSale_ztbl_RefDetail_Params"
    Public Shared gv_ItemMonthlyCost As String = "iSale_ztbl_ItemMonthlyCost"
    Public Shared gv_ItemBalanceZero As String = "iSale_ztbl_ItemBalanceZero"
    Public Shared gv_TerminalItemII As String = "iSale_ztbl_TerminalItemII"

    Public Shared gv_CuaHang_TenDayDu As String = Nothing
    Public Shared gv_CuaHang_DiaChi As String = Nothing
    Public Shared gv_CuaHang_NguoiLienHe As String = Nothing
    Public Shared gv_CuaHang_DienThoai As String = Nothing

    Public Shared gv_DanhSachHangHoaFull As DataTable

    Public Enum ePageKind
        A5
        A5Ngang '= 827
        A4 ' = 827
        A4Ngang '= 1169
        A3
        A3Ngang '= 1654
    End Enum

    Public Enum eRefLocked
        None = 0
        LockedForEntry = 1
        LockedForProcess = 2
        LockedForTransfer = 4
        LockedForRelation = 8
    End Enum

    Public Enum eLoaiCTu
        NONE = 0

        PMH = 1
        NTR = 2

        PBS = 4
        PBL = 8
        QTT = 16
        XTR = 32

        NCK = 64
        NDC = 128
        XCK = 256
        XDC = 512
        XSD = 1024
        HUY = 2048

        PTT = 4096
        PCT = 8192

        SDV = 16384
        SDR = 32768

        NLR = 65536
        XLR = 131072

        PLR = 262144

        DAUVAO = 1 + 2
        DAURA = 4 + 8 + 16 + 32

        DAUVAOKHO = 1 + 2 + 64 + 128 + 65536
        DAURAKHO = 4 + 8 + 16 + 32 + 256 + 512 + 1024 + 2048 + 131072

        BANHANG = 4 + 8
        THUCHI = 4096 + 8192

        SODUCONGNO = 16384 + 32768
        CONGNO_SODUKH = 4 + 32768
        CONGNO_SODUNCC = 1 + 16384
    End Enum

    'Public Enum eLoai_THUCHI
    '    CONGNO = 1
    '    TRAHANG = 2
    '    KHAC = 4
    '    TATCA = 1 + 2 + 4
    'End Enum

    Public Enum eLoaiHangHoa
        eThuong = 1
        eLapRap = 2
        eLapRapLuuKho = 4
        eTatCa = 1 + 2 + 4
        eLuuKho = 1 + 4
    End Enum

    Public Enum eLoaiDoiTuong
        eNCC = 1
        eKH = 2
        eNCCKH = 3
    End Enum

End Class
