namespace Etisst
{
    partial class frmOrderDetails
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
            this.panelMenu = new MetroFramework.Controls.MetroPanel();
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.mtbDateModified = new MetroFramework.Controls.MetroTextBox();
            this.mtbDateCreated = new MetroFramework.Controls.MetroTextBox();
            this.mtbDateCompleted = new MetroFramework.Controls.MetroTextBox();
            this.mtbDatePaid = new MetroFramework.Controls.MetroTextBox();
            this.rtbCustomerNote = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.mtbStatus = new MetroFramework.Controls.MetroTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mtbCreatedVia = new MetroFramework.Controls.MetroTextBox();
            this.mtbCustomer = new MetroFramework.Controls.MetroTextBox();
            this.mtbCustomerIP = new MetroFramework.Controls.MetroTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mtbOrderKey = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGeneralPanel = new System.Windows.Forms.Button();
            this.panelProducts = new System.Windows.Forms.Panel();
            this.mtbShippingMethod = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mtbShippingCost = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtbTotalPrice = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbTotalTax = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProductsPanel = new System.Windows.Forms.Button();
            this.panelBillingDetails = new System.Windows.Forms.Panel();
            this.mtbStateBilling = new MetroFramework.Controls.MetroTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.mtbPostcodeBilling = new MetroFramework.Controls.MetroTextBox();
            this.mtbLastNameBilling = new MetroFramework.Controls.MetroTextBox();
            this.mtbPhoneBilling = new MetroFramework.Controls.MetroTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.rtbAddressBilling = new System.Windows.Forms.RichTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.mtbFirstNameBilling = new MetroFramework.Controls.MetroTextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.mtbEmailBilling = new MetroFramework.Controls.MetroTextBox();
            this.mtbCompanyBilling = new MetroFramework.Controls.MetroTextBox();
            this.mtbCountryBilling = new MetroFramework.Controls.MetroTextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.mtbCityBilling = new MetroFramework.Controls.MetroTextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.btnBillingDetailsPanel = new System.Windows.Forms.Button();
            this.panelShippingDetails = new System.Windows.Forms.Panel();
            this.mtbStateShipping = new MetroFramework.Controls.MetroTextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.mtbPostcodeShipping = new MetroFramework.Controls.MetroTextBox();
            this.mtbLastNameShipping = new MetroFramework.Controls.MetroTextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.rtbAddressShipping = new System.Windows.Forms.RichTextBox();
            this.Address = new System.Windows.Forms.Label();
            this.mtbFirstNameShipping = new MetroFramework.Controls.MetroTextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.mtbCompanyShipping = new MetroFramework.Controls.MetroTextBox();
            this.mtbCountryShipping = new MetroFramework.Controls.MetroTextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.mtbCityShipping = new MetroFramework.Controls.MetroTextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.btnShippingDetailsPanel = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.gbActions.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            this.panelProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panelBillingDetails.SuspendLayout();
            this.panelShippingDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.gbActions);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.HorizontalScrollbarBarColor = true;
            this.panelMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.panelMenu.HorizontalScrollbarSize = 12;
            this.panelMenu.Location = new System.Drawing.Point(20, 60);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1165, 118);
            this.panelMenu.TabIndex = 19;
            this.panelMenu.VerticalScrollbarBarColor = true;
            this.panelMenu.VerticalScrollbarHighlightOnWheel = false;
            this.panelMenu.VerticalScrollbarSize = 13;
            // 
            // gbActions
            // 
            this.gbActions.Controls.Add(this.btnReject);
            this.gbActions.Controls.Add(this.btnConfirm);
            this.gbActions.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbActions.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbActions.Location = new System.Drawing.Point(0, 0);
            this.gbActions.Margin = new System.Windows.Forms.Padding(4);
            this.gbActions.Name = "gbActions";
            this.gbActions.Padding = new System.Windows.Forms.Padding(4);
            this.gbActions.Size = new System.Drawing.Size(337, 118);
            this.gbActions.TabIndex = 3;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Actions";
            // 
            // btnReject
            // 
            this.btnReject.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnReject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.Image = global::Etisst.Properties.Resources.RejectOrder;
            this.btnReject.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReject.Location = new System.Drawing.Point(172, 18);
            this.btnReject.Margin = new System.Windows.Forms.Padding(4);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(147, 92);
            this.btnReject.TabIndex = 4;
            this.btnReject.Text = "Reject";
            this.btnReject.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Image = global::Etisst.Properties.Resources.ConfirmOrder;
            this.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfirm.Location = new System.Drawing.Point(6, 18);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(168, 92);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Complet";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // panelGeneral
            // 
            this.panelGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelGeneral.Controls.Add(this.mtbDateModified);
            this.panelGeneral.Controls.Add(this.mtbDateCreated);
            this.panelGeneral.Controls.Add(this.mtbDateCompleted);
            this.panelGeneral.Controls.Add(this.mtbDatePaid);
            this.panelGeneral.Controls.Add(this.rtbCustomerNote);
            this.panelGeneral.Controls.Add(this.label14);
            this.panelGeneral.Controls.Add(this.label12);
            this.panelGeneral.Controls.Add(this.label13);
            this.panelGeneral.Controls.Add(this.mtbStatus);
            this.panelGeneral.Controls.Add(this.label11);
            this.panelGeneral.Controls.Add(this.mtbCreatedVia);
            this.panelGeneral.Controls.Add(this.mtbCustomer);
            this.panelGeneral.Controls.Add(this.mtbCustomerIP);
            this.panelGeneral.Controls.Add(this.label10);
            this.panelGeneral.Controls.Add(this.label9);
            this.panelGeneral.Controls.Add(this.mtbOrderKey);
            this.panelGeneral.Controls.Add(this.label7);
            this.panelGeneral.Controls.Add(this.label5);
            this.panelGeneral.Controls.Add(this.label4);
            this.panelGeneral.Controls.Add(this.label1);
            this.panelGeneral.Controls.Add(this.btnGeneralPanel);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGeneral.Location = new System.Drawing.Point(20, 178);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(1165, 35);
            this.panelGeneral.TabIndex = 21;
            // 
            // mtbDateModified
            // 
            this.mtbDateModified.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            // 
            // 
            // 
            this.mtbDateModified.CustomButton.Image = null;
            this.mtbDateModified.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbDateModified.CustomButton.Name = "";
            this.mtbDateModified.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbDateModified.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbDateModified.CustomButton.TabIndex = 1;
            this.mtbDateModified.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbDateModified.CustomButton.UseSelectable = true;
            this.mtbDateModified.CustomButton.Visible = false;
            this.mtbDateModified.Lines = new string[0];
            this.mtbDateModified.Location = new System.Drawing.Point(302, 152);
            this.mtbDateModified.MaxLength = 32767;
            this.mtbDateModified.Name = "mtbDateModified";
            this.mtbDateModified.PasswordChar = '\0';
            this.mtbDateModified.ReadOnly = true;
            this.mtbDateModified.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbDateModified.SelectedText = "";
            this.mtbDateModified.SelectionLength = 0;
            this.mtbDateModified.SelectionStart = 0;
            this.mtbDateModified.ShortcutsEnabled = true;
            this.mtbDateModified.Size = new System.Drawing.Size(350, 30);
            this.mtbDateModified.TabIndex = 53;
            this.mtbDateModified.UseSelectable = true;
            this.mtbDateModified.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbDateModified.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbDateCreated
            // 
            this.mtbDateCreated.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            // 
            // 
            // 
            this.mtbDateCreated.CustomButton.Image = null;
            this.mtbDateCreated.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbDateCreated.CustomButton.Name = "";
            this.mtbDateCreated.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbDateCreated.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbDateCreated.CustomButton.TabIndex = 1;
            this.mtbDateCreated.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbDateCreated.CustomButton.UseSelectable = true;
            this.mtbDateCreated.CustomButton.Visible = false;
            this.mtbDateCreated.Lines = new string[0];
            this.mtbDateCreated.Location = new System.Drawing.Point(302, 112);
            this.mtbDateCreated.MaxLength = 32767;
            this.mtbDateCreated.Name = "mtbDateCreated";
            this.mtbDateCreated.PasswordChar = '\0';
            this.mtbDateCreated.ReadOnly = true;
            this.mtbDateCreated.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbDateCreated.SelectedText = "";
            this.mtbDateCreated.SelectionLength = 0;
            this.mtbDateCreated.SelectionStart = 0;
            this.mtbDateCreated.ShortcutsEnabled = true;
            this.mtbDateCreated.Size = new System.Drawing.Size(350, 30);
            this.mtbDateCreated.TabIndex = 52;
            this.mtbDateCreated.UseSelectable = true;
            this.mtbDateCreated.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbDateCreated.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbDateCompleted
            // 
            this.mtbDateCompleted.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            // 
            // 
            // 
            this.mtbDateCompleted.CustomButton.Image = null;
            this.mtbDateCompleted.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbDateCompleted.CustomButton.Name = "";
            this.mtbDateCompleted.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbDateCompleted.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbDateCompleted.CustomButton.TabIndex = 1;
            this.mtbDateCompleted.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbDateCompleted.CustomButton.UseSelectable = true;
            this.mtbDateCompleted.CustomButton.Visible = false;
            this.mtbDateCompleted.Lines = new string[0];
            this.mtbDateCompleted.Location = new System.Drawing.Point(302, 316);
            this.mtbDateCompleted.MaxLength = 32767;
            this.mtbDateCompleted.Name = "mtbDateCompleted";
            this.mtbDateCompleted.PasswordChar = '\0';
            this.mtbDateCompleted.ReadOnly = true;
            this.mtbDateCompleted.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbDateCompleted.SelectedText = "";
            this.mtbDateCompleted.SelectionLength = 0;
            this.mtbDateCompleted.SelectionStart = 0;
            this.mtbDateCompleted.ShortcutsEnabled = true;
            this.mtbDateCompleted.Size = new System.Drawing.Size(350, 30);
            this.mtbDateCompleted.TabIndex = 51;
            this.mtbDateCompleted.UseSelectable = true;
            this.mtbDateCompleted.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbDateCompleted.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbDatePaid
            // 
            this.mtbDatePaid.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            // 
            // 
            // 
            this.mtbDatePaid.CustomButton.Image = null;
            this.mtbDatePaid.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbDatePaid.CustomButton.Name = "";
            this.mtbDatePaid.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbDatePaid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbDatePaid.CustomButton.TabIndex = 1;
            this.mtbDatePaid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbDatePaid.CustomButton.UseSelectable = true;
            this.mtbDatePaid.CustomButton.Visible = false;
            this.mtbDatePaid.Lines = new string[0];
            this.mtbDatePaid.Location = new System.Drawing.Point(302, 276);
            this.mtbDatePaid.MaxLength = 32767;
            this.mtbDatePaid.Name = "mtbDatePaid";
            this.mtbDatePaid.PasswordChar = '\0';
            this.mtbDatePaid.ReadOnly = true;
            this.mtbDatePaid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbDatePaid.SelectedText = "";
            this.mtbDatePaid.SelectionLength = 0;
            this.mtbDatePaid.SelectionStart = 0;
            this.mtbDatePaid.ShortcutsEnabled = true;
            this.mtbDatePaid.Size = new System.Drawing.Size(350, 30);
            this.mtbDatePaid.TabIndex = 50;
            this.mtbDatePaid.UseSelectable = true;
            this.mtbDatePaid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbDatePaid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rtbCustomerNote
            // 
            this.rtbCustomerNote.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rtbCustomerNote.Location = new System.Drawing.Point(302, 443);
            this.rtbCustomerNote.Name = "rtbCustomerNote";
            this.rtbCustomerNote.ReadOnly = true;
            this.rtbCustomerNote.Size = new System.Drawing.Size(1000, 78);
            this.rtbCustomerNote.TabIndex = 49;
            this.rtbCustomerNote.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 443);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 24);
            this.label14.TabIndex = 48;
            this.label14.Text = "Customer note:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 276);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 24);
            this.label12.TabIndex = 33;
            this.label12.Text = "Date paid:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 316);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 24);
            this.label13.TabIndex = 32;
            this.label13.Text = "Date completed:";
            // 
            // mtbStatus
            // 
            this.mtbStatus.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            // 
            // 
            // 
            this.mtbStatus.CustomButton.Image = null;
            this.mtbStatus.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbStatus.CustomButton.Name = "";
            this.mtbStatus.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbStatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbStatus.CustomButton.TabIndex = 1;
            this.mtbStatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbStatus.CustomButton.UseSelectable = true;
            this.mtbStatus.CustomButton.Visible = false;
            this.mtbStatus.Lines = new string[0];
            this.mtbStatus.Location = new System.Drawing.Point(302, 235);
            this.mtbStatus.MaxLength = 32767;
            this.mtbStatus.Name = "mtbStatus";
            this.mtbStatus.PasswordChar = '\0';
            this.mtbStatus.ReadOnly = true;
            this.mtbStatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbStatus.SelectedText = "";
            this.mtbStatus.SelectionLength = 0;
            this.mtbStatus.SelectionStart = 0;
            this.mtbStatus.ShortcutsEnabled = true;
            this.mtbStatus.Size = new System.Drawing.Size(350, 30);
            this.mtbStatus.TabIndex = 31;
            this.mtbStatus.UseSelectable = true;
            this.mtbStatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbStatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 24);
            this.label11.TabIndex = 30;
            this.label11.Text = "Status:";
            // 
            // mtbCreatedVia
            // 
            this.mtbCreatedVia.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            // 
            // 
            // 
            this.mtbCreatedVia.CustomButton.Image = null;
            this.mtbCreatedVia.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbCreatedVia.CustomButton.Name = "";
            this.mtbCreatedVia.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbCreatedVia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbCreatedVia.CustomButton.TabIndex = 1;
            this.mtbCreatedVia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbCreatedVia.CustomButton.UseSelectable = true;
            this.mtbCreatedVia.CustomButton.Visible = false;
            this.mtbCreatedVia.Lines = new string[0];
            this.mtbCreatedVia.Location = new System.Drawing.Point(302, 195);
            this.mtbCreatedVia.MaxLength = 32767;
            this.mtbCreatedVia.Name = "mtbCreatedVia";
            this.mtbCreatedVia.PasswordChar = '\0';
            this.mtbCreatedVia.ReadOnly = true;
            this.mtbCreatedVia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbCreatedVia.SelectedText = "";
            this.mtbCreatedVia.SelectionLength = 0;
            this.mtbCreatedVia.SelectionStart = 0;
            this.mtbCreatedVia.ShortcutsEnabled = true;
            this.mtbCreatedVia.Size = new System.Drawing.Size(350, 30);
            this.mtbCreatedVia.TabIndex = 29;
            this.mtbCreatedVia.UseSelectable = true;
            this.mtbCreatedVia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbCreatedVia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbCustomer
            // 
            this.mtbCustomer.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            // 
            // 
            // 
            this.mtbCustomer.CustomButton.Image = null;
            this.mtbCustomer.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbCustomer.CustomButton.Name = "";
            this.mtbCustomer.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbCustomer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbCustomer.CustomButton.TabIndex = 1;
            this.mtbCustomer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbCustomer.CustomButton.UseSelectable = true;
            this.mtbCustomer.CustomButton.Visible = false;
            this.mtbCustomer.Lines = new string[0];
            this.mtbCustomer.Location = new System.Drawing.Point(302, 358);
            this.mtbCustomer.MaxLength = 32767;
            this.mtbCustomer.Name = "mtbCustomer";
            this.mtbCustomer.PasswordChar = '\0';
            this.mtbCustomer.ReadOnly = true;
            this.mtbCustomer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbCustomer.SelectedText = "";
            this.mtbCustomer.SelectionLength = 0;
            this.mtbCustomer.SelectionStart = 0;
            this.mtbCustomer.ShortcutsEnabled = true;
            this.mtbCustomer.Size = new System.Drawing.Size(350, 30);
            this.mtbCustomer.TabIndex = 28;
            this.mtbCustomer.UseSelectable = true;
            this.mtbCustomer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbCustomer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbCustomerIP
            // 
            this.mtbCustomerIP.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            // 
            // 
            // 
            this.mtbCustomerIP.CustomButton.Image = null;
            this.mtbCustomerIP.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbCustomerIP.CustomButton.Name = "";
            this.mtbCustomerIP.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbCustomerIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbCustomerIP.CustomButton.TabIndex = 1;
            this.mtbCustomerIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbCustomerIP.CustomButton.UseSelectable = true;
            this.mtbCustomerIP.CustomButton.Visible = false;
            this.mtbCustomerIP.Lines = new string[0];
            this.mtbCustomerIP.Location = new System.Drawing.Point(302, 398);
            this.mtbCustomerIP.MaxLength = 32767;
            this.mtbCustomerIP.Name = "mtbCustomerIP";
            this.mtbCustomerIP.PasswordChar = '\0';
            this.mtbCustomerIP.ReadOnly = true;
            this.mtbCustomerIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbCustomerIP.SelectedText = "";
            this.mtbCustomerIP.SelectionLength = 0;
            this.mtbCustomerIP.SelectionStart = 0;
            this.mtbCustomerIP.ShortcutsEnabled = true;
            this.mtbCustomerIP.Size = new System.Drawing.Size(350, 30);
            this.mtbCustomerIP.TabIndex = 27;
            this.mtbCustomerIP.UseSelectable = true;
            this.mtbCustomerIP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbCustomerIP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 24);
            this.label10.TabIndex = 26;
            this.label10.Text = "Customer:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 398);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 24);
            this.label9.TabIndex = 25;
            this.label9.Text = "Customer IP:";
            // 
            // mtbOrderKey
            // 
            this.mtbOrderKey.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            // 
            // 
            // 
            this.mtbOrderKey.CustomButton.Image = null;
            this.mtbOrderKey.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbOrderKey.CustomButton.Name = "";
            this.mtbOrderKey.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbOrderKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbOrderKey.CustomButton.TabIndex = 1;
            this.mtbOrderKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbOrderKey.CustomButton.UseSelectable = true;
            this.mtbOrderKey.CustomButton.Visible = false;
            this.mtbOrderKey.Lines = new string[0];
            this.mtbOrderKey.Location = new System.Drawing.Point(302, 72);
            this.mtbOrderKey.MaxLength = 32767;
            this.mtbOrderKey.Name = "mtbOrderKey";
            this.mtbOrderKey.PasswordChar = '\0';
            this.mtbOrderKey.ReadOnly = true;
            this.mtbOrderKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbOrderKey.SelectedText = "";
            this.mtbOrderKey.SelectionLength = 0;
            this.mtbOrderKey.SelectionStart = 0;
            this.mtbOrderKey.ShortcutsEnabled = true;
            this.mtbOrderKey.Size = new System.Drawing.Size(350, 30);
            this.mtbOrderKey.TabIndex = 15;
            this.mtbOrderKey.UseSelectable = true;
            this.mtbOrderKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbOrderKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Created via:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date created:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date modified:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Order key:";
            // 
            // btnGeneralPanel
            // 
            this.btnGeneralPanel.BackColor = System.Drawing.Color.Navy;
            this.btnGeneralPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeneralPanel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGeneralPanel.FlatAppearance.BorderSize = 5;
            this.btnGeneralPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeneralPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneralPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGeneralPanel.Location = new System.Drawing.Point(0, 0);
            this.btnGeneralPanel.Name = "btnGeneralPanel";
            this.btnGeneralPanel.Size = new System.Drawing.Size(1165, 35);
            this.btnGeneralPanel.TabIndex = 3;
            this.btnGeneralPanel.Text = "General panel";
            this.btnGeneralPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneralPanel.UseVisualStyleBackColor = false;
            this.btnGeneralPanel.Click += new System.EventHandler(this.btnGeneralPanel_Click);
            // 
            // panelProducts
            // 
            this.panelProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelProducts.Controls.Add(this.mtbShippingMethod);
            this.panelProducts.Controls.Add(this.label8);
            this.panelProducts.Controls.Add(this.mtbShippingCost);
            this.panelProducts.Controls.Add(this.label6);
            this.panelProducts.Controls.Add(this.mtbTotalPrice);
            this.panelProducts.Controls.Add(this.label2);
            this.panelProducts.Controls.Add(this.mtbTotalTax);
            this.panelProducts.Controls.Add(this.label3);
            this.panelProducts.Controls.Add(this.dgvProducts);
            this.panelProducts.Controls.Add(this.btnProductsPanel);
            this.panelProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProducts.Location = new System.Drawing.Point(20, 213);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(1165, 496);
            this.panelProducts.TabIndex = 22;
            // 
            // mtbShippingMethod
            // 
            // 
            // 
            // 
            this.mtbShippingMethod.CustomButton.Image = null;
            this.mtbShippingMethod.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbShippingMethod.CustomButton.Name = "";
            this.mtbShippingMethod.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbShippingMethod.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbShippingMethod.CustomButton.TabIndex = 1;
            this.mtbShippingMethod.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbShippingMethod.CustomButton.UseSelectable = true;
            this.mtbShippingMethod.CustomButton.Visible = false;
            this.mtbShippingMethod.Lines = new string[0];
            this.mtbShippingMethod.Location = new System.Drawing.Point(303, 323);
            this.mtbShippingMethod.MaxLength = 32767;
            this.mtbShippingMethod.Name = "mtbShippingMethod";
            this.mtbShippingMethod.PasswordChar = '\0';
            this.mtbShippingMethod.ReadOnly = true;
            this.mtbShippingMethod.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbShippingMethod.SelectedText = "";
            this.mtbShippingMethod.SelectionLength = 0;
            this.mtbShippingMethod.SelectionStart = 0;
            this.mtbShippingMethod.ShortcutsEnabled = true;
            this.mtbShippingMethod.Size = new System.Drawing.Size(350, 30);
            this.mtbShippingMethod.TabIndex = 39;
            this.mtbShippingMethod.UseSelectable = true;
            this.mtbShippingMethod.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbShippingMethod.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 24);
            this.label8.TabIndex = 38;
            this.label8.Text = "Shipping method:";
            // 
            // mtbShippingCost
            // 
            // 
            // 
            // 
            this.mtbShippingCost.CustomButton.Image = null;
            this.mtbShippingCost.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbShippingCost.CustomButton.Name = "";
            this.mtbShippingCost.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbShippingCost.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbShippingCost.CustomButton.TabIndex = 1;
            this.mtbShippingCost.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbShippingCost.CustomButton.UseSelectable = true;
            this.mtbShippingCost.CustomButton.Visible = false;
            this.mtbShippingCost.Lines = new string[0];
            this.mtbShippingCost.Location = new System.Drawing.Point(303, 363);
            this.mtbShippingCost.MaxLength = 32767;
            this.mtbShippingCost.Name = "mtbShippingCost";
            this.mtbShippingCost.PasswordChar = '\0';
            this.mtbShippingCost.ReadOnly = true;
            this.mtbShippingCost.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbShippingCost.SelectedText = "";
            this.mtbShippingCost.SelectionLength = 0;
            this.mtbShippingCost.SelectionStart = 0;
            this.mtbShippingCost.ShortcutsEnabled = true;
            this.mtbShippingCost.Size = new System.Drawing.Size(350, 30);
            this.mtbShippingCost.TabIndex = 37;
            this.mtbShippingCost.UseSelectable = true;
            this.mtbShippingCost.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbShippingCost.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 24);
            this.label6.TabIndex = 36;
            this.label6.Text = "Shipping cost:";
            // 
            // mtbTotalPrice
            // 
            // 
            // 
            // 
            this.mtbTotalPrice.CustomButton.Image = null;
            this.mtbTotalPrice.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbTotalPrice.CustomButton.Name = "";
            this.mtbTotalPrice.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbTotalPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbTotalPrice.CustomButton.TabIndex = 1;
            this.mtbTotalPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbTotalPrice.CustomButton.UseSelectable = true;
            this.mtbTotalPrice.CustomButton.Visible = false;
            this.mtbTotalPrice.Lines = new string[0];
            this.mtbTotalPrice.Location = new System.Drawing.Point(303, 443);
            this.mtbTotalPrice.MaxLength = 32767;
            this.mtbTotalPrice.Name = "mtbTotalPrice";
            this.mtbTotalPrice.PasswordChar = '\0';
            this.mtbTotalPrice.ReadOnly = true;
            this.mtbTotalPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbTotalPrice.SelectedText = "";
            this.mtbTotalPrice.SelectionLength = 0;
            this.mtbTotalPrice.SelectionStart = 0;
            this.mtbTotalPrice.ShortcutsEnabled = true;
            this.mtbTotalPrice.Size = new System.Drawing.Size(350, 30);
            this.mtbTotalPrice.TabIndex = 35;
            this.mtbTotalPrice.UseSelectable = true;
            this.mtbTotalPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbTotalPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Total price:";
            // 
            // mtbTotalTax
            // 
            // 
            // 
            // 
            this.mtbTotalTax.CustomButton.Image = null;
            this.mtbTotalTax.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbTotalTax.CustomButton.Name = "";
            this.mtbTotalTax.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbTotalTax.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbTotalTax.CustomButton.TabIndex = 1;
            this.mtbTotalTax.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbTotalTax.CustomButton.UseSelectable = true;
            this.mtbTotalTax.CustomButton.Visible = false;
            this.mtbTotalTax.Lines = new string[0];
            this.mtbTotalTax.Location = new System.Drawing.Point(303, 403);
            this.mtbTotalTax.MaxLength = 32767;
            this.mtbTotalTax.Name = "mtbTotalTax";
            this.mtbTotalTax.PasswordChar = '\0';
            this.mtbTotalTax.ReadOnly = true;
            this.mtbTotalTax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbTotalTax.SelectedText = "";
            this.mtbTotalTax.SelectionLength = 0;
            this.mtbTotalTax.SelectionStart = 0;
            this.mtbTotalTax.ShortcutsEnabled = true;
            this.mtbTotalTax.Size = new System.Drawing.Size(350, 30);
            this.mtbTotalTax.TabIndex = 33;
            this.mtbTotalTax.UseSelectable = true;
            this.mtbTotalTax.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbTotalTax.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Total tax:";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.SKU,
            this.Price,
            this.Tax,
            this.Quantity,
            this.TotalPrice});
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProducts.Location = new System.Drawing.Point(0, 35);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(1165, 249);
            this.dgvProducts.TabIndex = 4;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // SKU
            // 
            this.SKU.HeaderText = "SKU";
            this.SKU.Name = "SKU";
            this.SKU.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Tax
            // 
            this.Tax.HeaderText = "Tax";
            this.Tax.Name = "Tax";
            this.Tax.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // btnProductsPanel
            // 
            this.btnProductsPanel.BackColor = System.Drawing.Color.Navy;
            this.btnProductsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductsPanel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProductsPanel.FlatAppearance.BorderSize = 5;
            this.btnProductsPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProductsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductsPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProductsPanel.Location = new System.Drawing.Point(0, 0);
            this.btnProductsPanel.Name = "btnProductsPanel";
            this.btnProductsPanel.Size = new System.Drawing.Size(1165, 35);
            this.btnProductsPanel.TabIndex = 3;
            this.btnProductsPanel.Text = "Products panel";
            this.btnProductsPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductsPanel.UseVisualStyleBackColor = false;
            this.btnProductsPanel.Click += new System.EventHandler(this.btnProductsPanel_Click);
            // 
            // panelBillingDetails
            // 
            this.panelBillingDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelBillingDetails.Controls.Add(this.mtbStateBilling);
            this.panelBillingDetails.Controls.Add(this.label21);
            this.panelBillingDetails.Controls.Add(this.mtbPostcodeBilling);
            this.panelBillingDetails.Controls.Add(this.mtbLastNameBilling);
            this.panelBillingDetails.Controls.Add(this.mtbPhoneBilling);
            this.panelBillingDetails.Controls.Add(this.label22);
            this.panelBillingDetails.Controls.Add(this.label23);
            this.panelBillingDetails.Controls.Add(this.label24);
            this.panelBillingDetails.Controls.Add(this.rtbAddressBilling);
            this.panelBillingDetails.Controls.Add(this.label25);
            this.panelBillingDetails.Controls.Add(this.mtbFirstNameBilling);
            this.panelBillingDetails.Controls.Add(this.label26);
            this.panelBillingDetails.Controls.Add(this.mtbEmailBilling);
            this.panelBillingDetails.Controls.Add(this.mtbCompanyBilling);
            this.panelBillingDetails.Controls.Add(this.mtbCountryBilling);
            this.panelBillingDetails.Controls.Add(this.label27);
            this.panelBillingDetails.Controls.Add(this.label28);
            this.panelBillingDetails.Controls.Add(this.mtbCityBilling);
            this.panelBillingDetails.Controls.Add(this.label29);
            this.panelBillingDetails.Controls.Add(this.label30);
            this.panelBillingDetails.Controls.Add(this.btnBillingDetailsPanel);
            this.panelBillingDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBillingDetails.Location = new System.Drawing.Point(20, 709);
            this.panelBillingDetails.Name = "panelBillingDetails";
            this.panelBillingDetails.Size = new System.Drawing.Size(1165, 35);
            this.panelBillingDetails.TabIndex = 23;
            // 
            // mtbStateBilling
            // 
            // 
            // 
            // 
            this.mtbStateBilling.CustomButton.Image = null;
            this.mtbStateBilling.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbStateBilling.CustomButton.Name = "";
            this.mtbStateBilling.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbStateBilling.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbStateBilling.CustomButton.TabIndex = 1;
            this.mtbStateBilling.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbStateBilling.CustomButton.UseSelectable = true;
            this.mtbStateBilling.CustomButton.Visible = false;
            this.mtbStateBilling.Lines = new string[0];
            this.mtbStateBilling.Location = new System.Drawing.Point(301, 468);
            this.mtbStateBilling.MaxLength = 32767;
            this.mtbStateBilling.Name = "mtbStateBilling";
            this.mtbStateBilling.PasswordChar = '\0';
            this.mtbStateBilling.ReadOnly = true;
            this.mtbStateBilling.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbStateBilling.SelectedText = "";
            this.mtbStateBilling.SelectionLength = 0;
            this.mtbStateBilling.SelectionStart = 0;
            this.mtbStateBilling.ShortcutsEnabled = true;
            this.mtbStateBilling.Size = new System.Drawing.Size(350, 30);
            this.mtbStateBilling.TabIndex = 65;
            this.mtbStateBilling.UseSelectable = true;
            this.mtbStateBilling.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbStateBilling.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(20, 468);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 24);
            this.label21.TabIndex = 64;
            this.label21.Text = "State:";
            // 
            // mtbPostcodeBilling
            // 
            // 
            // 
            // 
            this.mtbPostcodeBilling.CustomButton.Image = null;
            this.mtbPostcodeBilling.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbPostcodeBilling.CustomButton.Name = "";
            this.mtbPostcodeBilling.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbPostcodeBilling.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbPostcodeBilling.CustomButton.TabIndex = 1;
            this.mtbPostcodeBilling.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbPostcodeBilling.CustomButton.UseSelectable = true;
            this.mtbPostcodeBilling.CustomButton.Visible = false;
            this.mtbPostcodeBilling.Lines = new string[0];
            this.mtbPostcodeBilling.Location = new System.Drawing.Point(301, 428);
            this.mtbPostcodeBilling.MaxLength = 32767;
            this.mtbPostcodeBilling.Name = "mtbPostcodeBilling";
            this.mtbPostcodeBilling.PasswordChar = '\0';
            this.mtbPostcodeBilling.ReadOnly = true;
            this.mtbPostcodeBilling.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbPostcodeBilling.SelectedText = "";
            this.mtbPostcodeBilling.SelectionLength = 0;
            this.mtbPostcodeBilling.SelectionStart = 0;
            this.mtbPostcodeBilling.ShortcutsEnabled = true;
            this.mtbPostcodeBilling.Size = new System.Drawing.Size(350, 30);
            this.mtbPostcodeBilling.TabIndex = 63;
            this.mtbPostcodeBilling.UseSelectable = true;
            this.mtbPostcodeBilling.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbPostcodeBilling.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbLastNameBilling
            // 
            // 
            // 
            // 
            this.mtbLastNameBilling.CustomButton.Image = null;
            this.mtbLastNameBilling.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbLastNameBilling.CustomButton.Name = "";
            this.mtbLastNameBilling.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbLastNameBilling.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbLastNameBilling.CustomButton.TabIndex = 1;
            this.mtbLastNameBilling.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbLastNameBilling.CustomButton.UseSelectable = true;
            this.mtbLastNameBilling.CustomButton.Visible = false;
            this.mtbLastNameBilling.Lines = new string[0];
            this.mtbLastNameBilling.Location = new System.Drawing.Point(301, 346);
            this.mtbLastNameBilling.MaxLength = 32767;
            this.mtbLastNameBilling.Name = "mtbLastNameBilling";
            this.mtbLastNameBilling.PasswordChar = '\0';
            this.mtbLastNameBilling.ReadOnly = true;
            this.mtbLastNameBilling.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbLastNameBilling.SelectedText = "";
            this.mtbLastNameBilling.SelectionLength = 0;
            this.mtbLastNameBilling.SelectionStart = 0;
            this.mtbLastNameBilling.ShortcutsEnabled = true;
            this.mtbLastNameBilling.Size = new System.Drawing.Size(350, 30);
            this.mtbLastNameBilling.TabIndex = 62;
            this.mtbLastNameBilling.UseSelectable = true;
            this.mtbLastNameBilling.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbLastNameBilling.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbPhoneBilling
            // 
            // 
            // 
            // 
            this.mtbPhoneBilling.CustomButton.Image = null;
            this.mtbPhoneBilling.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbPhoneBilling.CustomButton.Name = "";
            this.mtbPhoneBilling.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbPhoneBilling.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbPhoneBilling.CustomButton.TabIndex = 1;
            this.mtbPhoneBilling.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbPhoneBilling.CustomButton.UseSelectable = true;
            this.mtbPhoneBilling.CustomButton.Visible = false;
            this.mtbPhoneBilling.Lines = new string[0];
            this.mtbPhoneBilling.Location = new System.Drawing.Point(301, 387);
            this.mtbPhoneBilling.MaxLength = 32767;
            this.mtbPhoneBilling.Name = "mtbPhoneBilling";
            this.mtbPhoneBilling.PasswordChar = '\0';
            this.mtbPhoneBilling.ReadOnly = true;
            this.mtbPhoneBilling.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbPhoneBilling.SelectedText = "";
            this.mtbPhoneBilling.SelectionLength = 0;
            this.mtbPhoneBilling.SelectionStart = 0;
            this.mtbPhoneBilling.ShortcutsEnabled = true;
            this.mtbPhoneBilling.Size = new System.Drawing.Size(350, 30);
            this.mtbPhoneBilling.TabIndex = 61;
            this.mtbPhoneBilling.UseSelectable = true;
            this.mtbPhoneBilling.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbPhoneBilling.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(21, 346);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(111, 24);
            this.label22.TabIndex = 60;
            this.label22.Text = "Last name:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(21, 387);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 24);
            this.label23.TabIndex = 59;
            this.label23.Text = "Phone:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(20, 428);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(103, 24);
            this.label24.TabIndex = 58;
            this.label24.Text = "Postcode:";
            // 
            // rtbAddressBilling
            // 
            this.rtbAddressBilling.Location = new System.Drawing.Point(301, 53);
            this.rtbAddressBilling.Name = "rtbAddressBilling";
            this.rtbAddressBilling.ReadOnly = true;
            this.rtbAddressBilling.Size = new System.Drawing.Size(1000, 78);
            this.rtbAddressBilling.TabIndex = 57;
            this.rtbAddressBilling.Text = "";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(21, 53);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(93, 24);
            this.label25.TabIndex = 56;
            this.label25.Text = "Address:";
            // 
            // mtbFirstNameBilling
            // 
            // 
            // 
            // 
            this.mtbFirstNameBilling.CustomButton.Image = null;
            this.mtbFirstNameBilling.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbFirstNameBilling.CustomButton.Name = "";
            this.mtbFirstNameBilling.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbFirstNameBilling.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbFirstNameBilling.CustomButton.TabIndex = 1;
            this.mtbFirstNameBilling.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbFirstNameBilling.CustomButton.UseSelectable = true;
            this.mtbFirstNameBilling.CustomButton.Visible = false;
            this.mtbFirstNameBilling.Lines = new string[0];
            this.mtbFirstNameBilling.Location = new System.Drawing.Point(301, 306);
            this.mtbFirstNameBilling.MaxLength = 32767;
            this.mtbFirstNameBilling.Name = "mtbFirstNameBilling";
            this.mtbFirstNameBilling.PasswordChar = '\0';
            this.mtbFirstNameBilling.ReadOnly = true;
            this.mtbFirstNameBilling.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbFirstNameBilling.SelectedText = "";
            this.mtbFirstNameBilling.SelectionLength = 0;
            this.mtbFirstNameBilling.SelectionStart = 0;
            this.mtbFirstNameBilling.ShortcutsEnabled = true;
            this.mtbFirstNameBilling.Size = new System.Drawing.Size(350, 30);
            this.mtbFirstNameBilling.TabIndex = 55;
            this.mtbFirstNameBilling.UseSelectable = true;
            this.mtbFirstNameBilling.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbFirstNameBilling.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(20, 306);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(114, 24);
            this.label26.TabIndex = 54;
            this.label26.Text = "First name:";
            // 
            // mtbEmailBilling
            // 
            // 
            // 
            // 
            this.mtbEmailBilling.CustomButton.Image = null;
            this.mtbEmailBilling.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbEmailBilling.CustomButton.Name = "";
            this.mtbEmailBilling.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbEmailBilling.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbEmailBilling.CustomButton.TabIndex = 1;
            this.mtbEmailBilling.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbEmailBilling.CustomButton.UseSelectable = true;
            this.mtbEmailBilling.CustomButton.Visible = false;
            this.mtbEmailBilling.Lines = new string[0];
            this.mtbEmailBilling.Location = new System.Drawing.Point(301, 266);
            this.mtbEmailBilling.MaxLength = 32767;
            this.mtbEmailBilling.Name = "mtbEmailBilling";
            this.mtbEmailBilling.PasswordChar = '\0';
            this.mtbEmailBilling.ReadOnly = true;
            this.mtbEmailBilling.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbEmailBilling.SelectedText = "";
            this.mtbEmailBilling.SelectionLength = 0;
            this.mtbEmailBilling.SelectionStart = 0;
            this.mtbEmailBilling.ShortcutsEnabled = true;
            this.mtbEmailBilling.Size = new System.Drawing.Size(350, 30);
            this.mtbEmailBilling.TabIndex = 53;
            this.mtbEmailBilling.UseSelectable = true;
            this.mtbEmailBilling.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbEmailBilling.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbCompanyBilling
            // 
            // 
            // 
            // 
            this.mtbCompanyBilling.CustomButton.Image = null;
            this.mtbCompanyBilling.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbCompanyBilling.CustomButton.Name = "";
            this.mtbCompanyBilling.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbCompanyBilling.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbCompanyBilling.CustomButton.TabIndex = 1;
            this.mtbCompanyBilling.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbCompanyBilling.CustomButton.UseSelectable = true;
            this.mtbCompanyBilling.CustomButton.Visible = false;
            this.mtbCompanyBilling.Lines = new string[0];
            this.mtbCompanyBilling.Location = new System.Drawing.Point(301, 184);
            this.mtbCompanyBilling.MaxLength = 32767;
            this.mtbCompanyBilling.Name = "mtbCompanyBilling";
            this.mtbCompanyBilling.PasswordChar = '\0';
            this.mtbCompanyBilling.ReadOnly = true;
            this.mtbCompanyBilling.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbCompanyBilling.SelectedText = "";
            this.mtbCompanyBilling.SelectionLength = 0;
            this.mtbCompanyBilling.SelectionStart = 0;
            this.mtbCompanyBilling.ShortcutsEnabled = true;
            this.mtbCompanyBilling.Size = new System.Drawing.Size(350, 30);
            this.mtbCompanyBilling.TabIndex = 52;
            this.mtbCompanyBilling.UseSelectable = true;
            this.mtbCompanyBilling.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbCompanyBilling.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbCountryBilling
            // 
            // 
            // 
            // 
            this.mtbCountryBilling.CustomButton.Image = null;
            this.mtbCountryBilling.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbCountryBilling.CustomButton.Name = "";
            this.mtbCountryBilling.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbCountryBilling.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbCountryBilling.CustomButton.TabIndex = 1;
            this.mtbCountryBilling.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbCountryBilling.CustomButton.UseSelectable = true;
            this.mtbCountryBilling.CustomButton.Visible = false;
            this.mtbCountryBilling.Lines = new string[0];
            this.mtbCountryBilling.Location = new System.Drawing.Point(301, 225);
            this.mtbCountryBilling.MaxLength = 32767;
            this.mtbCountryBilling.Name = "mtbCountryBilling";
            this.mtbCountryBilling.PasswordChar = '\0';
            this.mtbCountryBilling.ReadOnly = true;
            this.mtbCountryBilling.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbCountryBilling.SelectedText = "";
            this.mtbCountryBilling.SelectionLength = 0;
            this.mtbCountryBilling.SelectionStart = 0;
            this.mtbCountryBilling.ShortcutsEnabled = true;
            this.mtbCountryBilling.Size = new System.Drawing.Size(350, 30);
            this.mtbCountryBilling.TabIndex = 51;
            this.mtbCountryBilling.UseSelectable = true;
            this.mtbCountryBilling.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbCountryBilling.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(21, 184);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(104, 24);
            this.label27.TabIndex = 50;
            this.label27.Text = "Company:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(21, 225);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(88, 24);
            this.label28.TabIndex = 49;
            this.label28.Text = "Country:";
            // 
            // mtbCityBilling
            // 
            // 
            // 
            // 
            this.mtbCityBilling.CustomButton.Image = null;
            this.mtbCityBilling.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbCityBilling.CustomButton.Name = "";
            this.mtbCityBilling.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbCityBilling.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbCityBilling.CustomButton.TabIndex = 1;
            this.mtbCityBilling.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbCityBilling.CustomButton.UseSelectable = true;
            this.mtbCityBilling.CustomButton.Visible = false;
            this.mtbCityBilling.Lines = new string[0];
            this.mtbCityBilling.Location = new System.Drawing.Point(301, 146);
            this.mtbCityBilling.MaxLength = 32767;
            this.mtbCityBilling.Name = "mtbCityBilling";
            this.mtbCityBilling.PasswordChar = '\0';
            this.mtbCityBilling.ReadOnly = true;
            this.mtbCityBilling.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbCityBilling.SelectedText = "";
            this.mtbCityBilling.SelectionLength = 0;
            this.mtbCityBilling.SelectionStart = 0;
            this.mtbCityBilling.ShortcutsEnabled = true;
            this.mtbCityBilling.Size = new System.Drawing.Size(350, 30);
            this.mtbCityBilling.TabIndex = 48;
            this.mtbCityBilling.UseSelectable = true;
            this.mtbCityBilling.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbCityBilling.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(20, 266);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(68, 24);
            this.label29.TabIndex = 47;
            this.label29.Text = "Email:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(21, 147);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(50, 24);
            this.label30.TabIndex = 46;
            this.label30.Text = "City:";
            // 
            // btnBillingDetailsPanel
            // 
            this.btnBillingDetailsPanel.BackColor = System.Drawing.Color.Navy;
            this.btnBillingDetailsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBillingDetailsPanel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBillingDetailsPanel.FlatAppearance.BorderSize = 5;
            this.btnBillingDetailsPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBillingDetailsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillingDetailsPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBillingDetailsPanel.Location = new System.Drawing.Point(0, 0);
            this.btnBillingDetailsPanel.Name = "btnBillingDetailsPanel";
            this.btnBillingDetailsPanel.Size = new System.Drawing.Size(1165, 35);
            this.btnBillingDetailsPanel.TabIndex = 3;
            this.btnBillingDetailsPanel.Text = "Billing details panel";
            this.btnBillingDetailsPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBillingDetailsPanel.UseVisualStyleBackColor = false;
            this.btnBillingDetailsPanel.Click += new System.EventHandler(this.btnBillingDetailsPanel_Click);
            // 
            // panelShippingDetails
            // 
            this.panelShippingDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelShippingDetails.Controls.Add(this.mtbStateShipping);
            this.panelShippingDetails.Controls.Add(this.label31);
            this.panelShippingDetails.Controls.Add(this.mtbPostcodeShipping);
            this.panelShippingDetails.Controls.Add(this.mtbLastNameShipping);
            this.panelShippingDetails.Controls.Add(this.label32);
            this.panelShippingDetails.Controls.Add(this.label38);
            this.panelShippingDetails.Controls.Add(this.rtbAddressShipping);
            this.panelShippingDetails.Controls.Add(this.Address);
            this.panelShippingDetails.Controls.Add(this.mtbFirstNameShipping);
            this.panelShippingDetails.Controls.Add(this.label33);
            this.panelShippingDetails.Controls.Add(this.mtbCompanyShipping);
            this.panelShippingDetails.Controls.Add(this.mtbCountryShipping);
            this.panelShippingDetails.Controls.Add(this.label34);
            this.panelShippingDetails.Controls.Add(this.label35);
            this.panelShippingDetails.Controls.Add(this.mtbCityShipping);
            this.panelShippingDetails.Controls.Add(this.label40);
            this.panelShippingDetails.Controls.Add(this.btnShippingDetailsPanel);
            this.panelShippingDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShippingDetails.Location = new System.Drawing.Point(20, 744);
            this.panelShippingDetails.Name = "panelShippingDetails";
            this.panelShippingDetails.Size = new System.Drawing.Size(1165, 35);
            this.panelShippingDetails.TabIndex = 24;
            // 
            // mtbStateShipping
            // 
            // 
            // 
            // 
            this.mtbStateShipping.CustomButton.Image = null;
            this.mtbStateShipping.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbStateShipping.CustomButton.Name = "";
            this.mtbStateShipping.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbStateShipping.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbStateShipping.CustomButton.TabIndex = 1;
            this.mtbStateShipping.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbStateShipping.CustomButton.UseSelectable = true;
            this.mtbStateShipping.CustomButton.Visible = false;
            this.mtbStateShipping.Lines = new string[0];
            this.mtbStateShipping.Location = new System.Drawing.Point(302, 397);
            this.mtbStateShipping.MaxLength = 32767;
            this.mtbStateShipping.Name = "mtbStateShipping";
            this.mtbStateShipping.PasswordChar = '\0';
            this.mtbStateShipping.ReadOnly = true;
            this.mtbStateShipping.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbStateShipping.SelectedText = "";
            this.mtbStateShipping.SelectionLength = 0;
            this.mtbStateShipping.SelectionStart = 0;
            this.mtbStateShipping.ShortcutsEnabled = true;
            this.mtbStateShipping.Size = new System.Drawing.Size(350, 30);
            this.mtbStateShipping.TabIndex = 45;
            this.mtbStateShipping.UseSelectable = true;
            this.mtbStateShipping.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbStateShipping.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(21, 397);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(62, 24);
            this.label31.TabIndex = 44;
            this.label31.Text = "State:";
            // 
            // mtbPostcodeShipping
            // 
            // 
            // 
            // 
            this.mtbPostcodeShipping.CustomButton.Image = null;
            this.mtbPostcodeShipping.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbPostcodeShipping.CustomButton.Name = "";
            this.mtbPostcodeShipping.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbPostcodeShipping.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbPostcodeShipping.CustomButton.TabIndex = 1;
            this.mtbPostcodeShipping.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbPostcodeShipping.CustomButton.UseSelectable = true;
            this.mtbPostcodeShipping.CustomButton.Visible = false;
            this.mtbPostcodeShipping.Lines = new string[0];
            this.mtbPostcodeShipping.Location = new System.Drawing.Point(302, 357);
            this.mtbPostcodeShipping.MaxLength = 32767;
            this.mtbPostcodeShipping.Name = "mtbPostcodeShipping";
            this.mtbPostcodeShipping.PasswordChar = '\0';
            this.mtbPostcodeShipping.ReadOnly = true;
            this.mtbPostcodeShipping.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbPostcodeShipping.SelectedText = "";
            this.mtbPostcodeShipping.SelectionLength = 0;
            this.mtbPostcodeShipping.SelectionStart = 0;
            this.mtbPostcodeShipping.ShortcutsEnabled = true;
            this.mtbPostcodeShipping.Size = new System.Drawing.Size(350, 30);
            this.mtbPostcodeShipping.TabIndex = 43;
            this.mtbPostcodeShipping.UseSelectable = true;
            this.mtbPostcodeShipping.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbPostcodeShipping.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbLastNameShipping
            // 
            // 
            // 
            // 
            this.mtbLastNameShipping.CustomButton.Image = null;
            this.mtbLastNameShipping.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbLastNameShipping.CustomButton.Name = "";
            this.mtbLastNameShipping.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbLastNameShipping.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbLastNameShipping.CustomButton.TabIndex = 1;
            this.mtbLastNameShipping.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbLastNameShipping.CustomButton.UseSelectable = true;
            this.mtbLastNameShipping.CustomButton.Visible = false;
            this.mtbLastNameShipping.Lines = new string[0];
            this.mtbLastNameShipping.Location = new System.Drawing.Point(302, 313);
            this.mtbLastNameShipping.MaxLength = 32767;
            this.mtbLastNameShipping.Name = "mtbLastNameShipping";
            this.mtbLastNameShipping.PasswordChar = '\0';
            this.mtbLastNameShipping.ReadOnly = true;
            this.mtbLastNameShipping.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbLastNameShipping.SelectedText = "";
            this.mtbLastNameShipping.SelectionLength = 0;
            this.mtbLastNameShipping.SelectionStart = 0;
            this.mtbLastNameShipping.ShortcutsEnabled = true;
            this.mtbLastNameShipping.Size = new System.Drawing.Size(350, 30);
            this.mtbLastNameShipping.TabIndex = 42;
            this.mtbLastNameShipping.UseSelectable = true;
            this.mtbLastNameShipping.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbLastNameShipping.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(22, 313);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(111, 24);
            this.label32.TabIndex = 40;
            this.label32.Text = "Last name:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(21, 357);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(103, 24);
            this.label38.TabIndex = 38;
            this.label38.Text = "Postcode:";
            // 
            // rtbAddressShipping
            // 
            this.rtbAddressShipping.Location = new System.Drawing.Point(302, 60);
            this.rtbAddressShipping.Name = "rtbAddressShipping";
            this.rtbAddressShipping.ReadOnly = true;
            this.rtbAddressShipping.Size = new System.Drawing.Size(1000, 78);
            this.rtbAddressShipping.TabIndex = 37;
            this.rtbAddressShipping.Text = "";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(22, 60);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(93, 24);
            this.Address.TabIndex = 36;
            this.Address.Text = "Address:";
            // 
            // mtbFirstNameShipping
            // 
            // 
            // 
            // 
            this.mtbFirstNameShipping.CustomButton.Image = null;
            this.mtbFirstNameShipping.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbFirstNameShipping.CustomButton.Name = "";
            this.mtbFirstNameShipping.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbFirstNameShipping.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbFirstNameShipping.CustomButton.TabIndex = 1;
            this.mtbFirstNameShipping.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbFirstNameShipping.CustomButton.UseSelectable = true;
            this.mtbFirstNameShipping.CustomButton.Visible = false;
            this.mtbFirstNameShipping.Lines = new string[0];
            this.mtbFirstNameShipping.Location = new System.Drawing.Point(302, 273);
            this.mtbFirstNameShipping.MaxLength = 32767;
            this.mtbFirstNameShipping.Name = "mtbFirstNameShipping";
            this.mtbFirstNameShipping.PasswordChar = '\0';
            this.mtbFirstNameShipping.ReadOnly = true;
            this.mtbFirstNameShipping.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbFirstNameShipping.SelectedText = "";
            this.mtbFirstNameShipping.SelectionLength = 0;
            this.mtbFirstNameShipping.SelectionStart = 0;
            this.mtbFirstNameShipping.ShortcutsEnabled = true;
            this.mtbFirstNameShipping.Size = new System.Drawing.Size(350, 30);
            this.mtbFirstNameShipping.TabIndex = 31;
            this.mtbFirstNameShipping.UseSelectable = true;
            this.mtbFirstNameShipping.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbFirstNameShipping.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(21, 273);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(114, 24);
            this.label33.TabIndex = 30;
            this.label33.Text = "First name:";
            // 
            // mtbCompanyShipping
            // 
            // 
            // 
            // 
            this.mtbCompanyShipping.CustomButton.Image = null;
            this.mtbCompanyShipping.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbCompanyShipping.CustomButton.Name = "";
            this.mtbCompanyShipping.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbCompanyShipping.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbCompanyShipping.CustomButton.TabIndex = 1;
            this.mtbCompanyShipping.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbCompanyShipping.CustomButton.UseSelectable = true;
            this.mtbCompanyShipping.CustomButton.Visible = false;
            this.mtbCompanyShipping.Lines = new string[0];
            this.mtbCompanyShipping.Location = new System.Drawing.Point(302, 191);
            this.mtbCompanyShipping.MaxLength = 32767;
            this.mtbCompanyShipping.Name = "mtbCompanyShipping";
            this.mtbCompanyShipping.PasswordChar = '\0';
            this.mtbCompanyShipping.ReadOnly = true;
            this.mtbCompanyShipping.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbCompanyShipping.SelectedText = "";
            this.mtbCompanyShipping.SelectionLength = 0;
            this.mtbCompanyShipping.SelectionStart = 0;
            this.mtbCompanyShipping.ShortcutsEnabled = true;
            this.mtbCompanyShipping.Size = new System.Drawing.Size(350, 30);
            this.mtbCompanyShipping.TabIndex = 28;
            this.mtbCompanyShipping.UseSelectable = true;
            this.mtbCompanyShipping.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbCompanyShipping.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbCountryShipping
            // 
            // 
            // 
            // 
            this.mtbCountryShipping.CustomButton.Image = null;
            this.mtbCountryShipping.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbCountryShipping.CustomButton.Name = "";
            this.mtbCountryShipping.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbCountryShipping.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbCountryShipping.CustomButton.TabIndex = 1;
            this.mtbCountryShipping.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbCountryShipping.CustomButton.UseSelectable = true;
            this.mtbCountryShipping.CustomButton.Visible = false;
            this.mtbCountryShipping.Lines = new string[0];
            this.mtbCountryShipping.Location = new System.Drawing.Point(302, 232);
            this.mtbCountryShipping.MaxLength = 32767;
            this.mtbCountryShipping.Name = "mtbCountryShipping";
            this.mtbCountryShipping.PasswordChar = '\0';
            this.mtbCountryShipping.ReadOnly = true;
            this.mtbCountryShipping.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbCountryShipping.SelectedText = "";
            this.mtbCountryShipping.SelectionLength = 0;
            this.mtbCountryShipping.SelectionStart = 0;
            this.mtbCountryShipping.ShortcutsEnabled = true;
            this.mtbCountryShipping.Size = new System.Drawing.Size(350, 30);
            this.mtbCountryShipping.TabIndex = 27;
            this.mtbCountryShipping.UseSelectable = true;
            this.mtbCountryShipping.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbCountryShipping.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(22, 191);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(104, 24);
            this.label34.TabIndex = 26;
            this.label34.Text = "Company:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(22, 232);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(88, 24);
            this.label35.TabIndex = 25;
            this.label35.Text = "Country:";
            // 
            // mtbCityShipping
            // 
            // 
            // 
            // 
            this.mtbCityShipping.CustomButton.Image = null;
            this.mtbCityShipping.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbCityShipping.CustomButton.Name = "";
            this.mtbCityShipping.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbCityShipping.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbCityShipping.CustomButton.TabIndex = 1;
            this.mtbCityShipping.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbCityShipping.CustomButton.UseSelectable = true;
            this.mtbCityShipping.CustomButton.Visible = false;
            this.mtbCityShipping.Lines = new string[0];
            this.mtbCityShipping.Location = new System.Drawing.Point(302, 153);
            this.mtbCityShipping.MaxLength = 32767;
            this.mtbCityShipping.Name = "mtbCityShipping";
            this.mtbCityShipping.PasswordChar = '\0';
            this.mtbCityShipping.ReadOnly = true;
            this.mtbCityShipping.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbCityShipping.SelectedText = "";
            this.mtbCityShipping.SelectionLength = 0;
            this.mtbCityShipping.SelectionStart = 0;
            this.mtbCityShipping.ShortcutsEnabled = true;
            this.mtbCityShipping.Size = new System.Drawing.Size(350, 30);
            this.mtbCityShipping.TabIndex = 15;
            this.mtbCityShipping.UseSelectable = true;
            this.mtbCityShipping.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbCityShipping.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(22, 154);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(50, 24);
            this.label40.TabIndex = 4;
            this.label40.Text = "City:";
            // 
            // btnShippingDetailsPanel
            // 
            this.btnShippingDetailsPanel.BackColor = System.Drawing.Color.Navy;
            this.btnShippingDetailsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShippingDetailsPanel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnShippingDetailsPanel.FlatAppearance.BorderSize = 5;
            this.btnShippingDetailsPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShippingDetailsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShippingDetailsPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShippingDetailsPanel.Location = new System.Drawing.Point(0, 0);
            this.btnShippingDetailsPanel.Name = "btnShippingDetailsPanel";
            this.btnShippingDetailsPanel.Size = new System.Drawing.Size(1165, 35);
            this.btnShippingDetailsPanel.TabIndex = 3;
            this.btnShippingDetailsPanel.Text = "Shipping details panel";
            this.btnShippingDetailsPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShippingDetailsPanel.UseVisualStyleBackColor = false;
            this.btnShippingDetailsPanel.Click += new System.EventHandler(this.btnShippingDetailsPanel_Click);
            // 
            // frmOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 1102);
            this.Controls.Add(this.panelShippingDetails);
            this.Controls.Add(this.panelBillingDetails);
            this.Controls.Add(this.panelProducts);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.panelMenu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmOrderDetails";
            this.Resizable = false;
            this.Text = "Order details";
            this.Load += new System.EventHandler(this.frmOrderDetails_Load);
            this.panelMenu.ResumeLayout(false);
            this.gbActions.ResumeLayout(false);
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            this.panelProducts.ResumeLayout(false);
            this.panelProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panelBillingDetails.ResumeLayout(false);
            this.panelBillingDetails.PerformLayout();
            this.panelShippingDetails.ResumeLayout(false);
            this.panelShippingDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelMenu;
        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel panelGeneral;
        private MetroFramework.Controls.MetroTextBox mtbOrderKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGeneralPanel;
        private MetroFramework.Controls.MetroTextBox mtbCreatedVia;
        private MetroFramework.Controls.MetroTextBox mtbCustomer;
        private MetroFramework.Controls.MetroTextBox mtbCustomerIP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroTextBox mtbStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.Button btnProductsPanel;
        private System.Windows.Forms.Panel panelBillingDetails;
        private System.Windows.Forms.Button btnBillingDetailsPanel;
        private System.Windows.Forms.Panel panelShippingDetails;
        private MetroFramework.Controls.MetroTextBox mtbFirstNameShipping;
        private System.Windows.Forms.Label label33;
        private MetroFramework.Controls.MetroTextBox mtbCompanyShipping;
        private MetroFramework.Controls.MetroTextBox mtbCountryShipping;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private MetroFramework.Controls.MetroTextBox mtbCityShipping;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Button btnShippingDetailsPanel;
        private System.Windows.Forms.RichTextBox rtbAddressShipping;
        private System.Windows.Forms.Label Address;
        private MetroFramework.Controls.MetroTextBox mtbStateShipping;
        private System.Windows.Forms.Label label31;
        private MetroFramework.Controls.MetroTextBox mtbPostcodeShipping;
        private MetroFramework.Controls.MetroTextBox mtbLastNameShipping;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label38;
        private MetroFramework.Controls.MetroTextBox mtbStateBilling;
        private System.Windows.Forms.Label label21;
        private MetroFramework.Controls.MetroTextBox mtbPostcodeBilling;
        private MetroFramework.Controls.MetroTextBox mtbLastNameBilling;
        private MetroFramework.Controls.MetroTextBox mtbPhoneBilling;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.RichTextBox rtbAddressBilling;
        private System.Windows.Forms.Label label25;
        private MetroFramework.Controls.MetroTextBox mtbFirstNameBilling;
        private System.Windows.Forms.Label label26;
        private MetroFramework.Controls.MetroTextBox mtbEmailBilling;
        private MetroFramework.Controls.MetroTextBox mtbCompanyBilling;
        private MetroFramework.Controls.MetroTextBox mtbCountryBilling;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private MetroFramework.Controls.MetroTextBox mtbCityBilling;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private MetroFramework.Controls.MetroTextBox mtbTotalPrice;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox mtbTotalTax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvProducts;
#pragma warning disable CS0108 // 'frmOrderDetails.ProductName' hides inherited member 'Control.ProductName'. Use the new keyword if hiding was intended.
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
#pragma warning restore CS0108 // 'frmOrderDetails.ProductName' hides inherited member 'Control.ProductName'. Use the new keyword if hiding was intended.
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private MetroFramework.Controls.MetroTextBox mtbShippingCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbCustomerNote;
        private System.Windows.Forms.Label label14;
        private MetroFramework.Controls.MetroTextBox mtbDateModified;
        private MetroFramework.Controls.MetroTextBox mtbDateCreated;
        private MetroFramework.Controls.MetroTextBox mtbDateCompleted;
        private MetroFramework.Controls.MetroTextBox mtbDatePaid;
        private MetroFramework.Controls.MetroTextBox mtbShippingMethod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReject;
    }
}