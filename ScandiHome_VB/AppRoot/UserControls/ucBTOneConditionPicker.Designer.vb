<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBTOneConditionPicker
    Inherits HTLFW.UCBaseCtrl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucBTOneConditionPicker))
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdPickListCodeIDs = New HTLFW.UCSimpleButton()
        Me.cboCodeIDTo = New HTLFW.UCGridLookUpEdit2()
        Me.cboCodeIDFrom = New HTLFW.UCGridLookUpEdit2()
        Me.gvcbo_CodeIDFrom = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grdColcboCodeIDFrom_ColCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdColcboCodeIDFrom_ColName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdColcboCodeIDFrom_ColValid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gvcbo_CodeIDTo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grdColcboCodeIDTo_ColCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdColcboCodeIDTo_ColName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdColcboCodeIDTo_ColValid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkcboCodeIDs = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.lblCodeIDFrom = New HTLFW.UCLabel()
        Me.lblCodeIDTo = New HTLFW.UCLabel()
        CType(Me.MyBarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMain.SuspendLayout()
        CType(Me.cboCodeIDTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCodeIDFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvcbo_CodeIDFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvcbo_CodeIDTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkcboCodeIDs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 5
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpMain.Controls.Add(Me.cmdPickListCodeIDs, 4, 2)
        Me.tlpMain.Controls.Add(Me.cboCodeIDTo, 3, 0)
        Me.tlpMain.Controls.Add(Me.chkcboCodeIDs, 0, 2)
        Me.tlpMain.Controls.Add(Me.cboCodeIDFrom, 1, 0)
        Me.tlpMain.Controls.Add(Me.lblCodeIDFrom, 0, 0)
        Me.tlpMain.Controls.Add(Me.lblCodeIDTo, 2, 0)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.MaximumSize = New System.Drawing.Size(3081, 49)
        Me.tlpMain.MinimumSize = New System.Drawing.Size(460, 49)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 3
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.tlpMain.Size = New System.Drawing.Size(460, 49)
        Me.tlpMain.TabIndex = 0
        '
        'cmdPickListCodeIDs
        '
        Me.cmdPickListCodeIDs.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.cmdPickListCodeIDs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdPickListCodeIDs.ImageOptions.ImageIndex = 62
        Me.cmdPickListCodeIDs.ImageOptions.ImageList = Me.MyImageCollection
        Me.cmdPickListCodeIDs.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdPickListCodeIDs.Location = New System.Drawing.Point(435, 27)
        Me.cmdPickListCodeIDs.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdPickListCodeIDs.MyAutoWidth = False
        Me.cmdPickListCodeIDs.MyButtonCommonStyle = HTLFW.UCSimpleButton.eButtonCommonStyle.cmdNone
        Me.cmdPickListCodeIDs.Name = "cmdPickListCodeIDs"
        Me.cmdPickListCodeIDs.Size = New System.Drawing.Size(25, 22)
        Me.cmdPickListCodeIDs.TabIndex = 6
        '
        'cboCodeIDTo
        '
        Me.cboCodeIDTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboCodeIDTo.EnterMoveNextControl = True
        Me.cboCodeIDTo.Location = New System.Drawing.Point(285, 0)
        Me.cboCodeIDTo.Margin = New System.Windows.Forms.Padding(0)
        Me.cboCodeIDTo.MyAutoClearFilterText = False
        Me.cboCodeIDTo.MyAutoFormat = False
        Me.cboCodeIDTo.MyCheckAutoFormat = False
        Me.cboCodeIDTo.MyColorStyle = HTLFW.eColorStyle.VS13
        Me.cboCodeIDTo.MyColumnWidths = New Integer() {-1, 275, 0}
        Me.cboCodeIDTo.MyDataType = HTLFW.eValidDataRange.StringType
        Me.cboCodeIDTo.MyFocusBackColor = System.Drawing.Color.Empty
        Me.cboCodeIDTo.MyFocusForeColor = System.Drawing.Color.Empty
        Me.cboCodeIDTo.MyForceRelateControlOnLeave = True
        Me.cboCodeIDTo.MyHasFilterRow = True
        Me.cboCodeIDTo.MyIsFirstInPair = False
        Me.cboCodeIDTo.MyRelateControl = Me.cboCodeIDFrom
        Me.cboCodeIDTo.MyTag01 = Nothing
        Me.cboCodeIDTo.MyTag02 = Nothing
        Me.cboCodeIDTo.MyTag03 = Nothing
        Me.cboCodeIDTo.MyTextControl = Nothing
        Me.cboCodeIDTo.Name = "cboCodeIDTo"
        Me.cboCodeIDTo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCodeIDTo.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cboCodeIDTo.Properties.Appearance.Options.UseFont = True
        Me.cboCodeIDTo.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cboCodeIDTo.Properties.AppearanceDisabled.Options.UseFont = True
        Me.cboCodeIDTo.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cboCodeIDTo.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cboCodeIDTo.Properties.AppearanceFocused.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cboCodeIDTo.Properties.AppearanceFocused.Options.UseFont = True
        Me.cboCodeIDTo.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cboCodeIDTo.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.cboCodeIDTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCodeIDTo.Properties.DisplayMember = "ColCode"
        Me.cboCodeIDTo.Properties.MyAutoClearFilterText = False
        Me.cboCodeIDTo.Properties.MyAutoFormat = False
        Me.cboCodeIDTo.Properties.MyColorStyle = HTLFW.RepositoryItemUCGridLookUpEdit2.eColorStyle.VS13
        Me.cboCodeIDTo.Properties.MyColumnWidths = New Integer() {-1, 275, 0}
        Me.cboCodeIDTo.Properties.MyEditValue = Nothing
        Me.cboCodeIDTo.Properties.MyFocusBackColor = System.Drawing.Color.Empty
        Me.cboCodeIDTo.Properties.MyFocusForeColor = System.Drawing.Color.Empty
        Me.cboCodeIDTo.Properties.MyHasFilterRow = True
        Me.cboCodeIDTo.Properties.MyTag01 = Nothing
        Me.cboCodeIDTo.Properties.MyTag02 = Nothing
        Me.cboCodeIDTo.Properties.MyTag03 = Nothing
        Me.cboCodeIDTo.Properties.MyTextControl = Nothing
        Me.cboCodeIDTo.Properties.NullText = ""
        Me.cboCodeIDTo.Properties.PopupSizeable = False
        Me.cboCodeIDTo.Properties.PopupView = Me.gvcbo_CodeIDTo
        Me.cboCodeIDTo.Properties.ShowFooter = False
        Me.cboCodeIDTo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboCodeIDTo.Properties.ValidateOnEnterKey = True
        Me.cboCodeIDTo.Properties.ValueMember = "ColCode"
        Me.cboCodeIDTo.Size = New System.Drawing.Size(150, 22)
        Me.cboCodeIDTo.TabIndex = 4
        '
        'cboCodeIDFrom
        '
        Me.cboCodeIDFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboCodeIDFrom.EnterMoveNextControl = True
        Me.cboCodeIDFrom.Location = New System.Drawing.Point(100, 0)
        Me.cboCodeIDFrom.Margin = New System.Windows.Forms.Padding(0)
        Me.cboCodeIDFrom.MyAutoClearFilterText = False
        Me.cboCodeIDFrom.MyAutoFormat = False
        Me.cboCodeIDFrom.MyCheckAutoFormat = False
        Me.cboCodeIDFrom.MyColorStyle = HTLFW.eColorStyle.VS13
        Me.cboCodeIDFrom.MyColumnWidths = New Integer() {-1, 275, 0}
        Me.cboCodeIDFrom.MyDataType = HTLFW.eValidDataRange.StringType
        Me.cboCodeIDFrom.MyFocusBackColor = System.Drawing.Color.Empty
        Me.cboCodeIDFrom.MyFocusForeColor = System.Drawing.Color.Empty
        Me.cboCodeIDFrom.MyForceRelateControlOnLeave = True
        Me.cboCodeIDFrom.MyHasFilterRow = True
        Me.cboCodeIDFrom.MyIsFirstInPair = True
        Me.cboCodeIDFrom.MyRelateControl = Me.cboCodeIDTo
        Me.cboCodeIDFrom.MyTag01 = Nothing
        Me.cboCodeIDFrom.MyTag02 = Nothing
        Me.cboCodeIDFrom.MyTag03 = Nothing
        Me.cboCodeIDFrom.MyTextControl = Nothing
        Me.cboCodeIDFrom.Name = "cboCodeIDFrom"
        Me.cboCodeIDFrom.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCodeIDFrom.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cboCodeIDFrom.Properties.Appearance.Options.UseFont = True
        Me.cboCodeIDFrom.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cboCodeIDFrom.Properties.AppearanceDisabled.Options.UseFont = True
        Me.cboCodeIDFrom.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cboCodeIDFrom.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cboCodeIDFrom.Properties.AppearanceFocused.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cboCodeIDFrom.Properties.AppearanceFocused.Options.UseFont = True
        Me.cboCodeIDFrom.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cboCodeIDFrom.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.cboCodeIDFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCodeIDFrom.Properties.DisplayMember = "ColCode"
        Me.cboCodeIDFrom.Properties.MyAutoClearFilterText = False
        Me.cboCodeIDFrom.Properties.MyAutoFormat = False
        Me.cboCodeIDFrom.Properties.MyColorStyle = HTLFW.RepositoryItemUCGridLookUpEdit2.eColorStyle.VS13
        Me.cboCodeIDFrom.Properties.MyColumnWidths = New Integer() {-1, 275, 0}
        Me.cboCodeIDFrom.Properties.MyEditValue = Nothing
        Me.cboCodeIDFrom.Properties.MyFocusBackColor = System.Drawing.Color.Empty
        Me.cboCodeIDFrom.Properties.MyFocusForeColor = System.Drawing.Color.Empty
        Me.cboCodeIDFrom.Properties.MyHasFilterRow = True
        Me.cboCodeIDFrom.Properties.MyTag01 = Nothing
        Me.cboCodeIDFrom.Properties.MyTag02 = Nothing
        Me.cboCodeIDFrom.Properties.MyTag03 = Nothing
        Me.cboCodeIDFrom.Properties.MyTextControl = Nothing
        Me.cboCodeIDFrom.Properties.NullText = ""
        Me.cboCodeIDFrom.Properties.PopupSizeable = False
        Me.cboCodeIDFrom.Properties.PopupView = Me.gvcbo_CodeIDFrom
        Me.cboCodeIDFrom.Properties.ShowFooter = False
        Me.cboCodeIDFrom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboCodeIDFrom.Properties.ValidateOnEnterKey = True
        Me.cboCodeIDFrom.Properties.ValueMember = "ColCode"
        Me.cboCodeIDFrom.Size = New System.Drawing.Size(150, 22)
        Me.cboCodeIDFrom.TabIndex = 2
        '
        'gvcbo_CodeIDFrom
        '
        Me.gvcbo_CodeIDFrom.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDFrom.Appearance.ColumnFilterButton.Options.UseFont = True
        Me.gvcbo_CodeIDFrom.Appearance.ColumnFilterButtonActive.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDFrom.Appearance.ColumnFilterButtonActive.Options.UseFont = True
        Me.gvcbo_CodeIDFrom.Appearance.CustomizationFormHint.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDFrom.Appearance.CustomizationFormHint.Options.UseFont = True
        Me.gvcbo_CodeIDFrom.Appearance.DetailTip.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDFrom.Appearance.DetailTip.Options.UseFont = True
        Me.gvcbo_CodeIDFrom.Appearance.Empty.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDFrom.Appearance.Empty.Options.UseFont = True
        Me.gvcbo_CodeIDFrom.Appearance.EvenRow.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDFrom.Appearance.EvenRow.Options.UseFont = True
        Me.gvcbo_CodeIDFrom.Appearance.FilterCloseButton.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDFrom.Appearance.FilterCloseButton.Options.UseFont = True
        Me.gvcbo_CodeIDFrom.Appearance.FilterPanel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDFrom.Appearance.FilterPanel.Options.UseFont = True
        Me.gvcbo_CodeIDFrom.Appearance.FixedLine.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDFrom.Appearance.FixedLine.Options.UseFont = True
        Me.gvcbo_CodeIDFrom.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDFrom.Appearance.FocusedCell.Options.UseFont = True
        Me.gvcbo_CodeIDFrom.Appearance.FocusedRow.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDFrom.Appearance.FocusedRow.Options.UseFont = True
        Me.gvcbo_CodeIDFrom.Appearance.FooterPanel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDFrom.Appearance.FooterPanel.Options.UseFont = True
        Me.gvcbo_CodeIDFrom.Appearance.GroupButton.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDFrom.Appearance.GroupButton.Options.UseFont = True
        Me.gvcbo_CodeIDFrom.Appearance.GroupFooter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDFrom.Appearance.GroupFooter.Options.UseFont = True
        Me.gvcbo_CodeIDFrom.Appearance.GroupPanel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDFrom.Appearance.GroupPanel.Options.UseFont = True
        Me.gvcbo_CodeIDFrom.Appearance.GroupRow.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDFrom.Appearance.GroupRow.Options.UseFont = True
        Me.gvcbo_CodeIDFrom.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDFrom.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvcbo_CodeIDFrom.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvcbo_CodeIDFrom.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvcbo_CodeIDFrom.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDFrom.Appearance.HideSelectionRow.Options.UseFont = True
        Me.gvcbo_CodeIDFrom.Appearance.HorzLine.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDFrom.Appearance.HorzLine.Options.UseFont = True
        Me.gvcbo_CodeIDFrom.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDFrom.Appearance.OddRow.Options.UseFont = True
        Me.gvcbo_CodeIDFrom.Appearance.Preview.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDFrom.Appearance.Preview.Options.UseFont = True
        Me.gvcbo_CodeIDFrom.Appearance.Row.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDFrom.Appearance.Row.Options.UseFont = True
        Me.gvcbo_CodeIDFrom.Appearance.RowSeparator.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDFrom.Appearance.RowSeparator.Options.UseFont = True
        Me.gvcbo_CodeIDFrom.Appearance.SelectedRow.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDFrom.Appearance.SelectedRow.Options.UseFont = True
        Me.gvcbo_CodeIDFrom.Appearance.TopNewRow.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDFrom.Appearance.TopNewRow.Options.UseFont = True
        Me.gvcbo_CodeIDFrom.Appearance.VertLine.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDFrom.Appearance.VertLine.Options.UseFont = True
        Me.gvcbo_CodeIDFrom.Appearance.ViewCaption.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDFrom.Appearance.ViewCaption.Options.UseFont = True
        Me.gvcbo_CodeIDFrom.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.grdColcboCodeIDFrom_ColCode, Me.grdColcboCodeIDFrom_ColName, Me.grdColcboCodeIDFrom_ColValid})
        Me.gvcbo_CodeIDFrom.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvcbo_CodeIDFrom.Name = "gvcbo_CodeIDFrom"
        Me.gvcbo_CodeIDFrom.OptionsBehavior.Editable = False
        Me.gvcbo_CodeIDFrom.OptionsBehavior.ReadOnly = True
        Me.gvcbo_CodeIDFrom.OptionsCustomization.AllowColumnMoving = False
        Me.gvcbo_CodeIDFrom.OptionsCustomization.AllowColumnResizing = False
        Me.gvcbo_CodeIDFrom.OptionsCustomization.AllowGroup = False
        Me.gvcbo_CodeIDFrom.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvcbo_CodeIDFrom.OptionsMenu.EnableColumnMenu = False
        Me.gvcbo_CodeIDFrom.OptionsMenu.EnableFooterMenu = False
        Me.gvcbo_CodeIDFrom.OptionsMenu.EnableGroupPanelMenu = False
        Me.gvcbo_CodeIDFrom.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvcbo_CodeIDFrom.OptionsSelection.EnableAppearanceHideSelection = False
        Me.gvcbo_CodeIDFrom.OptionsView.ColumnAutoWidth = False
        Me.gvcbo_CodeIDFrom.OptionsView.ShowAutoFilterRow = True
        Me.gvcbo_CodeIDFrom.OptionsView.ShowColumnHeaders = False
        Me.gvcbo_CodeIDFrom.OptionsView.ShowGroupPanel = False
        Me.gvcbo_CodeIDFrom.OptionsView.ShowIndicator = False
        Me.gvcbo_CodeIDFrom.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.grdColcboCodeIDFrom_ColCode, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.grdColcboCodeIDFrom_ColName, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.grdColcboCodeIDFrom_ColValid, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'grdColcboCodeIDFrom_ColCode
        '
        Me.grdColcboCodeIDFrom_ColCode.AppearanceCell.Options.UseTextOptions = True
        Me.grdColcboCodeIDFrom_ColCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.grdColcboCodeIDFrom_ColCode.Caption = "Mã"
        Me.grdColcboCodeIDFrom_ColCode.FieldName = "ColCode"
        Me.grdColcboCodeIDFrom_ColCode.Name = "grdColcboCodeIDFrom_ColCode"
        Me.grdColcboCodeIDFrom_ColCode.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.grdColcboCodeIDFrom_ColCode.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.grdColcboCodeIDFrom_ColCode.Visible = True
        Me.grdColcboCodeIDFrom_ColCode.VisibleIndex = 0
        '
        'grdColcboCodeIDFrom_ColName
        '
        Me.grdColcboCodeIDFrom_ColName.AppearanceCell.Options.UseTextOptions = True
        Me.grdColcboCodeIDFrom_ColName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.grdColcboCodeIDFrom_ColName.Caption = "Tên"
        Me.grdColcboCodeIDFrom_ColName.FieldName = "ColName"
        Me.grdColcboCodeIDFrom_ColName.Name = "grdColcboCodeIDFrom_ColName"
        Me.grdColcboCodeIDFrom_ColName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.grdColcboCodeIDFrom_ColName.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.grdColcboCodeIDFrom_ColName.Visible = True
        Me.grdColcboCodeIDFrom_ColName.VisibleIndex = 1
        '
        'grdColcboCodeIDFrom_ColValid
        '
        Me.grdColcboCodeIDFrom_ColValid.AppearanceCell.Options.UseTextOptions = True
        Me.grdColcboCodeIDFrom_ColValid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.grdColcboCodeIDFrom_ColValid.Caption = "ColValid"
        Me.grdColcboCodeIDFrom_ColValid.FieldName = "ColValid"
        Me.grdColcboCodeIDFrom_ColValid.Name = "grdColcboCodeIDFrom_ColValid"
        Me.grdColcboCodeIDFrom_ColValid.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals
        Me.grdColcboCodeIDFrom_ColValid.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        '
        'gvcbo_CodeIDTo
        '
        Me.gvcbo_CodeIDTo.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDTo.Appearance.ColumnFilterButton.Options.UseFont = True
        Me.gvcbo_CodeIDTo.Appearance.ColumnFilterButtonActive.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDTo.Appearance.ColumnFilterButtonActive.Options.UseFont = True
        Me.gvcbo_CodeIDTo.Appearance.CustomizationFormHint.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDTo.Appearance.CustomizationFormHint.Options.UseFont = True
        Me.gvcbo_CodeIDTo.Appearance.DetailTip.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDTo.Appearance.DetailTip.Options.UseFont = True
        Me.gvcbo_CodeIDTo.Appearance.Empty.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDTo.Appearance.Empty.Options.UseFont = True
        Me.gvcbo_CodeIDTo.Appearance.EvenRow.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDTo.Appearance.EvenRow.Options.UseFont = True
        Me.gvcbo_CodeIDTo.Appearance.FilterCloseButton.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDTo.Appearance.FilterCloseButton.Options.UseFont = True
        Me.gvcbo_CodeIDTo.Appearance.FilterPanel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDTo.Appearance.FilterPanel.Options.UseFont = True
        Me.gvcbo_CodeIDTo.Appearance.FixedLine.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDTo.Appearance.FixedLine.Options.UseFont = True
        Me.gvcbo_CodeIDTo.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDTo.Appearance.FocusedCell.Options.UseFont = True
        Me.gvcbo_CodeIDTo.Appearance.FocusedRow.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDTo.Appearance.FocusedRow.Options.UseFont = True
        Me.gvcbo_CodeIDTo.Appearance.FooterPanel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDTo.Appearance.FooterPanel.Options.UseFont = True
        Me.gvcbo_CodeIDTo.Appearance.GroupButton.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDTo.Appearance.GroupButton.Options.UseFont = True
        Me.gvcbo_CodeIDTo.Appearance.GroupFooter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDTo.Appearance.GroupFooter.Options.UseFont = True
        Me.gvcbo_CodeIDTo.Appearance.GroupPanel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDTo.Appearance.GroupPanel.Options.UseFont = True
        Me.gvcbo_CodeIDTo.Appearance.GroupRow.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDTo.Appearance.GroupRow.Options.UseFont = True
        Me.gvcbo_CodeIDTo.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDTo.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvcbo_CodeIDTo.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvcbo_CodeIDTo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvcbo_CodeIDTo.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDTo.Appearance.HideSelectionRow.Options.UseFont = True
        Me.gvcbo_CodeIDTo.Appearance.HorzLine.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDTo.Appearance.HorzLine.Options.UseFont = True
        Me.gvcbo_CodeIDTo.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDTo.Appearance.OddRow.Options.UseFont = True
        Me.gvcbo_CodeIDTo.Appearance.Preview.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDTo.Appearance.Preview.Options.UseFont = True
        Me.gvcbo_CodeIDTo.Appearance.Row.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDTo.Appearance.Row.Options.UseFont = True
        Me.gvcbo_CodeIDTo.Appearance.RowSeparator.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDTo.Appearance.RowSeparator.Options.UseFont = True
        Me.gvcbo_CodeIDTo.Appearance.SelectedRow.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDTo.Appearance.SelectedRow.Options.UseFont = True
        Me.gvcbo_CodeIDTo.Appearance.TopNewRow.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDTo.Appearance.TopNewRow.Options.UseFont = True
        Me.gvcbo_CodeIDTo.Appearance.VertLine.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDTo.Appearance.VertLine.Options.UseFont = True
        Me.gvcbo_CodeIDTo.Appearance.ViewCaption.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvcbo_CodeIDTo.Appearance.ViewCaption.Options.UseFont = True
        Me.gvcbo_CodeIDTo.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.grdColcboCodeIDTo_ColCode, Me.grdColcboCodeIDTo_ColName, Me.grdColcboCodeIDTo_ColValid})
        Me.gvcbo_CodeIDTo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvcbo_CodeIDTo.Name = "gvcbo_CodeIDTo"
        Me.gvcbo_CodeIDTo.OptionsBehavior.Editable = False
        Me.gvcbo_CodeIDTo.OptionsBehavior.ReadOnly = True
        Me.gvcbo_CodeIDTo.OptionsCustomization.AllowColumnMoving = False
        Me.gvcbo_CodeIDTo.OptionsCustomization.AllowColumnResizing = False
        Me.gvcbo_CodeIDTo.OptionsCustomization.AllowGroup = False
        Me.gvcbo_CodeIDTo.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvcbo_CodeIDTo.OptionsMenu.EnableColumnMenu = False
        Me.gvcbo_CodeIDTo.OptionsMenu.EnableFooterMenu = False
        Me.gvcbo_CodeIDTo.OptionsMenu.EnableGroupPanelMenu = False
        Me.gvcbo_CodeIDTo.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvcbo_CodeIDTo.OptionsSelection.EnableAppearanceHideSelection = False
        Me.gvcbo_CodeIDTo.OptionsView.ColumnAutoWidth = False
        Me.gvcbo_CodeIDTo.OptionsView.ShowAutoFilterRow = True
        Me.gvcbo_CodeIDTo.OptionsView.ShowColumnHeaders = False
        Me.gvcbo_CodeIDTo.OptionsView.ShowGroupPanel = False
        Me.gvcbo_CodeIDTo.OptionsView.ShowIndicator = False
        Me.gvcbo_CodeIDTo.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.grdColcboCodeIDTo_ColCode, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.grdColcboCodeIDTo_ColName, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.grdColcboCodeIDTo_ColValid, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'grdColcboCodeIDTo_ColCode
        '
        Me.grdColcboCodeIDTo_ColCode.AppearanceCell.Options.UseTextOptions = True
        Me.grdColcboCodeIDTo_ColCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.grdColcboCodeIDTo_ColCode.Caption = "Mã"
        Me.grdColcboCodeIDTo_ColCode.FieldName = "ColCode"
        Me.grdColcboCodeIDTo_ColCode.Name = "grdColcboCodeIDTo_ColCode"
        Me.grdColcboCodeIDTo_ColCode.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.grdColcboCodeIDTo_ColCode.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.grdColcboCodeIDTo_ColCode.Visible = True
        Me.grdColcboCodeIDTo_ColCode.VisibleIndex = 0
        '
        'grdColcboCodeIDTo_ColName
        '
        Me.grdColcboCodeIDTo_ColName.AppearanceCell.Options.UseTextOptions = True
        Me.grdColcboCodeIDTo_ColName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.grdColcboCodeIDTo_ColName.Caption = "Tên"
        Me.grdColcboCodeIDTo_ColName.FieldName = "ColName"
        Me.grdColcboCodeIDTo_ColName.Name = "grdColcboCodeIDTo_ColName"
        Me.grdColcboCodeIDTo_ColName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.grdColcboCodeIDTo_ColName.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.grdColcboCodeIDTo_ColName.Visible = True
        Me.grdColcboCodeIDTo_ColName.VisibleIndex = 1
        '
        'grdColcboCodeIDTo_ColValid
        '
        Me.grdColcboCodeIDTo_ColValid.AppearanceCell.Options.UseTextOptions = True
        Me.grdColcboCodeIDTo_ColValid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.grdColcboCodeIDTo_ColValid.Caption = "ColValid"
        Me.grdColcboCodeIDTo_ColValid.FieldName = "ColValid"
        Me.grdColcboCodeIDTo_ColValid.Name = "grdColcboCodeIDTo_ColValid"
        Me.grdColcboCodeIDTo_ColValid.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.grdColcboCodeIDTo_ColValid.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        '
        'chkcboCodeIDs
        '
        Me.tlpMain.SetColumnSpan(Me.chkcboCodeIDs, 4)
        Me.chkcboCodeIDs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkcboCodeIDs.Location = New System.Drawing.Point(0, 27)
        Me.chkcboCodeIDs.Margin = New System.Windows.Forms.Padding(0)
        Me.chkcboCodeIDs.Name = "chkcboCodeIDs"
        Me.chkcboCodeIDs.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.chkcboCodeIDs.Properties.Appearance.Options.UseFont = True
        Me.chkcboCodeIDs.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.chkcboCodeIDs.Properties.AppearanceDropDown.Options.UseFont = True
        Me.chkcboCodeIDs.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.chkcboCodeIDs.Properties.DisplayMember = "ColName2"
        Me.chkcboCodeIDs.Properties.DropDownRows = 15
        Me.chkcboCodeIDs.Properties.PopupSizeable = False
        Me.chkcboCodeIDs.Properties.SelectAllItemCaption = "(Chọn hết)"
        Me.chkcboCodeIDs.Properties.SelectAllItemVisible = False
        Me.chkcboCodeIDs.Properties.ShowButtons = False
        Me.chkcboCodeIDs.Properties.ShowPopupCloseButton = False
        Me.chkcboCodeIDs.Properties.ValueMember = "ColCode"
        Me.chkcboCodeIDs.Size = New System.Drawing.Size(435, 22)
        Me.chkcboCodeIDs.TabIndex = 5
        '
        'lblCodeIDFrom
        '
        Me.lblCodeIDFrom.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblCodeIDFrom.Appearance.Options.UseFont = True
        Me.lblCodeIDFrom.Appearance.Options.UseTextOptions = True
        Me.lblCodeIDFrom.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblCodeIDFrom.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblCodeIDFrom.AutoSetTextToToolTip = False
        Me.lblCodeIDFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCodeIDFrom.Location = New System.Drawing.Point(0, 0)
        Me.lblCodeIDFrom.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCodeIDFrom.MyNextControl = Me.cboCodeIDFrom
        Me.lblCodeIDFrom.MyTag01 = Nothing
        Me.lblCodeIDFrom.MyTag02 = Nothing
        Me.lblCodeIDFrom.MyTag03 = Nothing
        Me.lblCodeIDFrom.Name = "lblCodeIDFrom"
        Me.lblCodeIDFrom.Padding = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.lblCodeIDFrom.Size = New System.Drawing.Size(100, 22)
        Me.lblCodeIDFrom.TabIndex = 1
        Me.lblCodeIDFrom.TagEN = Nothing
        Me.lblCodeIDFrom.Text = "..."
        '
        'lblCodeIDTo
        '
        Me.lblCodeIDTo.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblCodeIDTo.Appearance.Options.UseFont = True
        Me.lblCodeIDTo.Appearance.Options.UseTextOptions = True
        Me.lblCodeIDTo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblCodeIDTo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblCodeIDTo.AutoSetTextToToolTip = False
        Me.lblCodeIDTo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblCodeIDTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCodeIDTo.Location = New System.Drawing.Point(250, 0)
        Me.lblCodeIDTo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCodeIDTo.MyNextControl = Me.cboCodeIDTo
        Me.lblCodeIDTo.MyTag01 = Nothing
        Me.lblCodeIDTo.MyTag02 = Nothing
        Me.lblCodeIDTo.MyTag03 = Nothing
        Me.lblCodeIDTo.Name = "lblCodeIDTo"
        Me.lblCodeIDTo.Size = New System.Drawing.Size(35, 22)
        Me.lblCodeIDTo.TabIndex = 3
        Me.lblCodeIDTo.TagEN = Nothing
        Me.lblCodeIDTo.Text = "Đến"
        '
        'ucBTOneConditionPicker
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.tlpMain)
        Me.Name = "ucBTOneConditionPicker"
        Me.Size = New System.Drawing.Size(460, 49)
        Me.Controls.SetChildIndex(Me.tlpMain, 0)
        CType(Me.MyBarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        CType(Me.cboCodeIDTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCodeIDFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvcbo_CodeIDFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvcbo_CodeIDTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkcboCodeIDs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tlpMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblCodeIDFrom As HTLFW.UCLabel
    Friend WithEvents cmdPickListCodeIDs As HTLFW.UCSimpleButton
    Friend WithEvents cboCodeIDTo As HTLFW.UCGridLookUpEdit2
    Friend WithEvents gvcbo_CodeIDTo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents chkcboCodeIDs As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents cboCodeIDFrom As HTLFW.UCGridLookUpEdit2
    Friend WithEvents gvcbo_CodeIDFrom As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblCodeIDTo As HTLFW.UCLabel
    Friend WithEvents grdColcboCodeIDTo_ColCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdColcboCodeIDTo_ColName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdColcboCodeIDTo_ColValid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdColcboCodeIDFrom_ColCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdColcboCodeIDFrom_ColName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdColcboCodeIDFrom_ColValid As DevExpress.XtraGrid.Columns.GridColumn

End Class
