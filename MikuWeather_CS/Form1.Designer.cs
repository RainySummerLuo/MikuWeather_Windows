﻿using System.ComponentModel;
using System.Windows.Forms;

namespace MikuWeather
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            _frmShow.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picBox = new System.Windows.Forms.PictureBox();
            this.cmMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmWebsite = new System.Windows.Forms.ToolStripMenuItem();
            this.cmUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.cmMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.ContextMenuStrip = this.cmMenu;
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(0, 0);
            this.picBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(280, 281);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            this.picBox.MouseEnter += new System.EventHandler(this.Form1_MouseHover);
            this.picBox.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.picBox.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            // 
            // cmMenu
            // 
            this.cmMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmWebsite,
            this.cmUpdate,
            this.cmExit});
            this.cmMenu.Name = "cmMenu";
            this.cmMenu.Size = new System.Drawing.Size(263, 118);
            // 
            // cmWebsite
            // 
            this.cmWebsite.Name = "cmWebsite";
            this.cmWebsite.Size = new System.Drawing.Size(262, 38);
            this.cmWebsite.Text = "访问Github仓库";
            this.cmWebsite.Click += new System.EventHandler(this.CmWebsite_Click);
            // 
            // cmUpdate
            // 
            this.cmUpdate.Name = "cmUpdate";
            this.cmUpdate.Size = new System.Drawing.Size(262, 38);
            this.cmUpdate.Text = "Update";
            this.cmUpdate.Click += new System.EventHandler(this.CmUpdate_Click);
            // 
            // cmExit
            // 
            this.cmExit.Name = "cmExit";
            this.cmExit.Size = new System.Drawing.Size(262, 38);
            this.cmExit.Text = "退出";
            this.cmExit.Click += new System.EventHandler(this.CmExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(280, 281);
            this.Controls.Add(this.picBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.cmMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picBox;
        private ContextMenuStrip cmMenu;
        private ToolStripMenuItem cmWebsite;
        private ToolStripMenuItem cmExit;
        private ToolStripMenuItem cmUpdate;
    }
}