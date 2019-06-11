using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etisst
{
    public class frmBaseForm : MetroFramework.Forms.MetroForm
    {
        #region delegates

        protected void ShowChildForm(object sender, ShowTabFormEventArgs e)
        {
            e.MetFrm.Dock = DockStyle.Fill;
            e.MetFrm.MaximizeBox = false;
            e.MetFrm.MinimizeBox = false;
            e.MetFrm.ShowInTaskbar = false;
            e.MetFrm.Show();
        }

        protected delegate void ShowTabFormEventHandler(object sender, ShowTabFormEventArgs e);

        protected class ShowTabFormEventArgs : EventArgs
        {
            public MetroFramework.Forms.MetroForm MetFrm { get; set; }

            public ShowTabFormEventArgs(MetroFramework.Forms.MetroForm metFrm)
            {
                this.MetFrm = metFrm;
            }
        }

        #endregion
    }
}
