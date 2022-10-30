<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTOL_ItemPickList
    Inherits AppRoot.frmBase

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTOL_ItemPickList))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.grdColIsPicked = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEditIsPicked = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.CurrValue = New HTLFW.UCTextEdit2()
        Me.lblCurrValue = New HTLFW.UCLabel()
        Me.gcData = New HTLFW.UCGridControl()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grdColSTT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdColCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.popmnuCheck = New DevExpress.XtraBars.PopupMenu()
        Me.mnuCheck = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuUnCheck = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuCheckAll = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuUnCheckAll = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuReverse = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuReverseAll = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdCheckAll = New HTLFW.UCSimpleButton()
        Me.cmdUnCheckAll = New HTLFW.UCSimpleButton()
        Me.cmdDone = New HTLFW.UCSimpleButton()
        Me.cmdExit = New HTLFW.UCSimpleButton()
        CType(Me.DxError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyBarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colEditIsPicked, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popmnuCheck, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'MyBarManager
        '
        Me.MyBarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.mnuCheck, Me.mnuUnCheck, Me.mnuCheckAll, Me.mnuUnCheckAll, Me.mnuReverse, Me.mnuReverseAll})
        Me.MyBarManager.MaxItemId = 7
        '
        'grdColIsPicked
        '
        Me.grdColIsPicked.Caption = "Chọn"
        Me.grdColIsPicked.ColumnEdit = Me.colEditIsPicked
        Me.grdColIsPicked.FieldName = "IsPicked"
        Me.grdColIsPicked.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.grdColIsPicked.Name = "grdColIsPicked"
        Me.grdColIsPicked.OptionsColumn.AllowShowHide = False
        Me.grdColIsPicked.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.grdColIsPicked.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "IsPicked", "{0:N0}", "IsPicked")})
        Me.grdColIsPicked.Visible = True
        Me.grdColIsPicked.VisibleIndex = 2
        Me.grdColIsPicked.Width = 20
        '
        'colEditIsPicked
        '
        Me.colEditIsPicked.AutoHeight = False
        Me.colEditIsPicked.Name = "colEditIsPicked"
        '
        'CurrValue
        '
        Me.CurrValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurrValue.EnterMoveNextControl = True
        Me.CurrValue.Location = New System.Drawing.Point(111, 9)
        Me.CurrValue.MyAutoFormat = False
        Me.CurrValue.MyCheckAutoFormat = False
        Me.CurrValue.MyDataType = HTLFW.eValidDataRange.StringType
        Me.CurrValue.MyForceRelateControlOnLeave = True
        Me.CurrValue.MyIsFirstInPair = False
        Me.CurrValue.MyMaxLength = 0
        Me.CurrValue.MyRelateControl = Nothing
        Me.CurrValue.MyTag01 = Nothing
        Me.CurrValue.MyTag02 = Nothing
        Me.CurrValue.MyTag03 = Nothing
        Me.CurrValue.Name = "CurrValue"
        Me.CurrValue.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.CurrValue.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.CurrValue.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CurrValue.Properties.Appearance.Options.UseBackColor = True
        Me.CurrValue.Properties.Appearance.Options.UseFont = True
        Me.CurrValue.Properties.Appearance.Options.UseForeColor = True
        Me.CurrValue.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.CurrValue.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.CurrValue.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.CurrValue.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.CurrValue.Properties.MyAutoFormat = False
        Me.CurrValue.Properties.MyEditValue = Nothing
        Me.CurrValue.Properties.MyTag01 = Nothing
        Me.CurrValue.Properties.MyTag02 = Nothing
        Me.CurrValue.Properties.MyTag03 = Nothing
        Me.CurrValue.Properties.ReadOnly = True
        Me.CurrValue.Size = New System.Drawing.Size(301, 22)
        Me.CurrValue.TabIndex = 6
        Me.CurrValue.TabStop = False
        '
        'lblCurrValue
        '
        Me.lblCurrValue.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblCurrValue.Appearance.Options.UseFont = True
        Me.lblCurrValue.Appearance.Options.UseTextOptions = True
        Me.lblCurrValue.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblCurrValue.AutoSetTextToToolTip = False
        Me.lblCurrValue.Location = New System.Drawing.Point(12, 12)
        Me.lblCurrValue.MyNextControl = Me.CurrValue
        Me.lblCurrValue.MyTag01 = Nothing
        Me.lblCurrValue.MyTag02 = Nothing
        Me.lblCurrValue.MyTag03 = Nothing
        Me.lblCurrValue.Name = "lblCurrValue"
        Me.lblCurrValue.Size = New System.Drawing.Size(93, 15)
        Me.lblCurrValue.TabIndex = 5
        Me.lblCurrValue.TagEN = Nothing
        Me.lblCurrValue.Text = "Giá trị đang chọn"
        '
        'gcData
        '
        Me.gcData.AllowCommandDelete = False
        Me.gcData.AllowCommandModify = False
        Me.gcData.AllowCommandView = False
        Me.gcData.AllowContextMenu = True
        Me.gcData.AllowInvalidRowHandle = True
        Me.gcData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcData.AutoFocusToNewRow = True
        Me.gcData.ColumnNamePrefix = ""
        Me.gcData.EnableCommandDelete = True
        Me.gcData.EnableCommandModify = True
        Me.gcData.EnableCommandView = True
        Me.gcData.Location = New System.Drawing.Point(0, 36)
        Me.gcData.MainView = Me.gvData
        Me.gcData.MyAutoFormat = False
        Me.gcData.MyBoldFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gcData.MyCheckAutoFormat = False
        Me.gcData.MyColorStyle = HTLFW.eColorStyle.VS13
        Me.gcData.MyFocusBackColor = System.Drawing.Color.Empty
        Me.gcData.MyFocusForeColor = System.Drawing.Color.Empty
        Me.gcData.MyItalicFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gcData.MyMainView = Me.gvData
        Me.gcData.MyNewRowBackColor = System.Drawing.Color.LemonChiffon
        Me.gcData.MyNewRowForeColor = System.Drawing.Color.Black
        Me.gcData.MyNormalFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gcData.MyOrdSource = HTLFW.UCGridControl.eOrdSource.RowHandle
        Me.gcData.MyShowDateCreatedColumn = False
        Me.gcData.MyShowDateModifiedColumn = False
        Me.gcData.MyShowDeleteCMD = False
        Me.gcData.MyShowModifyCMD = False
        Me.gcData.MyShowOrderColumn = False
        Me.gcData.MyShowUserCreatedColumn = False
        Me.gcData.MyShowUserModifiedColumn = False
        Me.gcData.MyShowViewCMD = False
        Me.gcData.MyViewType = HTLFW.UCGridControl.eViewType.EditableView
        Me.gcData.Name = "gcData"
        Me.gcData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colEditIsPicked})
        Me.gcData.ShowFilterRow = True
        Me.gcData.ShowFooter = True
        Me.gcData.ShowGroupPanel = False
        Me.gcData.ShowNewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
        Me.gcData.Size = New System.Drawing.Size(424, 525)
        Me.gcData.TabIndex = 0
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'gvData
        '
        Me.gvData.Appearance.FilterPanel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvData.Appearance.FilterPanel.Options.UseFont = True
        Me.gvData.Appearance.FooterPanel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvData.Appearance.FooterPanel.Options.UseFont = True
        Me.gvData.Appearance.GroupFooter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvData.Appearance.GroupFooter.Options.UseFont = True
        Me.gvData.Appearance.GroupPanel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvData.Appearance.GroupPanel.Options.UseFont = True
        Me.gvData.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvData.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvData.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvData.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvData.Appearance.Row.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvData.Appearance.Row.Options.UseFont = True
        Me.gvData.Appearance.TopNewRow.BackColor = System.Drawing.Color.LemonChiffon
        Me.gvData.Appearance.TopNewRow.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gvData.Appearance.TopNewRow.ForeColor = System.Drawing.Color.Black
        Me.gvData.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gvData.Appearance.TopNewRow.Options.UseFont = True
        Me.gvData.Appearance.TopNewRow.Options.UseForeColor = True
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.grdColSTT, Me.grdColCode, Me.grdColIsPicked})
        Me.gvData.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.grdColIsPicked
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = True
        Me.gvData.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gvData.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvData.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvData.OptionsBehavior.AutoExpandAllGroups = True
        Me.gvData.OptionsBehavior.AutoPopulateColumns = False
        Me.gvData.OptionsBehavior.FocusLeaveOnTab = True
        Me.gvData.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvData.OptionsMenu.EnableColumnMenu = False
        Me.gvData.OptionsMenu.EnableFooterMenu = False
        Me.gvData.OptionsMenu.EnableGroupPanelMenu = False
        Me.gvData.OptionsNavigation.AutoFocusNewRow = True
        Me.gvData.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvData.OptionsPrint.AutoWidth = False
        Me.gvData.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvData.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvData.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.gvData.OptionsView.ColumnAutoWidth = False
        Me.gvData.OptionsView.EnableAppearanceEvenRow = True
        Me.gvData.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.gvData.OptionsView.ShowAutoFilterRow = True
        Me.gvData.OptionsView.ShowFooter = True
        Me.gvData.OptionsView.ShowGroupPanel = False
        Me.gvData.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.grdColCode, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'grdColSTT
        '
        Me.grdColSTT.AppearanceCell.Options.UseTextOptions = True
        Me.grdColSTT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdColSTT.Caption = "#"
        Me.grdColSTT.DisplayFormat.FormatString = "N0"
        Me.grdColSTT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.grdColSTT.FieldName = "#"
        Me.grdColSTT.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.grdColSTT.MaxWidth = 40
        Me.grdColSTT.MinWidth = 40
        Me.grdColSTT.Name = "grdColSTT"
        Me.grdColSTT.OptionsColumn.AllowEdit = False
        Me.grdColSTT.OptionsColumn.AllowFocus = False
        Me.grdColSTT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.grdColSTT.OptionsColumn.AllowIncrementalSearch = False
        Me.grdColSTT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.grdColSTT.OptionsColumn.AllowMove = False
        Me.grdColSTT.OptionsColumn.AllowShowHide = False
        Me.grdColSTT.OptionsColumn.AllowSize = False
        Me.grdColSTT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.grdColSTT.OptionsColumn.FixedWidth = True
        Me.grdColSTT.OptionsColumn.ReadOnly = True
        Me.grdColSTT.OptionsColumn.ShowInCustomizationForm = False
        Me.grdColSTT.OptionsColumn.TabStop = False
        Me.grdColSTT.OptionsFilter.AllowAutoFilter = False
        Me.grdColSTT.OptionsFilter.AllowFilter = False
        Me.grdColSTT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals
        Me.grdColSTT.Tag = "SYSCOMMANDROWORDER"
        Me.grdColSTT.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.grdColSTT.Visible = True
        Me.grdColSTT.VisibleIndex = 0
        Me.grdColSTT.Width = 40
        '
        'grdColCode
        '
        Me.grdColCode.Caption = "Mã"
        Me.grdColCode.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.grdColCode.Name = "grdColCode"
        Me.grdColCode.OptionsColumn.AllowEdit = False
        Me.grdColCode.OptionsColumn.AllowFocus = False
        Me.grdColCode.OptionsColumn.AllowShowHide = False
        Me.grdColCode.OptionsColumn.ReadOnly = True
        Me.grdColCode.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.grdColCode.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.grdColCode.Visible = True
        Me.grdColCode.VisibleIndex = 1
        Me.grdColCode.Width = 26
        '
        'popmnuCheck
        '
        Me.popmnuCheck.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.mnuCheck), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuUnCheck), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuCheckAll, True), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuUnCheckAll), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuReverse, True), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuReverseAll)})
        Me.popmnuCheck.Manager = Me.MyBarManager
        Me.popmnuCheck.Name = "popmnuCheck"
        '
        'mnuCheck
        '
        Me.mnuCheck.Caption = "Chọn"
        Me.mnuCheck.Id = 1
        Me.mnuCheck.ImageOptions.ImageIndex = 46
        Me.mnuCheck.Name = "mnuCheck"
        '
        'mnuUnCheck
        '
        Me.mnuUnCheck.Caption = "Bỏ chọn"
        Me.mnuUnCheck.Id = 2
        Me.mnuUnCheck.ImageOptions.ImageIndex = 47
        Me.mnuUnCheck.Name = "mnuUnCheck"
        '
        'mnuCheckAll
        '
        Me.mnuCheckAll.Caption = "Chọn hết"
        Me.mnuCheckAll.Id = 3
        Me.mnuCheckAll.ImageOptions.ImageIndex = 49
        Me.mnuCheckAll.Name = "mnuCheckAll"
        '
        'mnuUnCheckAll
        '
        Me.mnuUnCheckAll.Caption = "Bỏ chọn hết"
        Me.mnuUnCheckAll.Id = 4
        Me.mnuUnCheckAll.ImageOptions.ImageIndex = 50
        Me.mnuUnCheckAll.Name = "mnuUnCheckAll"
        '
        'mnuReverse
        '
        Me.mnuReverse.Caption = "Chọn ngược lại"
        Me.mnuReverse.Id = 5
        Me.mnuReverse.ImageOptions.ImageIndex = 48
        Me.mnuReverse.Name = "mnuReverse"
        '
        'mnuReverseAll
        '
        Me.mnuReverseAll.Caption = "Chọn ngược lại hết"
        Me.mnuReverseAll.Id = 6
        Me.mnuReverseAll.ImageOptions.ImageIndex = 51
        Me.mnuReverseAll.Name = "mnuReverseAll"
        '
        'cmdCheckAll
        '
        Me.cmdCheckAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCheckAll.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.cmdCheckAll.ImageOptions.ImageIndex = 49
        Me.cmdCheckAll.ImageOptions.ImageList = Me.MyImageCollection
        Me.cmdCheckAll.Location = New System.Drawing.Point(12, 567)
        Me.cmdCheckAll.MyAutoWidth = False
        Me.cmdCheckAll.MyButtonCommonStyle = HTLFW.UCSimpleButton.eButtonCommonStyle.cmdNone
        Me.cmdCheckAll.Name = "cmdCheckAll"
        Me.cmdCheckAll.Size = New System.Drawing.Size(75, 23)
        Me.cmdCheckAll.TabIndex = 1
        Me.cmdCheckAll.Text = "&Chọn hết"
        '
        'cmdUnCheckAll
        '
        Me.cmdUnCheckAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdUnCheckAll.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.cmdUnCheckAll.ImageOptions.ImageIndex = 50
        Me.cmdUnCheckAll.ImageOptions.ImageList = Me.MyImageCollection
        Me.cmdUnCheckAll.Location = New System.Drawing.Point(93, 567)
        Me.cmdUnCheckAll.MyAutoWidth = False
        Me.cmdUnCheckAll.MyButtonCommonStyle = HTLFW.UCSimpleButton.eButtonCommonStyle.cmdNone
        Me.cmdUnCheckAll.Name = "cmdUnCheckAll"
        Me.cmdUnCheckAll.Size = New System.Drawing.Size(90, 23)
        Me.cmdUnCheckAll.TabIndex = 2
        Me.cmdUnCheckAll.Text = "&Bỏ chọn hết"
        '
        'cmdDone
        '
        Me.cmdDone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDone.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.cmdDone.ImageOptions.ImageIndex = 8
        Me.cmdDone.ImageOptions.ImageList = Me.MyImageCollection
        Me.cmdDone.Location = New System.Drawing.Point(295, 567)
        Me.cmdDone.MyAutoWidth = False
        Me.cmdDone.MyButtonCommonStyle = HTLFW.UCSimpleButton.eButtonCommonStyle.cmdNone
        Me.cmdDone.Name = "cmdDone"
        Me.cmdDone.Size = New System.Drawing.Size(55, 23)
        Me.cmdDone.TabIndex = 3
        Me.cmdDone.Text = "&Xong"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.cmdExit.ImageOptions.ImageIndex = 30
        Me.cmdExit.ImageOptions.ImageList = Me.MyImageCollection
        Me.cmdExit.Location = New System.Drawing.Point(356, 567)
        Me.cmdExit.MyAutoWidth = False
        Me.cmdExit.MyButtonCommonStyle = HTLFW.UCSimpleButton.eButtonCommonStyle.cmdNone
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(56, 23)
        Me.cmdExit.TabIndex = 4
        Me.cmdExit.Text = "Đó&ng"
        '
        'frmTOL_ItemPickList
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(424, 602)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdDone)
        Me.Controls.Add(Me.cmdUnCheckAll)
        Me.Controls.Add(Me.cmdCheckAll)
        Me.Controls.Add(Me.gcData)
        Me.Controls.Add(Me.CurrValue)
        Me.Controls.Add(Me.lblCurrValue)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.HelpProvider.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.MinimumSize = New System.Drawing.Size(400, 400)
        Me.Name = "frmTOL_ItemPickList"
        Me.HelpProvider.SetShowHelp(Me, False)
        Me.Text = "Chọn danh sách"
        Me.Controls.SetChildIndex(Me.lblCurrValue, 0)
        Me.Controls.SetChildIndex(Me.CurrValue, 0)
        Me.Controls.SetChildIndex(Me.gcData, 0)
        Me.Controls.SetChildIndex(Me.cmdCheckAll, 0)
        Me.Controls.SetChildIndex(Me.cmdUnCheckAll, 0)
        Me.Controls.SetChildIndex(Me.cmdDone, 0)
        Me.Controls.SetChildIndex(Me.cmdExit, 0)
        CType(Me.DxError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyBarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colEditIsPicked, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popmnuCheck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CurrValue As HTLFW.UCTextEdit2
    Friend WithEvents lblCurrValue As HTLFW.UCLabel
    Friend WithEvents gcData As HTLFW.UCGridControl
    Friend WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdColSTT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdColIsPicked As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEditIsPicked As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents popmnuCheck As DevExpress.XtraBars.PopupMenu
    Friend WithEvents grdColCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents mnuCheck As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuUnCheck As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuCheckAll As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuUnCheckAll As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuReverse As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuReverseAll As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdCheckAll As HTLFW.UCSimpleButton
    Friend WithEvents cmdUnCheckAll As HTLFW.UCSimpleButton
    Friend WithEvents cmdDone As HTLFW.UCSimpleButton
    Friend WithEvents cmdExit As HTLFW.UCSimpleButton
End Class
