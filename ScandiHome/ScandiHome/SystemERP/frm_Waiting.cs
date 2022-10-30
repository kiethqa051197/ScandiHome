namespace ScandiHome.SystemERP
{
    public partial class frm_Waiting : DevExpress.XtraEditors.XtraForm
    {
        public frm_Waiting()
        {
            InitializeComponent();
        }

        public frm_Waiting(string pCaption, string pDesc)
        {
            InitializeComponent();
            lblCaption.Text = pCaption;
            lblDesc.Text = pDesc;
        }

        public void CloseWaitForm()
        {
            this.Close();
        }
    }
}