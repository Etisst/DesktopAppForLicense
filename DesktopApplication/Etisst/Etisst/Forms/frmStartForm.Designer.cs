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
            this.mtHome.AutoSize = true;
            this.mtHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.mtHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mtHome.Location = new System.Drawing.Point(0, 0);
            this.mtHome.Name = "mtHome";
            this.mtHome.Size = new System.Drawing.Size(800, 44);
            this.mtHome.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtHome.TabIndex = 9;
            this.mtHome.Text = "Home";
            this.mtHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtHome.UseSelectable = true;
            this.mtHome.Click += new System.EventHandler(this.mtHome_Click);
            // 
            // mtLookups
            // 
            this.mtLookups.ActiveControl = null;
            this.mtLookups.Dock = System.Windows.Forms.DockStyle.Top;
            this.mtLookups.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mtLookups.Location = new System.Drawing.Point(0, 44);
            this.mtLookups.Name = "mtLookups";
            this.mtLookups.Size = new System.Drawing.Size(800, 41);
            this.mtLookups.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtLookups.TabIndex = 10;
            this.mtLookups.Text = "Lookups";
            this.mtLookups.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtLookups.UseSelectable = true;
            this.mtLookups.Click += new System.EventHandler(this.mtLookups_Click);
            // 
            // mtCustomers
            // 
            this.mtCustomers.ActiveControl = null;
            this.mtCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.mtCustomers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mtCustomers.Location = new System.Drawing.Point(0, 85);
            this.mtCustomers.Name = "mtCustomers";
            this.mtCustomers.Size = new System.Drawing.Size(800, 41);
            this.mtCustomers.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtCustomers.TabIndex = 11;
            this.mtCustomers.Text = "Customers";
            this.mtCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCustomers.UseSelectable = true;
            this.mtCustomers.Click += new System.EventHandler(this.mtCustomers_Click);
            // 
            // mtProducts
            // 
            this.mtProducts.ActiveControl = null;
            this.mtProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.mtProducts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mtProducts.Location = new System.Drawing.Point(0, 126);
            this.mtProducts.Name = "mtProducts";
            this.mtProducts.Size = new System.Drawing.Size(800, 41);
            this.mtProducts.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtProducts.TabIndex = 12;
            this.mtProducts.Text = "Products";
            this.mtProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtProducts.UseSelectable = true;
            this.mtProducts.Click += new System.EventHandler(this.mtProducts_Click);
            // 
            // mtOrders
            // 
            this.mtOrders.ActiveControl = null;
            this.mtOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.mtOrders.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mtOrders.Location = new System.Drawing.Point(0, 167);
            this.mtOrders.Name = "mtOrders";
            this.mtOrders.Size = new System.Drawing.Size(800, 41);
            this.mtOrders.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtOrders.TabIndex = 13;
            this.mtOrders.Text = "Orders";
            this.mtOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.mpMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.mpMainMenu.HorizontalScrollbarBarColor = true;
            this.mpMainMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.mpMainMenu.HorizontalScrollbarSize = 10;
            this.mpMainMenu.Location = new System.Drawing.Point(0, 60);
            this.mpMainMenu.Name = "mpMainMenu";
            this.mpMainMenu.Size = new System.Drawing.Size(800, 42);
            this.mpMainMenu.TabIndex = 9;
            this.mpMainMenu.VerticalScrollbarBarColor = true;
            this.mpMainMenu.VerticalScrollbarHighlightOnWheel = false;
            this.mpMainMenu.VerticalScrollbarSize = 10;
            // 
            // frmStartForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mpMainMenu);
            this.IsMdiContainer = true;
            this.Name = "frmStartForm";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.TransparencyKey = System.Drawing.Color.Empty;
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

