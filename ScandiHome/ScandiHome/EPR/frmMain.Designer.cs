
namespace ScandiHome
{
    partial class frmMain
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
            this.mnuStr = new System.Windows.Forms.MenuStrip();
            this.mnu_List = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_product = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_product_new = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Customer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_customer_new = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_price_material = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Func = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_order = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_order_new = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_delivery = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_delivery_new = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_setting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_price = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_sku = new System.Windows.Forms.ToolStripMenuItem();
            this.nu_quota = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_report = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_manufacturing = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_delivery_report = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_statistic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_manufactoring = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Acc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_changePass = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ptr_Order = new DevExpress.XtraEditors.PictureEdit();
            this.ptr_Delivery = new DevExpress.XtraEditors.PictureEdit();
            this.grd_Order = new DevExpress.XtraGrid.GridControl();
            this.grv_Order = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tbl_grid = new System.Windows.Forms.TableLayoutPanel();
            this.grd_progress = new DevExpress.XtraGrid.GridControl();
            this.grv_progress = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mnuStr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_Order.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_Delivery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Order)).BeginInit();
            this.tbl_grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_progress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_progress)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuStr
            // 
            this.mnuStr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStr.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuStr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_List,
            this.mnu_Func,
            this.mnu_setting,
            this.mnu_report,
            this.mnu_statistic,
            this.mnu_Acc});
            this.mnuStr.Location = new System.Drawing.Point(0, 0);
            this.mnuStr.Name = "mnuStr";
            this.mnuStr.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuStr.Size = new System.Drawing.Size(862, 24);
            this.mnuStr.TabIndex = 0;
            this.mnuStr.Text = "menuStrip1";
            // 
            // mnu_List
            // 
            this.mnu_List.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_product,
            this.mnu_product_new,
            this.mnu_Customer,
            this.mnu_customer_new,
            this.mnu_price_material});
            this.mnu_List.Name = "mnu_List";
            this.mnu_List.Size = new System.Drawing.Size(74, 20);
            this.mnu_List.Text = "Danh mục";
            // 
            // mnu_product
            // 
            this.mnu_product.Name = "mnu_product";
            this.mnu_product.Size = new System.Drawing.Size(161, 22);
            this.mnu_product.Text = "Sản phẩm";
            this.mnu_product.Click += new System.EventHandler(this.mnu_product_Click);
            // 
            // mnu_product_new
            // 
            this.mnu_product_new.Name = "mnu_product_new";
            this.mnu_product_new.Size = new System.Drawing.Size(161, 22);
            this.mnu_product_new.Text = "Sản phẩm mới";
            // 
            // mnu_Customer
            // 
            this.mnu_Customer.Name = "mnu_Customer";
            this.mnu_Customer.Size = new System.Drawing.Size(161, 22);
            this.mnu_Customer.Text = "Khách hàng";
            this.mnu_Customer.Click += new System.EventHandler(this.mnu_Customer_Click);
            // 
            // mnu_customer_new
            // 
            this.mnu_customer_new.Name = "mnu_customer_new";
            this.mnu_customer_new.Size = new System.Drawing.Size(161, 22);
            this.mnu_customer_new.Text = "Khách hàng mới";
            // 
            // mnu_price_material
            // 
            this.mnu_price_material.Name = "mnu_price_material";
            this.mnu_price_material.Size = new System.Drawing.Size(161, 22);
            this.mnu_price_material.Text = "Giá nguyên liệu";
            // 
            // mnu_Func
            // 
            this.mnu_Func.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_order,
            this.mnu_order_new,
            this.mnu_delivery,
            this.mnu_delivery_new});
            this.mnu_Func.Name = "mnu_Func";
            this.mnu_Func.Size = new System.Drawing.Size(69, 20);
            this.mnu_Func.Text = "Chứng từ";
            // 
            // mnu_order
            // 
            this.mnu_order.Name = "mnu_order";
            this.mnu_order.Size = new System.Drawing.Size(184, 22);
            this.mnu_order.Text = "Đơn hàng";
            this.mnu_order.Click += new System.EventHandler(this.mnu_order_Click);
            // 
            // mnu_order_new
            // 
            this.mnu_order_new.Name = "mnu_order_new";
            this.mnu_order_new.Size = new System.Drawing.Size(184, 22);
            this.mnu_order_new.Text = "Đơn hàng mới";
            // 
            // mnu_delivery
            // 
            this.mnu_delivery.Name = "mnu_delivery";
            this.mnu_delivery.Size = new System.Drawing.Size(184, 22);
            this.mnu_delivery.Text = "Phiếu giao hàng";
            // 
            // mnu_delivery_new
            // 
            this.mnu_delivery_new.Name = "mnu_delivery_new";
            this.mnu_delivery_new.Size = new System.Drawing.Size(184, 22);
            this.mnu_delivery_new.Text = "Phiếu giao hàng mới";
            // 
            // mnu_setting
            // 
            this.mnu_setting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_price,
            this.mnu_sku,
            this.nu_quota});
            this.mnu_setting.Name = "mnu_setting";
            this.mnu_setting.Size = new System.Drawing.Size(64, 20);
            this.mnu_setting.Text = "Thiết lập";
            // 
            // mnu_price
            // 
            this.mnu_price.Name = "mnu_price";
            this.mnu_price.Size = new System.Drawing.Size(180, 22);
            this.mnu_price.Text = "Giá bán";
            // 
            // mnu_sku
            // 
            this.mnu_sku.Name = "mnu_sku";
            this.mnu_sku.Size = new System.Drawing.Size(180, 22);
            this.mnu_sku.Text = "SKU";
            // 
            // nu_quota
            // 
            this.nu_quota.Name = "nu_quota";
            this.nu_quota.Size = new System.Drawing.Size(180, 22);
            this.nu_quota.Text = "Định mức";
            this.nu_quota.Click += new System.EventHandler(this.nu_quota_Click);
            // 
            // mnu_report
            // 
            this.mnu_report.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_manufacturing,
            this.mnu_delivery_report});
            this.mnu_report.Name = "mnu_report";
            this.mnu_report.Size = new System.Drawing.Size(61, 20);
            this.mnu_report.Text = "Báo cáo";
            // 
            // mnu_manufacturing
            // 
            this.mnu_manufacturing.Name = "mnu_manufacturing";
            this.mnu_manufacturing.Size = new System.Drawing.Size(180, 22);
            this.mnu_manufacturing.Text = "Lịch sản xuất";
            // 
            // mnu_delivery_report
            // 
            this.mnu_delivery_report.Name = "mnu_delivery_report";
            this.mnu_delivery_report.Size = new System.Drawing.Size(180, 22);
            this.mnu_delivery_report.Text = "Phiếu giao hàng";
            // 
            // mnu_statistic
            // 
            this.mnu_statistic.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_manufactoring});
            this.mnu_statistic.Name = "mnu_statistic";
            this.mnu_statistic.Size = new System.Drawing.Size(68, 20);
            this.mnu_statistic.Text = "Thống kê";
            // 
            // mnu_manufactoring
            // 
            this.mnu_manufactoring.Name = "mnu_manufactoring";
            this.mnu_manufactoring.Size = new System.Drawing.Size(171, 22);
            this.mnu_manufactoring.Text = "Quy trình sản xuất";
            // 
            // mnu_Acc
            // 
            this.mnu_Acc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_changePass,
            this.mnu_logout});
            this.mnu_Acc.Name = "mnu_Acc";
            this.mnu_Acc.Size = new System.Drawing.Size(69, 20);
            this.mnu_Acc.Text = "Tài khoản";
            // 
            // mnu_changePass
            // 
            this.mnu_changePass.Image = global::ScandiHome.Properties.Resources.changepass;
            this.mnu_changePass.Name = "mnu_changePass";
            this.mnu_changePass.Size = new System.Drawing.Size(149, 26);
            this.mnu_changePass.Text = "Đổi mật khẩu";
            // 
            // mnu_logout
            // 
            this.mnu_logout.Image = global::ScandiHome.Properties.Resources.logout;
            this.mnu_logout.Name = "mnu_logout";
            this.mnu_logout.Size = new System.Drawing.Size(149, 26);
            this.mnu_logout.Text = "Đăng xuất";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(44, 175);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "DS Đơn hàng";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(226, 175);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(133, 17);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "DS Phiếu giao hàng";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(22, 198);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(138, 17);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Thêm đơn hàng mới";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(221, 198);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(143, 17);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Thêm phiếu giao mới";
            // 
            // ptr_Order
            // 
            this.ptr_Order.EditValue = global::ScandiHome.Properties.Resources.document;
            this.ptr_Order.Location = new System.Drawing.Point(22, 51);
            this.ptr_Order.Margin = new System.Windows.Forms.Padding(2);
            this.ptr_Order.Name = "ptr_Order";
            this.ptr_Order.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ptr_Order.Properties.Appearance.Options.UseBackColor = true;
            this.ptr_Order.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ptr_Order.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ptr_Order.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.ptr_Order.Size = new System.Drawing.Size(126, 119);
            this.ptr_Order.TabIndex = 0;
            // 
            // ptr_Delivery
            // 
            this.ptr_Delivery.EditValue = global::ScandiHome.Properties.Resources.document;
            this.ptr_Delivery.Location = new System.Drawing.Point(226, 51);
            this.ptr_Delivery.Margin = new System.Windows.Forms.Padding(2);
            this.ptr_Delivery.Name = "ptr_Delivery";
            this.ptr_Delivery.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ptr_Delivery.Properties.Appearance.Options.UseBackColor = true;
            this.ptr_Delivery.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ptr_Delivery.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ptr_Delivery.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.ptr_Delivery.Size = new System.Drawing.Size(126, 119);
            this.ptr_Delivery.TabIndex = 3;
            // 
            // grd_Order
            // 
            this.grd_Order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Order.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grd_Order.Location = new System.Drawing.Point(0, 0);
            this.grd_Order.MainView = this.grv_Order;
            this.grd_Order.Margin = new System.Windows.Forms.Padding(0);
            this.grd_Order.Name = "grd_Order";
            this.grd_Order.Size = new System.Drawing.Size(431, 231);
            this.grd_Order.TabIndex = 0;
            this.grd_Order.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_Order});
            // 
            // grv_Order
            // 
            this.grv_Order.DetailHeight = 280;
            this.grv_Order.GridControl = this.grd_Order;
            this.grv_Order.Name = "grv_Order";
            this.grv_Order.OptionsView.ShowGroupPanel = false;
            // 
            // tbl_grid
            // 
            this.tbl_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_grid.ColumnCount = 2;
            this.tbl_grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_grid.Controls.Add(this.grd_progress, 1, 0);
            this.tbl_grid.Controls.Add(this.grd_Order, 0, 0);
            this.tbl_grid.Location = new System.Drawing.Point(0, 257);
            this.tbl_grid.Margin = new System.Windows.Forms.Padding(2);
            this.tbl_grid.Name = "tbl_grid";
            this.tbl_grid.RowCount = 1;
            this.tbl_grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_grid.Size = new System.Drawing.Size(862, 231);
            this.tbl_grid.TabIndex = 1;
            // 
            // grd_progress
            // 
            this.grd_progress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_progress.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grd_progress.Location = new System.Drawing.Point(431, 0);
            this.grd_progress.MainView = this.grv_progress;
            this.grd_progress.Margin = new System.Windows.Forms.Padding(0);
            this.grd_progress.Name = "grd_progress";
            this.grd_progress.Size = new System.Drawing.Size(431, 231);
            this.grd_progress.TabIndex = 1;
            this.grd_progress.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_progress});
            // 
            // grv_progress
            // 
            this.grv_progress.DetailHeight = 280;
            this.grv_progress.GridControl = this.grd_progress;
            this.grv_progress.Name = "grv_progress";
            this.grv_progress.OptionsView.ShowGroupPanel = false;
            // 
            // frmMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(862, 489);
            this.Controls.Add(this.tbl_grid);
            this.Controls.Add(this.ptr_Delivery);
            this.Controls.Add(this.ptr_Order);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.mnuStr);
            this.IconOptions.Image = global::ScandiHome.Properties.Resources.logo;
            this.MainMenuStrip = this.mnuStr;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(800, 521);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuStr.ResumeLayout(false);
            this.mnuStr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_Order.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_Delivery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Order)).EndInit();
            this.tbl_grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_progress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_progress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStr;
        private System.Windows.Forms.ToolStripMenuItem mnu_List;
        private System.Windows.Forms.ToolStripMenuItem mnu_product;
        private System.Windows.Forms.ToolStripMenuItem mnu_product_new;
        private System.Windows.Forms.ToolStripMenuItem mnu_Customer;
        private System.Windows.Forms.ToolStripMenuItem mnu_customer_new;
        private System.Windows.Forms.ToolStripMenuItem mnu_Func;
        private System.Windows.Forms.ToolStripMenuItem mnu_order;
        private System.Windows.Forms.ToolStripMenuItem mnu_order_new;
        private System.Windows.Forms.ToolStripMenuItem mnu_setting;
        private System.Windows.Forms.ToolStripMenuItem mnu_report;
        private System.Windows.Forms.ToolStripMenuItem mnu_statistic;
        private System.Windows.Forms.ToolStripMenuItem mnu_price;
        private System.Windows.Forms.ToolStripMenuItem mnu_manufacturing;
        private System.Windows.Forms.ToolStripMenuItem mnu_delivery_report;
        private System.Windows.Forms.ToolStripMenuItem mnu_manufactoring;
        private System.Windows.Forms.ToolStripMenuItem mnu_sku;
        private System.Windows.Forms.ToolStripMenuItem nu_quota;
        private System.Windows.Forms.ToolStripMenuItem mnu_price_material;
        private System.Windows.Forms.ToolStripMenuItem mnu_delivery;
        private System.Windows.Forms.ToolStripMenuItem mnu_delivery_new;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ToolStripMenuItem mnu_Acc;
        private System.Windows.Forms.ToolStripMenuItem mnu_changePass;
        private System.Windows.Forms.ToolStripMenuItem mnu_logout;
        private DevExpress.XtraEditors.PictureEdit ptr_Order;
        private DevExpress.XtraEditors.PictureEdit ptr_Delivery;
        private DevExpress.XtraGrid.GridControl grd_Order;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_Order;
        private System.Windows.Forms.TableLayoutPanel tbl_grid;
        private DevExpress.XtraGrid.GridControl grd_progress;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_progress;
    }
}