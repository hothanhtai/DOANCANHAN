using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANCANHAN_HOTHANHTAI_9057
{
    public class LoadingFormFunction
    {
        LoadingForm loading;
        Thread loadingthread;

        public void Show()
        {
            loadingthread = new Thread(new ThreadStart(WaitingProcess));
            loadingthread.Start();
        }

        public void Show(Form parent)
        {
            loadingthread = new Thread(new ParameterizedThreadStart(WaitingProcess));
            loadingthread.Start(parent);
        }

        public void Close()
        {
            if (loading!=null)
            {
                loading.BeginInvoke(new System.Threading.ThreadStart(loading.CloseLoadingForm));
                loading = null;
                loadingthread = null;

            }
        }

        private void WaitingProcess()
        {
            loading = new LoadingForm();
            loading.ShowDialog();
        }

        private void WaitingProcess(object parent)
        {
            Form parent1 = parent as Form;
            loading = new LoadingForm(parent1);
            loading.ShowDialog();
        }
    }
}
