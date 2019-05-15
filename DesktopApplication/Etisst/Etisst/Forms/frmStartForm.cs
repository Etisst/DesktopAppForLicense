using Etisst.Desktop.BusinessLogic.UIConnector;
using System;
using System.Windows.Forms;

namespace Etisst
{
    public partial class frmStartForm : MetroFramework.Forms.MetroForm, IStartFormView
    {
        
        public frmStartForm()
        {
            InitializeComponent();
            
        }

        public void AttachPresenter(StartFormPresenter presenter)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        #region Events

        private void mtHome_Click(object sender, EventArgs e)
        {
            this.mpMainMenu.AutoSize = !this.mpMainMenu.AutoSize;
        }

        private void mtLookups_Click(object sender, EventArgs e)
        {
            this.mpMainMenu.AutoSize = false;

            ShowChildForm(sender, new ShowTabFormEventArgs(new frmLookups()));
        }
        #endregion

        private void ShowChildForm(object sender, ShowTabFormEventArgs e)
        {
            e.MetFrm.MdiParent = this;
            e.MetFrm.Show();
        }

        public delegate void ShowTabFormEventHandler(object sender, ShowTabFormEventArgs e);

        public class ShowTabFormEventArgs : EventArgs
        {
            public MetroFramework.Forms.MetroForm MetFrm { get; set; }

            public ShowTabFormEventArgs(MetroFramework.Forms.MetroForm metFrm)
            {
                this.MetFrm = metFrm;
            }
        }

    }
}
