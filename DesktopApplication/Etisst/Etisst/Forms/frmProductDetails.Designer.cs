namespace Etisst
{
    partial class frmProductDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnGeneralPanel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mdtDateCreated = new MetroFramework.Controls.MetroDateTime();
            this.mdtDateModified = new MetroFramework.Controls.MetroDateTime();
            this.mtbURL = new MetroFramework.Controls.MetroTextBox();
            this.mtbName = new MetroFramework.Controls.MetroTextBox();
            this.mtbStatus = new MetroFramework.Controls.MetroTextBox();
            this.mtbSKU = new MetroFramework.Controls.MetroTextBox();
            this.rtbDescriptionHTML = new System.Windows.Forms.RichTextBox();
            this.rtbShortDescriptionHTML = new System.Windows.Forms.RichTextBox();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.btnImagesPanel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.wbShortDescription = new System.Windows.Forms.WebBrowser();
            this.wbDescription = new System.Windows.Forms.WebBrowser();
            this.panelImages = new System.Windows.Forms.Panel();
            this.btnAttributesPanel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mtbDimensions = new MetroFramework.Controls.MetroTextBox();
            this.mtbShippingClass = new MetroFramework.Controls.MetroTextBox();
            this.nInitialPrice = new System.Windows.Forms.NumericUpDown();
            this.nActualPrice = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.cblSize = new System.Windows.Forms.CheckedListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cblCategories = new System.Windows.Forms.CheckedListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cblTags = new System.Windows.Forms.CheckedListBox();
            this.panelAttributes = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbActions.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nInitialPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nActualPrice)).BeginInit();
            this.panelAttributes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.groupBox1);
            this.panelMenu.Controls.Add(this.gbActions);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.HorizontalScrollbarBarColor = true;
            this.panelMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.panelMenu.HorizontalScrollbarSize = 12;
            this.panelMenu.Location = new System.Drawing.Point(27, 44);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1589, 127);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.VerticalScrollbarBarColor = true;
            this.panelMenu.VerticalScrollbarHighlightOnWheel = false;
            this.panelMenu.VerticalScrollbarSize = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(320, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(140, 127);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Refresh";
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::Etisst.Properties.Resources.Refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(8, 23);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(127, 92);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // gbActions
            // 
            this.gbActions.Controls.Add(this.btnView);
            this.gbActions.Controls.Add(this.btnDelete);
            this.gbActions.Controls.Add(this.btnAdd);
            this.gbActions.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbActions.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbActions.Location = new System.Drawing.Point(0, 0);
            this.gbActions.Margin = new System.Windows.Forms.Padding(4);
            this.gbActions.Name = "gbActions";
            this.gbActions.Padding = new System.Windows.Forms.Padding(4);
            this.gbActions.Size = new System.Drawing.Size(320, 127);
            this.gbActions.TabIndex = 3;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Actions";
            // 
            // btnView
            // 
            this.btnView.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Image = global::Etisst.Properties.Resources.UpdateEntity;
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(143, 68);
            this.btnView.Margin = new System.Windows.Forms.Padding(4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(151, 47);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "View";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::Etisst.Properties.Resources.DeleteEntity;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(143, 14);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(151, 47);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::Etisst.Properties.Resources.AddEntity;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(8, 23);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 92);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
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
            this.btnGeneralPanel.Size = new System.Drawing.Size(1589, 35);
            this.btnGeneralPanel.TabIndex = 3;
            this.btnGeneralPanel.Text = "General panel";
            this.btnGeneralPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneralPanel.UseVisualStyleBackColor = false;
            this.btnGeneralPanel.Click += new System.EventHandler(this.btnGeneralPanel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "URL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date modified:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date created:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "SKU:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Short description HTML:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Description HTML:";
            // 
            // mdtDateCreated
            // 
            this.mdtDateCreated.Enabled = false;
            this.mdtDateCreated.Location = new System.Drawing.Point(302, 117);
            this.mdtDateCreated.MinimumSize = new System.Drawing.Size(4, 30);
            this.mdtDateCreated.Name = "mdtDateCreated";
            this.mdtDateCreated.Size = new System.Drawing.Size(350, 30);
            this.mdtDateCreated.TabIndex = 12;
            // 
            // mdtDateModified
            // 
            this.mdtDateModified.Enabled = false;
            this.mdtDateModified.Location = new System.Drawing.Point(302, 159);
            this.mdtDateModified.MinimumSize = new System.Drawing.Size(4, 30);
            this.mdtDateModified.Name = "mdtDateModified";
            this.mdtDateModified.Size = new System.Drawing.Size(350, 30);
            this.mdtDateModified.TabIndex = 13;
            // 
            // mtbURL
            // 
            // 
            // 
            // 
            this.mtbURL.CustomButton.Image = null;
            this.mtbURL.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbURL.CustomButton.Name = "";
            this.mtbURL.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbURL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbURL.CustomButton.TabIndex = 1;
            this.mtbURL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbURL.CustomButton.UseSelectable = true;
            this.mtbURL.CustomButton.Visible = false;
            this.mtbURL.Lines = new string[0];
            this.mtbURL.Location = new System.Drawing.Point(302, 77);
            this.mtbURL.MaxLength = 32767;
            this.mtbURL.Name = "mtbURL";
            this.mtbURL.PasswordChar = '\0';
            this.mtbURL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbURL.SelectedText = "";
            this.mtbURL.SelectionLength = 0;
            this.mtbURL.SelectionStart = 0;
            this.mtbURL.ShortcutsEnabled = true;
            this.mtbURL.Size = new System.Drawing.Size(350, 30);
            this.mtbURL.TabIndex = 14;
            this.mtbURL.UseSelectable = true;
            this.mtbURL.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbURL.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbName
            // 
            // 
            // 
            // 
            this.mtbName.CustomButton.Image = null;
            this.mtbName.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbName.CustomButton.Name = "";
            this.mtbName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbName.CustomButton.TabIndex = 1;
            this.mtbName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbName.CustomButton.UseSelectable = true;
            this.mtbName.CustomButton.Visible = false;
            this.mtbName.Lines = new string[0];
            this.mtbName.Location = new System.Drawing.Point(302, 39);
            this.mtbName.MaxLength = 32767;
            this.mtbName.Name = "mtbName";
            this.mtbName.PasswordChar = '\0';
            this.mtbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbName.SelectedText = "";
            this.mtbName.SelectionLength = 0;
            this.mtbName.SelectionStart = 0;
            this.mtbName.ShortcutsEnabled = true;
            this.mtbName.Size = new System.Drawing.Size(350, 30);
            this.mtbName.TabIndex = 15;
            this.mtbName.UseSelectable = true;
            this.mtbName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbStatus
            // 
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
            this.mtbStatus.Enabled = false;
            this.mtbStatus.Lines = new string[0];
            this.mtbStatus.Location = new System.Drawing.Point(302, 206);
            this.mtbStatus.MaxLength = 32767;
            this.mtbStatus.Name = "mtbStatus";
            this.mtbStatus.PasswordChar = '\0';
            this.mtbStatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbStatus.SelectedText = "";
            this.mtbStatus.SelectionLength = 0;
            this.mtbStatus.SelectionStart = 0;
            this.mtbStatus.ShortcutsEnabled = true;
            this.mtbStatus.Size = new System.Drawing.Size(350, 30);
            this.mtbStatus.TabIndex = 16;
            this.mtbStatus.UseSelectable = true;
            this.mtbStatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbStatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbSKU
            // 
            // 
            // 
            // 
            this.mtbSKU.CustomButton.Image = null;
            this.mtbSKU.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbSKU.CustomButton.Name = "";
            this.mtbSKU.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbSKU.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbSKU.CustomButton.TabIndex = 1;
            this.mtbSKU.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbSKU.CustomButton.UseSelectable = true;
            this.mtbSKU.CustomButton.Visible = false;
            this.mtbSKU.Lines = new string[0];
            this.mtbSKU.Location = new System.Drawing.Point(302, 247);
            this.mtbSKU.MaxLength = 32767;
            this.mtbSKU.Name = "mtbSKU";
            this.mtbSKU.PasswordChar = '\0';
            this.mtbSKU.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbSKU.SelectedText = "";
            this.mtbSKU.SelectionLength = 0;
            this.mtbSKU.SelectionStart = 0;
            this.mtbSKU.ShortcutsEnabled = true;
            this.mtbSKU.Size = new System.Drawing.Size(350, 30);
            this.mtbSKU.TabIndex = 17;
            this.mtbSKU.UseSelectable = true;
            this.mtbSKU.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbSKU.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rtbDescriptionHTML
            // 
            this.rtbDescriptionHTML.Location = new System.Drawing.Point(302, 358);
            this.rtbDescriptionHTML.Name = "rtbDescriptionHTML";
            this.rtbDescriptionHTML.Size = new System.Drawing.Size(1000, 200);
            this.rtbDescriptionHTML.TabIndex = 19;
            this.rtbDescriptionHTML.Text = "";
            // 
            // rtbShortDescriptionHTML
            // 
            this.rtbShortDescriptionHTML.Location = new System.Drawing.Point(302, 287);
            this.rtbShortDescriptionHTML.Name = "rtbShortDescriptionHTML";
            this.rtbShortDescriptionHTML.Size = new System.Drawing.Size(1000, 65);
            this.rtbShortDescriptionHTML.TabIndex = 20;
            this.rtbShortDescriptionHTML.Text = "";
            // 
            // panelGeneral
            // 
            this.panelGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelGeneral.Controls.Add(this.rtbShortDescriptionHTML);
            this.panelGeneral.Controls.Add(this.rtbDescriptionHTML);
            this.panelGeneral.Controls.Add(this.mtbSKU);
            this.panelGeneral.Controls.Add(this.mtbStatus);
            this.panelGeneral.Controls.Add(this.mtbName);
            this.panelGeneral.Controls.Add(this.mtbURL);
            this.panelGeneral.Controls.Add(this.mdtDateModified);
            this.panelGeneral.Controls.Add(this.mdtDateCreated);
            this.panelGeneral.Controls.Add(this.label8);
            this.panelGeneral.Controls.Add(this.label7);
            this.panelGeneral.Controls.Add(this.label6);
            this.panelGeneral.Controls.Add(this.label5);
            this.panelGeneral.Controls.Add(this.label4);
            this.panelGeneral.Controls.Add(this.label3);
            this.panelGeneral.Controls.Add(this.label2);
            this.panelGeneral.Controls.Add(this.label1);
            this.panelGeneral.Controls.Add(this.btnGeneralPanel);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGeneral.Location = new System.Drawing.Point(27, 171);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(1589, 35);
            this.panelGeneral.TabIndex = 2;
            // 
            // btnImagesPanel
            // 
            this.btnImagesPanel.BackColor = System.Drawing.Color.Navy;
            this.btnImagesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImagesPanel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnImagesPanel.FlatAppearance.BorderSize = 5;
            this.btnImagesPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImagesPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagesPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImagesPanel.Location = new System.Drawing.Point(0, 0);
            this.btnImagesPanel.Name = "btnImagesPanel";
            this.btnImagesPanel.Size = new System.Drawing.Size(1589, 35);
            this.btnImagesPanel.TabIndex = 3;
            this.btnImagesPanel.Text = "Images panel";
            this.btnImagesPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImagesPanel.UseVisualStyleBackColor = false;
            this.btnImagesPanel.Click += new System.EventHandler(this.btnImagesPanel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.InitialImage = global::Etisst.Properties.Resources.loading;
            this.pictureBox1.Location = new System.Drawing.Point(0, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 0);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.InitialImage = global::Etisst.Properties.Resources.loading;
            this.pictureBox2.Location = new System.Drawing.Point(350, 35);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 0);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.InitialImage = global::Etisst.Properties.Resources.loading;
            this.pictureBox3.Location = new System.Drawing.Point(700, 35);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(60, 3, 3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(350, 0);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // wbShortDescription
            // 
            this.wbShortDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.wbShortDescription.Location = new System.Drawing.Point(1050, 35);
            this.wbShortDescription.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbShortDescription.Name = "wbShortDescription";
            this.wbShortDescription.Size = new System.Drawing.Size(539, 250);
            this.wbShortDescription.TabIndex = 7;
            // 
            // wbDescription
            // 
            this.wbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbDescription.Location = new System.Drawing.Point(1050, 285);
            this.wbDescription.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbDescription.Name = "wbDescription";
            this.wbDescription.Size = new System.Drawing.Size(539, 20);
            this.wbDescription.TabIndex = 8;
            // 
            // panelImages
            // 
            this.panelImages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelImages.Controls.Add(this.wbDescription);
            this.panelImages.Controls.Add(this.wbShortDescription);
            this.panelImages.Controls.Add(this.pictureBox3);
            this.panelImages.Controls.Add(this.pictureBox2);
            this.panelImages.Controls.Add(this.pictureBox1);
            this.panelImages.Controls.Add(this.btnImagesPanel);
            this.panelImages.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelImages.Location = new System.Drawing.Point(27, 206);
            this.panelImages.Name = "panelImages";
            this.panelImages.Size = new System.Drawing.Size(1589, 35);
            this.panelImages.TabIndex = 3;
            // 
            // btnAttributesPanel
            // 
            this.btnAttributesPanel.BackColor = System.Drawing.Color.Navy;
            this.btnAttributesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAttributesPanel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAttributesPanel.FlatAppearance.BorderSize = 5;
            this.btnAttributesPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAttributesPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttributesPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAttributesPanel.Location = new System.Drawing.Point(0, 0);
            this.btnAttributesPanel.Name = "btnAttributesPanel";
            this.btnAttributesPanel.Size = new System.Drawing.Size(1589, 35);
            this.btnAttributesPanel.TabIndex = 3;
            this.btnAttributesPanel.Text = "Attributes panel";
            this.btnAttributesPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttributesPanel.UseVisualStyleBackColor = false;
            this.btnAttributesPanel.Click += new System.EventHandler(this.btnAttributesPanel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "Initial price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Actual price:";
            // 
            // mtbDimensions
            // 
            // 
            // 
            // 
            this.mtbDimensions.CustomButton.Image = null;
            this.mtbDimensions.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbDimensions.CustomButton.Name = "";
            this.mtbDimensions.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbDimensions.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbDimensions.CustomButton.TabIndex = 1;
            this.mtbDimensions.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbDimensions.CustomButton.UseSelectable = true;
            this.mtbDimensions.CustomButton.Visible = false;
            this.mtbDimensions.Lines = new string[0];
            this.mtbDimensions.Location = new System.Drawing.Point(302, 409);
            this.mtbDimensions.MaxLength = 32767;
            this.mtbDimensions.Name = "mtbDimensions";
            this.mtbDimensions.PasswordChar = '\0';
            this.mtbDimensions.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbDimensions.SelectedText = "";
            this.mtbDimensions.SelectionLength = 0;
            this.mtbDimensions.SelectionStart = 0;
            this.mtbDimensions.ShortcutsEnabled = true;
            this.mtbDimensions.Size = new System.Drawing.Size(350, 30);
            this.mtbDimensions.TabIndex = 18;
            this.mtbDimensions.UseSelectable = true;
            this.mtbDimensions.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbDimensions.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbShippingClass
            // 
            // 
            // 
            // 
            this.mtbShippingClass.CustomButton.Image = null;
            this.mtbShippingClass.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.mtbShippingClass.CustomButton.Name = "";
            this.mtbShippingClass.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtbShippingClass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbShippingClass.CustomButton.TabIndex = 1;
            this.mtbShippingClass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbShippingClass.CustomButton.UseSelectable = true;
            this.mtbShippingClass.CustomButton.Visible = false;
            this.mtbShippingClass.Enabled = false;
            this.mtbShippingClass.Lines = new string[0];
            this.mtbShippingClass.Location = new System.Drawing.Point(302, 368);
            this.mtbShippingClass.MaxLength = 32767;
            this.mtbShippingClass.Name = "mtbShippingClass";
            this.mtbShippingClass.PasswordChar = '\0';
            this.mtbShippingClass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbShippingClass.SelectedText = "";
            this.mtbShippingClass.SelectionLength = 0;
            this.mtbShippingClass.SelectionStart = 0;
            this.mtbShippingClass.ShortcutsEnabled = true;
            this.mtbShippingClass.Size = new System.Drawing.Size(350, 30);
            this.mtbShippingClass.TabIndex = 19;
            this.mtbShippingClass.UseSelectable = true;
            this.mtbShippingClass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbShippingClass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nInitialPrice
            // 
            this.nInitialPrice.DecimalPlaces = 2;
            this.nInitialPrice.Location = new System.Drawing.Point(302, 54);
            this.nInitialPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nInitialPrice.Name = "nInitialPrice";
            this.nInitialPrice.Size = new System.Drawing.Size(350, 22);
            this.nInitialPrice.TabIndex = 20;
            // 
            // nActualPrice
            // 
            this.nActualPrice.DecimalPlaces = 2;
            this.nActualPrice.Location = new System.Drawing.Point(302, 92);
            this.nActualPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nActualPrice.Name = "nActualPrice";
            this.nActualPrice.Size = new System.Drawing.Size(350, 22);
            this.nActualPrice.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 24);
            this.label11.TabIndex = 22;
            this.label11.Text = "Size:";
            // 
            // cblSize
            // 
            this.cblSize.FormattingEnabled = true;
            this.cblSize.Items.AddRange(new object[] {
            "Extra small (XS)",
            "Small (S)",
            "Medium (M)",
            "Large (L)",
            "Extra large (XL)",
            "Extra extra large (2XL)",
            "Extra extra extra large (3XL)"});
            this.cblSize.Location = new System.Drawing.Point(302, 232);
            this.cblSize.Name = "cblSize";
            this.cblSize.Size = new System.Drawing.Size(350, 123);
            this.cblSize.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 368);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 24);
            this.label12.TabIndex = 24;
            this.label12.Text = "Shipping class:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 24);
            this.label13.TabIndex = 25;
            this.label13.Text = "Categories:";
            // 
            // cblCategories
            // 
            this.cblCategories.FormattingEnabled = true;
            this.cblCategories.Location = new System.Drawing.Point(302, 130);
            this.cblCategories.Name = "cblCategories";
            this.cblCategories.Size = new System.Drawing.Size(350, 89);
            this.cblCategories.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 409);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 24);
            this.label14.TabIndex = 27;
            this.label14.Text = "Dimensions:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(21, 452);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 24);
            this.label15.TabIndex = 28;
            this.label15.Text = "Tags:";
            // 
            // cblTags
            // 
            this.cblTags.FormattingEnabled = true;
            this.cblTags.Location = new System.Drawing.Point(301, 452);
            this.cblTags.Name = "cblTags";
            this.cblTags.Size = new System.Drawing.Size(350, 140);
            this.cblTags.TabIndex = 29;
            // 
            // panelAttributes
            // 
            this.panelAttributes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelAttributes.Controls.Add(this.cblTags);
            this.panelAttributes.Controls.Add(this.label15);
            this.panelAttributes.Controls.Add(this.label14);
            this.panelAttributes.Controls.Add(this.cblCategories);
            this.panelAttributes.Controls.Add(this.label13);
            this.panelAttributes.Controls.Add(this.label12);
            this.panelAttributes.Controls.Add(this.cblSize);
            this.panelAttributes.Controls.Add(this.label11);
            this.panelAttributes.Controls.Add(this.nActualPrice);
            this.panelAttributes.Controls.Add(this.nInitialPrice);
            this.panelAttributes.Controls.Add(this.mtbShippingClass);
            this.panelAttributes.Controls.Add(this.mtbDimensions);
            this.panelAttributes.Controls.Add(this.label9);
            this.panelAttributes.Controls.Add(this.label10);
            this.panelAttributes.Controls.Add(this.btnAttributesPanel);
            this.panelAttributes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAttributes.Location = new System.Drawing.Point(27, 241);
            this.panelAttributes.Name = "panelAttributes";
            this.panelAttributes.Size = new System.Drawing.Size(1589, 35);
            this.panelAttributes.TabIndex = 4;
            // 
            // frmProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1643, 892);
            this.Controls.Add(this.panelAttributes);
            this.Controls.Add(this.panelImages);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.panelMenu);
            this.DisplayHeader = false;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProductDetails";
            this.Padding = new System.Windows.Forms.Padding(27, 44, 27, 25);
            this.Load += new System.EventHandler(this.frmProductDetails_LoadAsync);
            this.panelMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbActions.ResumeLayout(false);
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelImages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nInitialPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nActualPrice)).EndInit();
            this.panelAttributes.ResumeLayout(false);
            this.panelAttributes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnGeneralPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroDateTime mdtDateCreated;
        private MetroFramework.Controls.MetroDateTime mdtDateModified;
        private MetroFramework.Controls.MetroTextBox mtbURL;
        private MetroFramework.Controls.MetroTextBox mtbName;
        private MetroFramework.Controls.MetroTextBox mtbStatus;
        private MetroFramework.Controls.MetroTextBox mtbSKU;
        private System.Windows.Forms.RichTextBox rtbDescriptionHTML;
        private System.Windows.Forms.RichTextBox rtbShortDescriptionHTML;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Button btnImagesPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.WebBrowser wbShortDescription;
        private System.Windows.Forms.WebBrowser wbDescription;
        private System.Windows.Forms.Panel panelImages;
        private System.Windows.Forms.Button btnAttributesPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroTextBox mtbDimensions;
        private MetroFramework.Controls.MetroTextBox mtbShippingClass;
        private System.Windows.Forms.NumericUpDown nInitialPrice;
        private System.Windows.Forms.NumericUpDown nActualPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckedListBox cblSize;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckedListBox cblCategories;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckedListBox cblTags;
        private System.Windows.Forms.Panel panelAttributes;
    }
}