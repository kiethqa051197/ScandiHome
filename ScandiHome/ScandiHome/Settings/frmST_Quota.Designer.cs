
namespace ScandiHome.Settings
{
    partial class frmST_Quota
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmST_Quota));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lblSKUCategory = new DevExpress.XtraEditors.LabelControl();
            this.cb_Product = new DevExpress.XtraEditors.LookUpEdit();
            this.cb_Model = new DevExpress.XtraEditors.LookUpEdit();
            this.lblSKUProduct = new DevExpress.XtraEditors.LabelControl();
            this.cb_Category = new DevExpress.XtraEditors.LookUpEdit();
            this.lblSKUModel = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grd_Material = new DevExpress.XtraGrid.GridControl();
            this.grv_Material = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdCol_Material_STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCol_Material_DataCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCol_Material_DataName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCol_Material_Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_Product = new DevExpress.XtraGrid.GridControl();
            this.grv_Product = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.grdCol_Quota_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCol_Quota_ProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCol_Quota_ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCol_Quota_SKU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCol_Quota_StartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCol_Quota_EndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Product.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Model.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Category.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Material)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Material)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(74, 95);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tất cả";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(147, 95);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 21);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Hiện tại";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // lblSKUCategory
            // 
            this.lblSKUCategory.Location = new System.Drawing.Point(17, 19);
            this.lblSKUCategory.Name = "lblSKUCategory";
            this.lblSKUCategory.Size = new System.Drawing.Size(51, 16);
            this.lblSKUCategory.TabIndex = 40;
            this.lblSKUCategory.Text = "Category";
            // 
            // cb_Product
            // 
            this.cb_Product.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Product.Location = new System.Drawing.Point(74, 48);
            this.cb_Product.Name = "cb_Product";
            this.cb_Product.Properties.AutoHeight = false;
            this.cb_Product.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_Product.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DataCode", "DataCode", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DataName", "DataName", 255, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cb_Product.Properties.DisplayMember = "DataName";
            this.cb_Product.Properties.DropDownRows = 10;
            this.cb_Product.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cb_Product.Properties.ValueMember = "DataCode";
            this.cb_Product.Size = new System.Drawing.Size(992, 30);
            this.cb_Product.TabIndex = 43;
            // 
            // cb_Model
            // 
            this.cb_Model.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Model.Location = new System.Drawing.Point(582, 12);
            this.cb_Model.Name = "cb_Model";
            this.cb_Model.Properties.AutoHeight = false;
            this.cb_Model.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_Model.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DataCode", "DataCode", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DataName", "DataName", 255, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cb_Model.Properties.DisplayMember = "DataName";
            this.cb_Model.Properties.DropDownRows = 10;
            this.cb_Model.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cb_Model.Properties.ValueMember = "DataCode";
            this.cb_Model.Size = new System.Drawing.Size(484, 30);
            this.cb_Model.TabIndex = 44;
            // 
            // lblSKUProduct
            // 
            this.lblSKUProduct.Location = new System.Drawing.Point(25, 55);
            this.lblSKUProduct.Name = "lblSKUProduct";
            this.lblSKUProduct.Size = new System.Drawing.Size(43, 16);
            this.lblSKUProduct.TabIndex = 41;
            this.lblSKUProduct.Text = "Product";
            // 
            // cb_Category
            // 
            this.cb_Category.Location = new System.Drawing.Point(74, 12);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Properties.AutoHeight = false;
            this.cb_Category.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_Category.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DataCode", "DataCode", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DataName", "DataName", 255, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cb_Category.Properties.DisplayMember = "DataName";
            this.cb_Category.Properties.DropDownRows = 10;
            this.cb_Category.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cb_Category.Properties.ValueMember = "DataCode";
            this.cb_Category.Size = new System.Drawing.Size(452, 30);
            this.cb_Category.TabIndex = 45;
            // 
            // lblSKUModel
            // 
            this.lblSKUModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSKUModel.Location = new System.Drawing.Point(542, 19);
            this.lblSKUModel.Name = "lblSKUModel";
            this.lblSKUModel.Size = new System.Drawing.Size(34, 16);
            this.lblSKUModel.TabIndex = 42;
            this.lblSKUModel.Text = "Model";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.grd_Material, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grd_Product, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 122);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1078, 431);
            this.tableLayoutPanel1.TabIndex = 46;
            // 
            // grd_Material
            // 
            this.grd_Material.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Material.Location = new System.Drawing.Point(646, 0);
            this.grd_Material.MainView = this.grv_Material;
            this.grd_Material.Margin = new System.Windows.Forms.Padding(0);
            this.grd_Material.Name = "grd_Material";
            this.grd_Material.Size = new System.Drawing.Size(432, 431);
            this.grd_Material.TabIndex = 42;
            this.grd_Material.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_Material});
            // 
            // grv_Material
            // 
            this.grv_Material.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdCol_Material_STT,
            this.grdCol_Material_DataCode,
            this.grdCol_Material_DataName,
            this.grdCol_Material_Quantity});
            this.grv_Material.GridControl = this.grd_Material;
            this.grv_Material.Name = "grv_Material";
            this.grv_Material.OptionsView.ShowFooter = true;
            this.grv_Material.OptionsView.ShowGroupPanel = false;
            this.grv_Material.OptionsView.ShowViewCaption = true;
            this.grv_Material.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.grdCol_Material_STT, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.grv_Material.ViewCaption = "Định mức";
            // 
            // grdCol_Material_STT
            // 
            this.grdCol_Material_STT.AppearanceCell.Options.UseTextOptions = true;
            this.grdCol_Material_STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdCol_Material_STT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdCol_Material_STT.AppearanceHeader.Options.UseFont = true;
            this.grdCol_Material_STT.AppearanceHeader.Options.UseTextOptions = true;
            this.grdCol_Material_STT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdCol_Material_STT.Caption = "STT";
            this.grdCol_Material_STT.DisplayFormat.FormatString = "{0:N0}";
            this.grdCol_Material_STT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.grdCol_Material_STT.FieldName = "Id";
            this.grdCol_Material_STT.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.grdCol_Material_STT.MaxWidth = 70;
            this.grdCol_Material_STT.MinWidth = 70;
            this.grdCol_Material_STT.Name = "grdCol_Material_STT";
            this.grdCol_Material_STT.OptionsColumn.ReadOnly = true;
            this.grdCol_Material_STT.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.grdCol_Material_STT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Id", "{0:N0}")});
            this.grdCol_Material_STT.Visible = true;
            this.grdCol_Material_STT.VisibleIndex = 0;
            this.grdCol_Material_STT.Width = 70;
            // 
            // grdCol_Material_DataCode
            // 
            this.grdCol_Material_DataCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdCol_Material_DataCode.AppearanceHeader.Options.UseFont = true;
            this.grdCol_Material_DataCode.AppearanceHeader.Options.UseTextOptions = true;
            this.grdCol_Material_DataCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdCol_Material_DataCode.Caption = "Mã nguyên liệu";
            this.grdCol_Material_DataCode.FieldName = "DataCode";
            this.grdCol_Material_DataCode.MaxWidth = 175;
            this.grdCol_Material_DataCode.MinWidth = 150;
            this.grdCol_Material_DataCode.Name = "grdCol_Material_DataCode";
            this.grdCol_Material_DataCode.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.grdCol_Material_DataCode.OptionsColumn.ReadOnly = true;
            this.grdCol_Material_DataCode.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.grdCol_Material_DataCode.Visible = true;
            this.grdCol_Material_DataCode.VisibleIndex = 1;
            this.grdCol_Material_DataCode.Width = 150;
            // 
            // grdCol_Material_DataName
            // 
            this.grdCol_Material_DataName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdCol_Material_DataName.AppearanceHeader.Options.UseFont = true;
            this.grdCol_Material_DataName.AppearanceHeader.Options.UseTextOptions = true;
            this.grdCol_Material_DataName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdCol_Material_DataName.Caption = "Tên nguyên liệu";
            this.grdCol_Material_DataName.FieldName = "DataName";
            this.grdCol_Material_DataName.MaxWidth = 275;
            this.grdCol_Material_DataName.MinWidth = 200;
            this.grdCol_Material_DataName.Name = "grdCol_Material_DataName";
            this.grdCol_Material_DataName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.grdCol_Material_DataName.OptionsColumn.ReadOnly = true;
            this.grdCol_Material_DataName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.grdCol_Material_DataName.Visible = true;
            this.grdCol_Material_DataName.VisibleIndex = 2;
            this.grdCol_Material_DataName.Width = 200;
            // 
            // grdCol_Material_Quantity
            // 
            this.grdCol_Material_Quantity.AppearanceCell.Options.UseTextOptions = true;
            this.grdCol_Material_Quantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.grdCol_Material_Quantity.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdCol_Material_Quantity.AppearanceHeader.Options.UseFont = true;
            this.grdCol_Material_Quantity.AppearanceHeader.Options.UseTextOptions = true;
            this.grdCol_Material_Quantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdCol_Material_Quantity.Caption = "Số lượng";
            this.grdCol_Material_Quantity.DisplayFormat.FormatString = "{0:N0}";
            this.grdCol_Material_Quantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.grdCol_Material_Quantity.FieldName = "Quantity";
            this.grdCol_Material_Quantity.MaxWidth = 100;
            this.grdCol_Material_Quantity.MinWidth = 75;
            this.grdCol_Material_Quantity.Name = "grdCol_Material_Quantity";
            this.grdCol_Material_Quantity.Visible = true;
            this.grdCol_Material_Quantity.VisibleIndex = 3;
            this.grdCol_Material_Quantity.Width = 100;
            // 
            // grd_Product
            // 
            this.grd_Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Product.Location = new System.Drawing.Point(0, 0);
            this.grd_Product.MainView = this.grv_Product;
            this.grd_Product.Margin = new System.Windows.Forms.Padding(0);
            this.grd_Product.Name = "grd_Product";
            this.grd_Product.Size = new System.Drawing.Size(646, 431);
            this.grd_Product.TabIndex = 1;
            this.grd_Product.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_Product});
            // 
            // grv_Product
            // 
            this.grv_Product.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdCol_Quota_Id,
            this.grdCol_Quota_ProductCode,
            this.grdCol_Quota_SKU,
            this.grdCol_Quota_ProductName,
            this.grdCol_Quota_StartDate,
            this.grdCol_Quota_EndDate});
            this.grv_Product.GridControl = this.grd_Product;
            this.grv_Product.Name = "grv_Product";
            this.grv_Product.OptionsView.ShowViewCaption = true;
            this.grv_Product.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.grdCol_Quota_ProductCode, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.grv_Product.ViewCaption = "Sản phẩm";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.AutoSize = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnCancel.Location = new System.Drawing.Point(980, 563);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(3);
            this.btnCancel.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnCancel.Size = new System.Drawing.Size(86, 35);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.Text = "Đó&ng";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.AutoSize = true;
            this.simpleButton4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton4.ImageOptions.SvgImage = global::ScandiHome.Properties.Resources.excel1;
            this.simpleButton4.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.simpleButton4.Location = new System.Drawing.Point(890, 563);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Padding = new System.Windows.Forms.Padding(3);
            this.simpleButton4.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton4.Size = new System.Drawing.Size(84, 35);
            this.simpleButton4.TabIndex = 50;
            this.simpleButton4.Text = "&Excel";
            // 
            // grdCol_Quota_Id
            // 
            this.grdCol_Quota_Id.AppearanceCell.Options.UseTextOptions = true;
            this.grdCol_Quota_Id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdCol_Quota_Id.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.grdCol_Quota_Id.AppearanceHeader.Options.UseFont = true;
            this.grdCol_Quota_Id.AppearanceHeader.Options.UseTextOptions = true;
            this.grdCol_Quota_Id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdCol_Quota_Id.Caption = "STT";
            this.grdCol_Quota_Id.DisplayFormat.FormatString = "{0:N0}";
            this.grdCol_Quota_Id.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.grdCol_Quota_Id.FieldName = "Id";
            this.grdCol_Quota_Id.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.grdCol_Quota_Id.MinWidth = 25;
            this.grdCol_Quota_Id.Name = "grdCol_Quota_Id";
            this.grdCol_Quota_Id.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Id", "{0:N0}")});
            this.grdCol_Quota_Id.Visible = true;
            this.grdCol_Quota_Id.VisibleIndex = 0;
            this.grdCol_Quota_Id.Width = 70;
            // 
            // grdCol_Quota_ProductCode
            // 
            this.grdCol_Quota_ProductCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.grdCol_Quota_ProductCode.AppearanceHeader.Options.UseFont = true;
            this.grdCol_Quota_ProductCode.AppearanceHeader.Options.UseTextOptions = true;
            this.grdCol_Quota_ProductCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdCol_Quota_ProductCode.Caption = "Mã SP";
            this.grdCol_Quota_ProductCode.FieldName = "ProductCode";
            this.grdCol_Quota_ProductCode.MinWidth = 25;
            this.grdCol_Quota_ProductCode.Name = "grdCol_Quota_ProductCode";
            this.grdCol_Quota_ProductCode.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.grdCol_Quota_ProductCode.Visible = true;
            this.grdCol_Quota_ProductCode.VisibleIndex = 1;
            this.grdCol_Quota_ProductCode.Width = 233;
            // 
            // grdCol_Quota_ProductName
            // 
            this.grdCol_Quota_ProductName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.grdCol_Quota_ProductName.AppearanceHeader.Options.UseFont = true;
            this.grdCol_Quota_ProductName.AppearanceHeader.Options.UseTextOptions = true;
            this.grdCol_Quota_ProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdCol_Quota_ProductName.Caption = "Tên Sản phẩm";
            this.grdCol_Quota_ProductName.FieldName = "ProductName";
            this.grdCol_Quota_ProductName.MinWidth = 25;
            this.grdCol_Quota_ProductName.Name = "grdCol_Quota_ProductName";
            this.grdCol_Quota_ProductName.Visible = true;
            this.grdCol_Quota_ProductName.VisibleIndex = 3;
            this.grdCol_Quota_ProductName.Width = 707;
            // 
            // grdCol_Quota_SKU
            // 
            this.grdCol_Quota_SKU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.grdCol_Quota_SKU.AppearanceHeader.Options.UseFont = true;
            this.grdCol_Quota_SKU.AppearanceHeader.Options.UseTextOptions = true;
            this.grdCol_Quota_SKU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdCol_Quota_SKU.Caption = "SKU";
            this.grdCol_Quota_SKU.FieldName = "SKU";
            this.grdCol_Quota_SKU.MinWidth = 25;
            this.grdCol_Quota_SKU.Name = "grdCol_Quota_SKU";
            this.grdCol_Quota_SKU.Visible = true;
            this.grdCol_Quota_SKU.VisibleIndex = 2;
            this.grdCol_Quota_SKU.Width = 238;
            // 
            // grdCol_Quota_StartDate
            // 
            this.grdCol_Quota_StartDate.AppearanceCell.Options.UseTextOptions = true;
            this.grdCol_Quota_StartDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdCol_Quota_StartDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.grdCol_Quota_StartDate.AppearanceHeader.Options.UseFont = true;
            this.grdCol_Quota_StartDate.AppearanceHeader.Options.UseTextOptions = true;
            this.grdCol_Quota_StartDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdCol_Quota_StartDate.Caption = "Ngày bắt đầu";
            this.grdCol_Quota_StartDate.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.grdCol_Quota_StartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.grdCol_Quota_StartDate.FieldName = "StartDate";
            this.grdCol_Quota_StartDate.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.grdCol_Quota_StartDate.MinWidth = 25;
            this.grdCol_Quota_StartDate.Name = "grdCol_Quota_StartDate";
            this.grdCol_Quota_StartDate.Visible = true;
            this.grdCol_Quota_StartDate.VisibleIndex = 5;
            this.grdCol_Quota_StartDate.Width = 158;
            // 
            // grdCol_Quota_EndDate
            // 
            this.grdCol_Quota_EndDate.AppearanceCell.Options.UseTextOptions = true;
            this.grdCol_Quota_EndDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdCol_Quota_EndDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.grdCol_Quota_EndDate.AppearanceHeader.Options.UseFont = true;
            this.grdCol_Quota_EndDate.AppearanceHeader.Options.UseTextOptions = true;
            this.grdCol_Quota_EndDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdCol_Quota_EndDate.Caption = "Ngày kết thúc";
            this.grdCol_Quota_EndDate.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.grdCol_Quota_EndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.grdCol_Quota_EndDate.FieldName = "EndDate";
            this.grdCol_Quota_EndDate.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.grdCol_Quota_EndDate.MinWidth = 25;
            this.grdCol_Quota_EndDate.Name = "grdCol_Quota_EndDate";
            this.grdCol_Quota_EndDate.Visible = true;
            this.grdCol_Quota_EndDate.VisibleIndex = 4;
            this.grdCol_Quota_EndDate.Width = 157;
            // 
            // frmST_Quota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1078, 610);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblSKUCategory);
            this.Controls.Add(this.cb_Product);
            this.Controls.Add(this.cb_Model);
            this.Controls.Add(this.lblSKUProduct);
            this.Controls.Add(this.cb_Category);
            this.Controls.Add(this.lblSKUModel);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "frmST_Quota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmST_Quota";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.cb_Product.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Model.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Category.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Material)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Material)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private DevExpress.XtraEditors.LabelControl lblSKUCategory;
        private DevExpress.XtraEditors.LookUpEdit cb_Product;
        private DevExpress.XtraEditors.LookUpEdit cb_Model;
        private DevExpress.XtraEditors.LabelControl lblSKUProduct;
        private DevExpress.XtraEditors.LookUpEdit cb_Category;
        private DevExpress.XtraEditors.LabelControl lblSKUModel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl grd_Product;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_Product;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraGrid.GridControl grd_Material;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_Material;
        private DevExpress.XtraGrid.Columns.GridColumn grdCol_Material_STT;
        private DevExpress.XtraGrid.Columns.GridColumn grdCol_Material_DataCode;
        private DevExpress.XtraGrid.Columns.GridColumn grdCol_Material_DataName;
        private DevExpress.XtraGrid.Columns.GridColumn grdCol_Material_Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn grdCol_Quota_Id;
        private DevExpress.XtraGrid.Columns.GridColumn grdCol_Quota_ProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn grdCol_Quota_SKU;
        private DevExpress.XtraGrid.Columns.GridColumn grdCol_Quota_ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn grdCol_Quota_StartDate;
        private DevExpress.XtraGrid.Columns.GridColumn grdCol_Quota_EndDate;
    }
}