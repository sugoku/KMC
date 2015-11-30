﻿namespace KeppySpartanMIDIConverter
{
    partial class Informations
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informations));
            this.label1 = new System.Windows.Forms.Label();
            this.Versionlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.KeppyVer = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 165);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Versionlabel
            // 
            this.Versionlabel.AutoSize = true;
            this.Versionlabel.Location = new System.Drawing.Point(254, 29);
            this.Versionlabel.Name = "Versionlabel";
            this.Versionlabel.Size = new System.Drawing.Size(136, 15);
            this.Versionlabel.TabIndex = 2;
            this.Versionlabel.Text = "Keppy optimization here";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(513, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(387, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Un4seen website";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(258, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 27);
            this.button3.TabIndex = 5;
            this.button3.Text = "Readme";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // KeppyVer
            // 
            this.KeppyVer.AutoSize = true;
            this.KeppyVer.Location = new System.Drawing.Point(254, 14);
            this.KeppyVer.Name = "KeppyVer";
            this.KeppyVer.Size = new System.Drawing.Size(133, 15);
            this.KeppyVer.TabIndex = 6;
            this.KeppyVer.Text = "Keppy Title with version";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Keppy Studios";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::KeppyMIDIConverter.Properties.Resources.Senza_titolo_1;
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Click the logo to visit my official website.");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(254, 179);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(322, 15);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/KaleidonKep99/Keppys-MIDI-Converter";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Informations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 258);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.KeppyVer);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Versionlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Informations";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Informations";
            this.Load += new System.EventHandler(this.Informations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Versionlabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label KeppyVer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}