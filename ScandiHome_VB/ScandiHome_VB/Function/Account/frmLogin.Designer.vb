<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits AppRoot.frmBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem1 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Me.lblUserName = New HTLFW.UCLabel()
        Me.txtUserName = New HTLFW.UCTextEdit()
        Me.lblPass = New HTLFW.UCLabel()
        Me.txtPass = New HTLFW.UCTextEdit()
        Me.chk_Remember = New HTLFW.CheckBox()
        Me.btnCancel = New HTLFW.UCSimpleButton()
        Me.btnLogin = New HTLFW.UCSimpleButton()
        CType(Me.DxError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_Remember.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MyImageCollection
        '
        Me.MyImageCollection.ImageStream = CType(resources.GetObject("MyImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.MyImageCollection.Images.SetKeyName(0, "About_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(1, "Add_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(2, "AddColumn_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(3, "AddFile_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(4, "AddItem_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(5, "AddNewDataSource_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(6, "AddTable_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(7, "Apply_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(8, "ArrowDown_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(9, "ArrowDownD_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(10, "ArrowLeft_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(11, "ArrowLeftD_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(12, "ArrowRight_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(13, "ArrowRightD_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(14, "ArrowUp_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(15, "ArrowUpD_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(16, "Article_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(17, "Barcode_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(18, "Book02_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(19, "Book03_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(20, "Book04_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(21, "Book05_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(22, "Buy_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(23, "Calendar_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(24, "Calendar02_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(25, "Card_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(26, "Cards_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(27, "Carousel_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(28, "ClearFilter_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(29, "Clip_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(30, "Close_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(31, "Comment_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(32, "Contact_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(33, "Content_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(34, "Copy_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(35, "CostAnalysis_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(36, "Customer_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(37, "CustomerEmployees_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(38, "Customization_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(39, "CustomizeGrid_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(40, "Cut_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(41, "ChangeView_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(42, "Charge_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(43, "Chart_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(44, "ChartsShowLegend_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(45, "ChartYAxisSettings_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(46, "Check01A_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(47, "Check01D_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(48, "Check01H_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(49, "Check02A_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(50, "Check02D_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(51, "Check02H_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(52, "CheckBox_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(53, "Database_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(54, "DataPanel_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(55, "Delete_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(56, "Delete02_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(57, "DeleteDataSource_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(58, "DeleteList_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(59, "DeleteList02_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(60, "Design_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(61, "Design02_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(62, "Docking_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(63, "DoubleFirst_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(64, "DoubleLast_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(65, "DoubleNext_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(66, "DoublePrev_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(67, "DownLoad02_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(68, "Driving_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(69, "Edit_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(70, "Edit02_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(71, "EditContact_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(72, "EditDataSource_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(73, "EditPageHF_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(74, "EditTask_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(75, "EmployeeNotice_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(76, "Excel_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(77, "Exit_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(78, "ExpandCollapse_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(79, "Export_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(80, "ExportFile_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(81, "Filter_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(82, "Find_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(83, "FindByID_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(84, "FindCustomers_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(85, "First_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(86, "FitToPage_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(87, "FlagEng_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(88, "FlagVie_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(89, "Folder02_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(90, "FolderPanel_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(91, "ForceTesting_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(92, "GettingStarted_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(93, "Grid_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(94, "Group_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(95, "GroupFieldCollection_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(96, "HideProduct_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(97, "HistoryItem_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(98, "Home_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(99, "IDE_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(100, "Index_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(101, "Info_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(102, "Insert_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(103, "Issue_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(104, "KnowledgeBaseArticle_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(105, "Last_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(106, "List_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(107, "LoadFrom_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(108, "LoadPageSetup_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(109, "Lock_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(110, "Mail_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(111, "MailMerge_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(112, "Mapit_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(113, "Media_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(114, "Meeting_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(115, "MoveDown_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(116, "MoveUp_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(117, "Mr_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(118, "Navigate_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(119, "New_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(120, "NewContact_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(121, "NewCustomers_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(122, "NewDoc_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(123, "NewEmployee_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(124, "NewGroup_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(125, "NewItem_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(126, "NewOpportunities_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(127, "NewProducts_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(128, "NewSales_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(129, "Next_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(130, "None_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(131, "Note02_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(132, "Note03_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(133, "Notes_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(134, "Open_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(135, "OpenDoc_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(136, "PackageProduct_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(137, "PageNext_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(138, "PagePrev_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(139, "PageSetup_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(140, "PanelBottom_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(141, "PanelOff_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(142, "PanelRight_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(143, "Paste_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(144, "Pencil_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(145, "PictureShapeOutlineColor_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(146, "Pivot_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(147, "Prev_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(148, "Preview_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(149, "Print_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(150, "Print02_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(151, "PrintDueDate_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(152, "PrintPreview_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(153, "PrintQuick_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(154, "PrintSortAsc_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(155, "PrintSortDesc_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(156, "PrintStartDate_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(157, "Process01_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(158, "Process02_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(159, "Process03_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(160, "Process04_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(161, "Product_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(162, "ProductComparisons_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(163, "ProductSalesReport_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(164, "ProductShipments_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(165, "ProductTopSalesPerson_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(166, "Project_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(167, "ProjectDirectory_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(168, "ProjectFile_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(169, "Protection_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(170, "PublicFix_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(171, "Question_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(172, "Redo_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(173, "Refresh_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(174, "Refresh2_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(175, "RemoveItem_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(176, "Rename_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(177, "Report_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(178, "Reset_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(179, "ResetChanges_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(180, "ReversSort_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(181, "RowCurrent_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(182, "RowSelected_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(183, "RowVisible_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(184, "Save_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(185, "SaveAs_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(186, "SaveBlue_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(187, "SaveClose_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(188, "Search_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(189, "ShowProduct_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(190, "ShowTestReport_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(191, "SortAsc_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(192, "SortByInvoice_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(193, "SortByOrderDate_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(194, "SortDesc_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(195, "SplitAppointment_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(196, "Summary_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(197, "Support_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(198, "Task_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(199, "Task2_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(200, "TaskList_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(201, "Team_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(202, "Template_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(203, "TextBox_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(204, "Tool02_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(205, "Tool03_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(206, "Tool04_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(207, "Undo_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(208, "Verified_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(209, "Version_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(210, "ViewReset_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(211, "Watermark_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(212, "Windows_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(213, "Wizard_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(214, "Word_16x16.png")
        Me.MyImageCollection.Images.SetKeyName(215, "Zoom_16x16.png")
        '
        'lblUserName
        '
        Me.lblUserName.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblUserName.Appearance.Options.UseFont = True
        Me.lblUserName.AutoSetTextToToolTip = False
        Me.lblUserName.Location = New System.Drawing.Point(12, 12)
        Me.lblUserName.MyNextControl = Me.txtUserName
        Me.lblUserName.MyTag01 = Nothing
        Me.lblUserName.MyTag02 = Nothing
        Me.lblUserName.MyTag03 = Nothing
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(83, 15)
        Me.lblUserName.TabIndex = 0
        Me.lblUserName.TagEN = Nothing
        Me.lblUserName.Text = "Tên đăng nhập"
        '
        'txtUserName
        '
        Me.txtUserName.EnterMoveNextControl = True
        Me.txtUserName.Location = New System.Drawing.Point(101, 9)
        Me.txtUserName.MenuManager = Me.MyBarManager
        Me.txtUserName.MyAutoFormat = False
        Me.txtUserName.MyCheckAutoFormat = False
        Me.txtUserName.MyDataType = HTLFW.eValidDataRange.StringType
        Me.txtUserName.MyForceRelateControlOnLeave = True
        Me.txtUserName.MyIsFirstInPair = False
        Me.txtUserName.MyMaxLength = 0
        Me.txtUserName.MyRelateControl = Nothing
        Me.txtUserName.MyTag01 = Nothing
        Me.txtUserName.MyTag02 = Nothing
        Me.txtUserName.MyTag03 = Nothing
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtUserName.Properties.Appearance.Options.UseFont = True
        Me.txtUserName.Properties.MyAutoFormat = False
        Me.txtUserName.Properties.MyEditValue = Nothing
        Me.txtUserName.Properties.MyTag01 = Nothing
        Me.txtUserName.Properties.MyTag02 = Nothing
        Me.txtUserName.Properties.MyTag03 = Nothing
        Me.txtUserName.Properties.ValidateOnEnterKey = True
        Me.txtUserName.Size = New System.Drawing.Size(216, 22)
        Me.txtUserName.TabIndex = 1
        '
        'lblPass
        '
        Me.lblPass.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblPass.Appearance.Options.UseFont = True
        Me.lblPass.AutoSetTextToToolTip = False
        Me.lblPass.Location = New System.Drawing.Point(42, 40)
        Me.lblPass.MyNextControl = Me.txtPass
        Me.lblPass.MyTag01 = Nothing
        Me.lblPass.MyTag02 = Nothing
        Me.lblPass.MyTag03 = Nothing
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(49, 15)
        Me.lblPass.TabIndex = 2
        Me.lblPass.TagEN = Nothing
        Me.lblPass.Text = "Mật khẩu"
        '
        'txtPass
        '
        Me.txtPass.EnterMoveNextControl = True
        Me.txtPass.Location = New System.Drawing.Point(101, 37)
        Me.txtPass.MenuManager = Me.MyBarManager
        Me.txtPass.MyAutoFormat = False
        Me.txtPass.MyCheckAutoFormat = False
        Me.txtPass.MyDataType = HTLFW.eValidDataRange.StringType
        Me.txtPass.MyForceRelateControlOnLeave = True
        Me.txtPass.MyIsFirstInPair = False
        Me.txtPass.MyMaxLength = 0
        Me.txtPass.MyRelateControl = Nothing
        Me.txtPass.MyTag01 = Nothing
        Me.txtPass.MyTag02 = Nothing
        Me.txtPass.MyTag03 = Nothing
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtPass.Properties.Appearance.Options.UseFont = True
        Me.txtPass.Properties.MyAutoFormat = False
        Me.txtPass.Properties.MyEditValue = Nothing
        Me.txtPass.Properties.MyTag01 = Nothing
        Me.txtPass.Properties.MyTag02 = Nothing
        Me.txtPass.Properties.MyTag03 = Nothing
        Me.txtPass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Properties.ValidateOnEnterKey = True
        Me.txtPass.Size = New System.Drawing.Size(216, 22)
        Me.txtPass.TabIndex = 3
        '
        'chk_Remember
        '
        Me.chk_Remember.Location = New System.Drawing.Point(99, 65)
        Me.chk_Remember.MenuManager = Me.MyBarManager
        Me.chk_Remember.MyAutoFormat = False
        Me.chk_Remember.MyCheckAutoFormat = False
        Me.chk_Remember.MyTag01 = Nothing
        Me.chk_Remember.MyTag02 = Nothing
        Me.chk_Remember.MyTag03 = Nothing
        Me.chk_Remember.Name = "chk_Remember"
        Me.chk_Remember.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.chk_Remember.Properties.Appearance.Options.UseFont = True
        Me.chk_Remember.Properties.AutoWidth = True
        Me.chk_Remember.Properties.Caption = "Ghi nhớ đăng nhập"
        Me.chk_Remember.Properties.FullFocusRect = True
        Me.chk_Remember.Properties.MyAutoFormat = False
        Me.chk_Remember.Properties.MyEditValue = False
        Me.chk_Remember.Properties.MyTag01 = Nothing
        Me.chk_Remember.Properties.MyTag02 = Nothing
        Me.chk_Remember.Properties.MyTag03 = Nothing
        Me.chk_Remember.Size = New System.Drawing.Size(128, 19)
        Me.chk_Remember.TabIndex = 6
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.AutoSize = True
        Me.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnCancel.ImageOptions.ImageIndex = 30
        Me.btnCancel.ImageOptions.ImageList = Me.MyImageCollection
        Me.btnCancel.Location = New System.Drawing.Point(250, 88)
        Me.btnCancel.MyAutoWidth = False
        Me.btnCancel.MyButtonCommonStyle = HTLFW.UCSimpleButton.eButtonCommonStyle.cmdNone
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Padding = New System.Windows.Forms.Padding(3)
        Me.btnCancel.Size = New System.Drawing.Size(67, 28)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Đó&ng"
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogin.AutoSize = True
        Me.btnLogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnLogin.ImageOptions.ImageIndex = 12
        Me.btnLogin.ImageOptions.ImageList = Me.MyImageCollection
        Me.btnLogin.Location = New System.Drawing.Point(157, 88)
        Me.btnLogin.MyAutoWidth = False
        Me.btnLogin.MyButtonCommonStyle = HTLFW.UCSimpleButton.eButtonCommonStyle.cmdNone
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Padding = New System.Windows.Forms.Padding(3)
        Me.btnLogin.Size = New System.Drawing.Size(87, 28)
        ToolTipTitleItem1.Text = "Thông tin chi tiết"
        ToolTipItem1.LeftIndent = 6
        ToolTipTitleItem2.LeftIndent = 6
        ToolTipTitleItem2.Text = "Ctrl+E"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        SuperToolTip1.Items.Add(ToolTipSeparatorItem1)
        SuperToolTip1.Items.Add(ToolTipTitleItem2)
        Me.btnLogin.SuperTip = SuperToolTip1
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Đăng nhập"
        '
        'frmLogin
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(330, 128)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.chk_Remember)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUserName)
        Me.HelpProvider.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(340, 160)
        Me.MinimumSize = New System.Drawing.Size(340, 160)
        Me.Name = "frmLogin"
        Me.HelpProvider.SetShowHelp(Me, True)
        Me.ShowInTaskbar = True
        Me.Text = "Đăng nhập"
        Me.Controls.SetChildIndex(Me.lblUserName, 0)
        Me.Controls.SetChildIndex(Me.lblPass, 0)
        Me.Controls.SetChildIndex(Me.txtUserName, 0)
        Me.Controls.SetChildIndex(Me.txtPass, 0)
        Me.Controls.SetChildIndex(Me.chk_Remember, 0)
        Me.Controls.SetChildIndex(Me.btnLogin, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        CType(Me.DxError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_Remember.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUserName As HTLFW.UCLabel
    Friend WithEvents lblPass As HTLFW.UCLabel
    Friend WithEvents txtUserName As HTLFW.UCTextEdit
    Friend WithEvents txtPass As HTLFW.UCTextEdit
    Friend WithEvents chk_Remember As HTLFW.CheckBox
    Friend WithEvents btnCancel As HTLFW.UCSimpleButton
    Friend WithEvents btnLogin As HTLFW.UCSimpleButton
End Class
