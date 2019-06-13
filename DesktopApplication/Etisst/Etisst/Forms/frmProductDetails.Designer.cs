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
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.btnGeneralPanel = new System.Windows.Forms.Button();
            this.panelImages = new System.Windows.Forms.Panel();
            this.btnImagesPanel = new System.Windows.Forms.Button();
            this.panelGeneral.SuspendLayout();
            this.panelImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGeneral
            // 
            this.panelGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelGeneral.Controls.Add(this.btnGeneralPanel);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGeneral.Location = new System.Drawing.Point(27, 74);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(1043, 35);
            this.panelGeneral.TabIndex = 0;
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
            this.btnGeneralPanel.Size = new System.Drawing.Size(1043, 35);
            this.btnGeneralPanel.TabIndex = 3;
            this.btnGeneralPanel.Text = "General panel";
            this.btnGeneralPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneralPanel.UseVisualStyleBackColor = false;
            this.btnGeneralPanel.Click += new System.EventHandler(this.btnGeneralPanel_Click);
            // 
            // panelImages
            // 
            this.panelImages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelImages.Controls.Add(this.btnImagesPanel);
            this.panelImages.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelImages.Location = new System.Drawing.Point(27, 109);
            this.panelImages.Name = "panelImages";
            this.panelImages.Size = new System.Drawing.Size(1043, 500);
            this.panelImages.TabIndex = 1;
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
            this.btnImagesPanel.Size = new System.Drawing.Size(1043, 35);
            this.btnImagesPanel.TabIndex = 3;
            this.btnImagesPanel.Text = "Images panel";
            this.btnImagesPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImagesPanel.UseVisualStyleBackColor = false;
            this.btnImagesPanel.Click += new System.EventHandler(this.btnImagesPanel_Click);
            // 
            // frmProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 614);
            this.Controls.Add(this.panelImages);
            this.Controls.Add(this.panelGeneral);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProductDetails";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "ProductDetails";
            this.Load += new System.EventHandler(this.frmProductDetails_Load);
            this.panelGeneral.ResumeLayout(false);
            this.panelImages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Button btnGeneralPanel;
        private System.Windows.Forms.Panel panelImages;
        private System.Windows.Forms.Button btnImagesPanel;
    }
}