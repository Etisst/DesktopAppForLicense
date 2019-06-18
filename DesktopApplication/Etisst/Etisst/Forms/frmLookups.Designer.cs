namespace Etisst
{
    partial class frmLookups
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
            this.btnView = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.gbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.gbActions);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.HorizontalScrollbarBarColor = true;
            this.panelMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.panelMenu.HorizontalScrollbarSize = 12;
            this.panelMenu.Location = new System.Drawing.Point(27, 74);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1013, 80);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.VerticalScrollbarBarColor = true;
            this.panelMenu.VerticalScrollbarHighlightOnWheel = false;
            this.panelMenu.VerticalScrollbarSize = 13;
            // 
            // gbActions
            // 
            this.gbActions.Controls.Add(this.btnView);
            this.gbActions.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbActions.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbActions.Location = new System.Drawing.Point(0, 0);
            this.gbActions.Margin = new System.Windows.Forms.Padding(4);
            this.gbActions.Name = "gbActions";
            this.gbActions.Padding = new System.Windows.Forms.Padding(4);
            this.gbActions.Size = new System.Drawing.Size(178, 80);
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
            this.btnView.Location = new System.Drawing.Point(8, 23);
            this.btnView.Margin = new System.Windows.Forms.Padding(4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(151, 47);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "View";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnCategories
            // 
            this.btnCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Location = new System.Drawing.Point(27, 154);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(1013, 34);
            this.btnCategories.TabIndex = 2;
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // frmLookups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnCategories);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Movable = false;
            this.Name = "frmLookups";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Text = "Lookups";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLookups_Load);
            this.panelMenu.ResumeLayout(false);
            this.gbActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelMenu;
        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnCategories;
    }
}