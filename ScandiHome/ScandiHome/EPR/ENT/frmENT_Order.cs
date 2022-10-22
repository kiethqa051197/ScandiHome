using ScandiHome.DAO;
using ScandiHome.Helper;
using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ScandiHome.EPR.ENT
{
    public partial class frmENT_Order : DevExpress.XtraEditors.XtraForm
    {
        public frmENT_Order()
        {
            InitializeComponent();
            
            RefreshData();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void frmENT_Order_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                RefreshData();
            }
        }

        private void RefreshData()
        {
            try
            {
                WaitFormFunc waitForm = new WaitFormFunc();
                waitForm.Show();

                Thread.Sleep(500);

                var result = OrderDAO.Instance.GetAll();
                gc_Data.DataSource = result;

                waitForm.Close(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DataTable ReadExcelFile(string path, string sheetName)
        {
            using (System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection())
            {
                DataTable dt = new DataTable();
                string Import_FileName = path;
                conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1;MAXSCANROWS=0'";

                using (OleDbCommand comm = new OleDbCommand())
                {
                    comm.CommandText = "Select * from [" + sheetName + "$]";
                    comm.Connection = conn;

                    using (OleDbDataAdapter da = new OleDbDataAdapter())
                    {
                        da.SelectCommand = comm;
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public void Do_ImportExcel()
        {
            try
            {
                string mFileName = "";

                this.openFileDlg.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm|All File|*.*";
                DialogResult mDialogResult = openFileDlg.ShowDialog();

                if (mDialogResult == DialogResult.OK)
                {
                    mFileName = openFileDlg.FileName;

                    //List<Student> mListDuplicate = new List<Student>();

                    if (ReadExcelFile(mFileName, "Sheet4") != null)
                    {
                        foreach (DataRow mData in ReadExcelFile(mFileName, "Sheet4").Rows)
                        {
                            //if ((StudentDAO.Instances.GetStudentByID(mData.Item("ID").ToString) == null))
                            //    Do_InsertStudent(mData.Item("ID").ToString, mData.Item("Name").ToString, mData.Item("Gender").ToString, System.Convert.ToInt32(mData.Item("Age").ToString), mData.Item("Address").ToString);
                            //else
                            //{
                            //    var withBlock = mData;
                            //    Student mStudent = new Student(mData.Item("ID").ToString, mData.Item("Name").ToString, mData.Item("Gender").ToString, System.Convert.ToInt32(mData.Item("Age").ToString), mData.Item("Address").ToString);
                            //    mListDuplicate.Add(mStudent);
                            //}
                        }

                        //if (mListDuplicate.Count > 0)
                        //{
                        //    if (MessageBox.Show("[" + mListDuplicate.Count + "] record already exists in database\n" + "Replace all?", "Replace confirm!!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        //    {
                        //        foreach (var mData in mListDuplicate)
                        //            Do_UpdateStudent(mData.ID, mData.Name, mData.Gender, System.Convert.ToInt32(mData.Age), mData.Address);
                        //        goto OnUpdate;
                        //    }
                        //    else
                        //        goto OnUpdate;
                        //}
                    }
                }
                else
                    goto OnUpdate;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                goto OnUpdate;
            }

        OnUpdate:
            ;
            RefreshData();
            return;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Do_ImportExcel();
        }
    }
}