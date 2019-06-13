namespace Etisst
{
    partial class frmStartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartForm));
            this.mtHome = new MetroFramework.Controls.MetroTile();
            this.mtLookups = new MetroFramework.Controls.MetroTile();
            this.mtCustomers = new MetroFramework.Controls.MetroTile();
            this.mtProducts = new MetroFramework.Controls.MetroTile();
            this.mtOrders = new MetroFramework.Controls.MetroTile();
            this.mpMainMenu = new MetroFramework.Controls.MetroPanel();
            this.mpMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtHome
            // 
            this.mtHome.ActiveControl = null;
            resources.ApplyResources(this.mtHome, "mtHome");
            this.mtHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mtHome.Name = "mtHome";
            this.mtHome.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtHome.UseSelectable = true;
            this.mtHome.Click += new System.EventHandler(this.mtHome_Click);
            // 
            // mtLookups
            // 
            this.mtLookups.ActiveControl = null;
            resources.ApplyResources(this.mtLookups, "mtLookups");
            this.mtLookups.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mtLookups.Name = "mtLookups";
            this.mtLookups.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtLookups.UseSelectable = true;
            this.mtLookups.Click += new System.EventHandler(this.mtLookups_Click);
            // 
            // mtCustomers
            // 
            this.mtCustomers.ActiveControl = null;
            resources.ApplyResources(this.mtCustomers, "mtCustomers");
            this.mtCustomers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mtCustomers.Name = "mtCustomers";
            this.mtCustomers.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtCustomers.UseSelectable = true;
            this.mtCustomers.Click += new System.EventHandler(this.mtCustomers_Click);
            // 
            // mtProducts
            // 
            this.mtProducts.ActiveControl = null;
            resources.ApplyResources(this.mtProducts, "mtProducts");
            this.mtProducts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mtProducts.Name = "mtProducts";
            this.mtProducts.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtProducts.UseSelectable = true;
            this.mtProducts.Click += new System.EventHandler(this.mtProducts_Click);
            // 
            // mtOrders
            // 
            this.mtOrders.ActiveControl = null;
            resources.ApplyResources(this.mtOrders, "mtOrders");
            this.mtOrders.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mtOrders.Name = "mtOrders";
            this.mtOrders.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtOrders.UseSelectable = true;
            this.mtOrders.Click += new System.EventHandler(this.mtOrders_Click);
            // 
            // mpMainMenu
            // 
            this.mpMainMenu.Controls.Add(this.mtOrders);
            this.mpMainMenu.Controls.Add(this.mtProducts);
            this.mpMainMenu.Controls.Add(this.mtCustomers);
            this.mpMainMenu.Controls.Add(this.mtLookups);
            this.mpMainMenu.Controls.Add(this.mtHome);
            resources.ApplyResources(this.mpMainMenu, "mpMainMenu");
            this.mpMainMenu.HorizontalScrollbarBarColor = true;
            this.mpMainMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.mpMainMenu.HorizontalScrollbarSize = 10;
            this.mpMainMenu.Name = "mpMainMenu";
            this.mpMainMenu.VerticalScrollbarBarColor = true;
            this.mpMainMenu.VerticalScrollbarHighlightOnWheel = false;
            this.mpMainMenu.VerticalScrollbarSize = 10;
            // 
            // frmStartForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.mpMainMenu);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "frmStartForm";
            this.Resizable = false;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStartForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mpMainMenu.ResumeLayout(false);
            this.mpMainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile mtHome;
        private MetroFramework.Controls.MetroTile mtLookups;
        private MetroFramework.Controls.MetroTile mtCustomers;
        private MetroFramework.Controls.MetroTile mtProducts;
        private MetroFramework.Controls.MetroTile mtOrders;
        private MetroFramework.Controls.MetroPanel mpMainMenu;
    }
}

