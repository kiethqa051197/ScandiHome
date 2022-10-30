using ScandiHome.SystemERP;
using System.Data;
using System.Threading;

namespace ScandiHome.Helper
{
    class WaitFormFunc
    {
        frm_Waiting wait;
        Thread loadthread;

        public void Show()
        {
            loadthread = new Thread(new ThreadStart(LoadingProcess));
            loadthread.Start();
        }

        public void Close(DataTable dataTable)
        {
            if (dataTable != null)
            {
                wait.BeginInvoke(new System.Threading.ThreadStart(wait.CloseWaitForm));
                wait = null;
                loadthread = null;
            }
        }

        private void LoadingProcess()
        {
            wait = new frm_Waiting();
            wait.ShowDialog();
        }
    }
}
