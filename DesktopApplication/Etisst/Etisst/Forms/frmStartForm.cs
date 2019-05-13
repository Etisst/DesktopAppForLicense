using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etisst
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            mpMainMenu.MouseClick += MpMainMenu_MouseClick;
        }

        #region Events
        private void MpMainMenu_MouseClick(object sender, MouseEventArgs e)
        {
            this.mpMainMenu.AutoSize = true;
        }

        private void mtHome_Click(object sender, EventArgs e)
        {

            this.mpMainMenu.AutoSize = true;
            this.mtHome.TabIndex = 2;
        }
        #endregion
    }
}
