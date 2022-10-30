
namespace ScandiHome.EPR.List
{
    partial class frmLST_Product_Input
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLST_Product_Input));
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblProductName = new DevExpress.XtraEditors.LabelControl();
            this.txtProductName = new DevExpress.XtraEditors.TextEdit();
            this.gc_Color = new DevExpress.XtraGrid.GridControl();
            this.gv_Color = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdCol_Color_STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCol_Color_DataName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_Material = new DevExpress.XtraGrid.GridControl();
            this.gv_Material = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdCol_Material_STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCol_Material_DataName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCol_Material_Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.lblSeries = new DevExpress.XtraEditors.LabelControl();
            this.txtSeries = new DevExpress.XtraEditors.TextEdit();
            this.btn_Add_Model = new DevExpress.XtraEditors.SimpleButton();
            this.lblSKUCategory = new DevExpress.XtraEditors.LabelControl();
            this.cb_Model = new DevExpress.XtraEditors.LookUpEdit();
            this.btn_Add_Category = new DevExpress.XtraEditors.SimpleButton();
            this.cb_Category = new DevExpress.XtraEditors.LookUpEdit();
            this.lblSKUModel = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Material)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Material)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeries.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Model.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Category.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btnCancel.Location = new System.Drawing.Point(809, 413);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(2);
            this.btnCancel.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnCancel.Size = new System.Drawing.Size(68, 28);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Đó&ng";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveClose.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveClose.Appearance.Options.UseFont = true;
            this.btnSaveClose.AutoSize = true;
            this.btnSaveClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSaveClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSaveClose.ImageOptions.SvgImage")));
            this.btnSaveClose.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnSaveClose.Location = new System.Drawing.Point(711, 413);
            this.btnSaveClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Padding = new System.Windows.Forms.Padding(2);
            this.btnSaveClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSaveClose.Size = new System.Drawing.Size(88, 28);
            this.btnSaveClose.TabIndex = 22;
            this.btnSaveClose.Text = "Lưu &đóng";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.AutoSize = true;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(650, 413);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(2);
            this.btnSave.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSave.Size = new System.Drawing.Size(61, 28);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "&Lưu";
            // 
            // lblProductName
            // 
            this.lblProductName.Location = new System.Drawing.Point(22, 277);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(2);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(36, 13);
            this.lblProductName.TabIndex = 30;
            this.lblProductName.Text = "Tên sp:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(62, 271);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Properties.AutoHeight = false;
            this.txtProductName.Size = new System.Drawing.Size(291, 24);
            this.txtProductName.TabIndex = 25;
            this.txtProductName.EditValueChanged += new System.EventHandler(this.txtProductName_EditValueChanged);
            // 
            // gc_Color
            // 
            this.gc_Color.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_Color.Location = new System.Drawing.Point(393, 265);
            this.gc_Color.MainView = this.gv_Color;
            this.gc_Color.Margin = new System.Windows.Forms.Padding(2);
            this.gc_Color.Name = "gc_Color";
            this.gc_Color.Size = new System.Drawing.Size(482, 138);
            this.gc_Color.TabIndex = 41;
            this.gc_Color.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Color});
            // 
            // gv_Color
            // 
            this.gv_Color.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdCol_Color_STT,
            this.grdCol_Color_DataName});
            this.gv_Color.DetailHeight = 280;
            this.gv_Color.GridControl = this.gc_Color;
            this.gv_Color.Name = "gv_Color";
            this.gv_Color.OptionsView.ShowFooter = true;
            this.gv_Color.OptionsView.ShowGroupPanel = false;
            this.gv_Color.OptionsView.ShowViewCaption = true;
            this.gv_Color.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.grdCol_Color_STT, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gv_Color.ViewCaption = "Màu";
            // 
            // grdCol_Color_STT
            // 
            this.grdCol_Color_STT.AppearanceCell.Options.UseTextOptions = true;
            this.grdCol_Color_STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdCol_Color_STT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdCol_Color_STT.AppearanceHeader.Options.UseFont = true;
            this.grdCol_Color_STT.AppearanceHeader.Options.UseTextOptions = true;
            this.grdCol_Color_STT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdCol_Color_STT.Caption = "STT";
            this.grdCol_Color_STT.DisplayFormat.FormatString = "{0:N0}";
            this.grdCol_Color_STT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.grdCol_Color_STT.FieldName = "ID";
            this.grdCol_Color_STT.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.grdCol_Color_STT.MaxWidth = 56;
            this.grdCol_Color_STT.MinWidth = 56;
            this.grdCol_Color_STT.Name = "grdCol_Color_STT";
            this.grdCol_Color_STT.OptionsColumn.ReadOnly = true;
            this.grdCol_Color_STT.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.grdCol_Color_STT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ID", "{0:N0}")});
            this.grdCol_Color_STT.Visible = true;
            this.grdCol_Color_STT.VisibleIndex = 0;
            this.grdCol_Color_STT.Width = 56;
            // 
            // grdCol_Color_DataName
            // 
            this.grdCol_Color_DataName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdCol_Color_DataName.AppearanceHeader.Options.UseFont = true;
            this.grdCol_Color_DataName.AppearanceHeader.Options.UseTextOptions = true;
            this.grdCol_Color_DataName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdCol_Color_DataName.Caption = "Tên màu";
            this.grdCol_Color_DataName.FieldName = "DataName";
            this.grdCol_Color_DataName.MaxWidth = 220;
            this.grdCol_Color_DataName.MinWidth = 160;
            this.grdCol_Color_DataName.Name = "grdCol_Color_DataName";
            this.grdCol_Color_DataName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.grdCol_Color_DataName.OptionsColumn.ReadOnly = true;
            this.grdCol_Color_DataName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.grdCol_Color_DataName.Visible = true;
            this.grdCol_Color_DataName.VisibleIndex = 1;
            this.grdCol_Color_DataName.Width = 220;
            // 
            // gc_Material
            // 
            this.gc_Material.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_Material.Location = new System.Drawing.Point(393, 12);
            this.gc_Material.MainView = this.gv_Material;
            this.gc_Material.Margin = new System.Windows.Forms.Padding(2);
            this.gc_Material.Name = "gc_Material";
            this.gc_Material.Size = new System.Drawing.Size(482, 240);
            this.gc_Material.TabIndex = 41;
            this.gc_Material.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Material});
            // 
            // gv_Material
            // 
            this.gv_Material.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdCol_Material_STT,
            this.grdCol_Material_DataName,
            this.grdCol_Material_Quantity});
            this.gv_Material.DetailHeight = 280;
            this.gv_Material.GridControl = this.gc_Material;
            this.gv_Material.Name = "gv_Material";
            this.gv_Material.OptionsView.ShowFooter = true;
            this.gv_Material.OptionsView.ShowGroupPanel = false;
            this.gv_Material.OptionsView.ShowViewCaption = true;
            this.gv_Material.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.grdCol_Material_STT, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gv_Material.ViewCaption = "Nguyên liệu";
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
            this.grdCol_Material_STT.FieldName = "ID";
            this.grdCol_Material_STT.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.grdCol_Material_STT.MaxWidth = 50;
            this.grdCol_Material_STT.MinWidth = 50;
            this.grdCol_Material_STT.Name = "grdCol_Material_STT";
            this.grdCol_Material_STT.OptionsColumn.ReadOnly = true;
            this.grdCol_Material_STT.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.grdCol_Material_STT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ID", "{0:N0}")});
            this.grdCol_Material_STT.Visible = true;
            this.grdCol_Material_STT.VisibleIndex = 0;
            this.grdCol_Material_STT.Width = 50;
            // 
            // grdCol_Material_DataName
            // 
            this.grdCol_Material_DataName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdCol_Material_DataName.AppearanceHeader.Options.UseFont = true;
            this.grdCol_Material_DataName.AppearanceHeader.Options.UseTextOptions = true;
            this.grdCol_Material_DataName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdCol_Material_DataName.Caption = "Tên nguyên liệu";
            this.grdCol_Material_DataName.FieldName = "ProductMaterialName";
            this.grdCol_Material_DataName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.grdCol_Material_DataName.MaxWidth = 300;
            this.grdCol_Material_DataName.MinWidth = 250;
            this.grdCol_Material_DataName.Name = "grdCol_Material_DataName";
            this.grdCol_Material_DataName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.grdCol_Material_DataName.OptionsColumn.ReadOnly = true;
            this.grdCol_Material_DataName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.grdCol_Material_DataName.Visible = true;
            this.grdCol_Material_DataName.VisibleIndex = 1;
            this.grdCol_Material_DataName.Width = 250;
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
            this.grdCol_Material_Quantity.DisplayFormat.FormatString = "{0:N2}";
            this.grdCol_Material_Quantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.grdCol_Material_Quantity.FieldName = "Quantity";
            this.grdCol_Material_Quantity.MaxWidth = 100;
            this.grdCol_Material_Quantity.MinWidth = 80;
            this.grdCol_Material_Quantity.Name = "grdCol_Material_Quantity";
            this.grdCol_Material_Quantity.Visible = true;
            this.grdCol_Material_Quantity.VisibleIndex = 2;
            this.grdCol_Material_Quantity.Width = 90;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(23, 341);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(35, 13);
            this.lblDescription.TabIndex = 30;
            this.lblDescription.Text = "Ghi chú";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(62, 300);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.AutoHeight = false;
            this.txtDescription.Size = new System.Drawing.Size(292, 97);
            this.txtDescription.TabIndex = 25;
            // 
            // lblSeries
            // 
            this.lblSeries.Location = new System.Drawing.Point(29, 247);
            this.lblSeries.Margin = new System.Windows.Forms.Padding(2);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(29, 13);
            this.lblSeries.TabIndex = 30;
            this.lblSeries.Text = "Series";
            // 
            // txtSeries
            // 
            this.txtSeries.Location = new System.Drawing.Point(62, 242);
            this.txtSeries.Margin = new System.Windows.Forms.Padding(2);
            this.txtSeries.Name = "txtSeries";
            this.txtSeries.Properties.AutoHeight = false;
            this.txtSeries.Size = new System.Drawing.Size(291, 24);
            this.txtSeries.TabIndex = 25;
            // 
            // btn_Add_Model
            // 
            this.btn_Add_Model.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Add_Model.ImageOptions.SvgImage")));
            this.btn_Add_Model.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btn_Add_Model.Location = new System.Drawing.Point(349, 212);
            this.btn_Add_Model.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add_Model.Name = "btn_Add_Model";
            this.btn_Add_Model.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Add_Model.Size = new System.Drawing.Size(26, 24);
            this.btn_Add_Model.TabIndex = 46;
            // 
            // lblSKUCategory
            // 
            this.lblSKUCategory.Location = new System.Drawing.Point(13, 217);
            this.lblSKUCategory.Margin = new System.Windows.Forms.Padding(2);
            this.lblSKUCategory.Name = "lblSKUCategory";
            this.lblSKUCategory.Size = new System.Drawing.Size(45, 13);
            this.lblSKUCategory.TabIndex = 42;
            this.lblSKUCategory.Text = "Category";
            // 
            // cb_Model
            // 
            this.cb_Model.Location = new System.Drawing.Point(239, 212);
            this.cb_Model.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Model.Name = "cb_Model";
            this.cb_Model.Properties.AutoHeight = false;
            this.cb_Model.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_Model.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ModelSKUCode", "ModelSKUCode", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ModelSKUName", "ModelSKUName", 255, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cb_Model.Properties.DisplayMember = "ModelSKUName";
            this.cb_Model.Properties.DropDownRows = 10;
            this.cb_Model.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cb_Model.Properties.ValueMember = "ModelSKUCode";
            this.cb_Model.Size = new System.Drawing.Size(106, 24);
            this.cb_Model.TabIndex = 44;
            // 
            // btn_Add_Category
            // 
            this.btn_Add_Category.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Add_Category.ImageOptions.SvgImage")));
            this.btn_Add_Category.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btn_Add_Category.Location = new System.Drawing.Point(172, 212);
            this.btn_Add_Category.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add_Category.Name = "btn_Add_Category";
            this.btn_Add_Category.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Add_Category.Size = new System.Drawing.Size(26, 24);
            this.btn_Add_Category.TabIndex = 47;
            // 
            // cb_Category
            // 
            this.cb_Category.Location = new System.Drawing.Point(62, 212);
            this.cb_Category.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Properties.AutoHeight = false;
            this.cb_Category.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_Category.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryCode", "CategoryCode", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", "CategoryName", 255, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cb_Category.Properties.DisplayMember = "CategoryName";
            this.cb_Category.Properties.DropDownRows = 10;
            this.cb_Category.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cb_Category.Properties.ValueMember = "CategoryCode";
            this.cb_Category.Size = new System.Drawing.Size(106, 24);
            this.cb_Category.TabIndex = 45;
            // 
            // lblSKUModel
            // 
            this.lblSKUModel.Location = new System.Drawing.Point(207, 217);
            this.lblSKUModel.Margin = new System.Windows.Forms.Padding(2);
            this.lblSKUModel.Name = "lblSKUModel";
            this.lblSKUModel.Size = new System.Drawing.Size(28, 13);
            this.lblSKUModel.TabIndex = 43;
            this.lblSKUModel.Text = "Model";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ScandiHome.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // frmLST_Product_Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(888, 452);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Add_Model);
            this.Controls.Add(this.lblSKUCategory);
            this.Controls.Add(this.cb_Model);
            this.Controls.Add(this.btn_Add_Category);
            this.Controls.Add(this.cb_Category);
            this.Controls.Add(this.lblSKUModel);
            this.Controls.Add(this.gc_Material);
            this.Controls.Add(this.gc_Color);
            this.Controls.Add(this.lblSeries);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtSeries);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSaveClose);
            this.IconOptions.Image = global::ScandiHome.Properties.Resources.logo;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 450);
            this.Name = "frmLST_Product_Input";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Material)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Material)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeries.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Model.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Category.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSaveClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl lblProductName;
        private DevExpress.XtraEditors.TextEdit txtProductName;
        private DevExpress.XtraGrid.GridControl gc_Color;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Color;
        private DevExpress.XtraGrid.Columns.GridColumn grdCol_Color_STT;
        private DevExpress.XtraGrid.Columns.GridColumn grdCol_Color_DataName;
        private DevExpress.XtraGrid.GridControl gc_Material;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Material;
        private DevExpress.XtraGrid.Columns.GridColumn grdCol_Material_STT;
        private DevExpress.XtraGrid.Columns.GridColumn grdCol_Material_DataName;
        private DevExpress.XtraGrid.Columns.GridColumn grdCol_Material_Quantity;
        private DevExpress.XtraEditors.LabelControl lblDescription;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl lblSeries;
        private DevExpress.XtraEditors.TextEdit txtSeries;
        private DevExpress.XtraEditors.SimpleButton btn_Add_Model;
        private DevExpress.XtraEditors.LabelControl lblSKUCategory;
        private DevExpress.XtraEditors.LookUpEdit cb_Model;
        private DevExpress.XtraEditors.SimpleButton btn_Add_Category;
        private DevExpress.XtraEditors.LookUpEdit cb_Category;
        private DevExpress.XtraEditors.LabelControl lblSKUModel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}