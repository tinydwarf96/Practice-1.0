﻿namespace ServicingTerminalApplication
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textCQN = new System.Windows.Forms.Label();
            this.textType = new System.Windows.Forms.TextBox();
            this.textTransaction = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.pictureBoxNEXT = new System.Windows.Forms.Button();
            this.pictureBoxDELETE = new System.Windows.Forms.Button();
            this.pictureBoxHOLD = new System.Windows.Forms.Button();
            this.pictureBoxViewHold = new System.Windows.Forms.Button();
            this.info_background = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.info_background)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.textCQN);
            this.panel1.Location = new System.Drawing.Point(53, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 167);
            this.panel1.TabIndex = 5;
            // 
            // textCQN
            // 
            this.textCQN.Font = new System.Drawing.Font("Bernard MT Condensed", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCQN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textCQN.Location = new System.Drawing.Point(17, 17);
            this.textCQN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textCQN.Name = "textCQN";
            this.textCQN.Size = new System.Drawing.Size(223, 132);
            this.textCQN.TabIndex = 5;
            this.textCQN.Text = "-";
            this.textCQN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textType
            // 
            this.textType.Cursor = System.Windows.Forms.Cursors.Default;
            this.textType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textType.Location = new System.Drawing.Point(319, 169);
            this.textType.Margin = new System.Windows.Forms.Padding(4);
            this.textType.Name = "textType";
            this.textType.ReadOnly = true;
            this.textType.Size = new System.Drawing.Size(377, 29);
            this.textType.TabIndex = 9;
            this.textType.TabStop = false;
            this.textType.Text = "-----";
            // 
            // textTransaction
            // 
            this.textTransaction.Cursor = System.Windows.Forms.Cursors.Default;
            this.textTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTransaction.Location = new System.Drawing.Point(319, 105);
            this.textTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.textTransaction.Multiline = true;
            this.textTransaction.Name = "textTransaction";
            this.textTransaction.ReadOnly = true;
            this.textTransaction.Size = new System.Drawing.Size(377, 54);
            this.textTransaction.TabIndex = 8;
            this.textTransaction.TabStop = false;
            this.textTransaction.Text = "-----";
            // 
            // textName
            // 
            this.textName.Cursor = System.Windows.Forms.Cursors.Default;
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(319, 68);
            this.textName.Margin = new System.Windows.Forms.Padding(4);
            this.textName.Name = "textName";
            this.textName.ReadOnly = true;
            this.textName.Size = new System.Drawing.Size(377, 29);
            this.textName.TabIndex = 7;
            this.textName.TabStop = false;
            this.textName.Text = "Name";
            // 
            // textID
            // 
            this.textID.Cursor = System.Windows.Forms.Cursors.Default;
            this.textID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.Location = new System.Drawing.Point(319, 31);
            this.textID.Margin = new System.Windows.Forms.Padding(4);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.ShortcutsEnabled = false;
            this.textID.Size = new System.Drawing.Size(377, 29);
            this.textID.TabIndex = 6;
            this.textID.TabStop = false;
            this.textID.Text = "ID # ";
            // 
            // pictureBoxNEXT
            // 
            this.pictureBoxNEXT.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNEXT.FlatAppearance.BorderSize = 0;
            this.pictureBoxNEXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pictureBoxNEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.pictureBoxNEXT.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pictureBoxNEXT.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNEXT.Image")));
            this.pictureBoxNEXT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pictureBoxNEXT.Location = new System.Drawing.Point(32, 225);
            this.pictureBoxNEXT.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxNEXT.Name = "pictureBoxNEXT";
            this.pictureBoxNEXT.Size = new System.Drawing.Size(104, 75);
            this.pictureBoxNEXT.TabIndex = 14;
            this.pictureBoxNEXT.Text = "Next";
            this.pictureBoxNEXT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pictureBoxNEXT.UseVisualStyleBackColor = false;
            this.pictureBoxNEXT.Click += new System.EventHandler(this.onMouseClick);
            // 
            // pictureBoxDELETE
            // 
            this.pictureBoxDELETE.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDELETE.FlatAppearance.BorderSize = 0;
            this.pictureBoxDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pictureBoxDELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.pictureBoxDELETE.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pictureBoxDELETE.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDELETE.Image")));
            this.pictureBoxDELETE.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pictureBoxDELETE.Location = new System.Drawing.Point(144, 225);
            this.pictureBoxDELETE.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxDELETE.Name = "pictureBoxDELETE";
            this.pictureBoxDELETE.Size = new System.Drawing.Size(104, 75);
            this.pictureBoxDELETE.TabIndex = 13;
            this.pictureBoxDELETE.Text = "Delete";
            this.pictureBoxDELETE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pictureBoxDELETE.UseVisualStyleBackColor = false;
            this.pictureBoxDELETE.Click += new System.EventHandler(this.onMouseClick);
            // 
            // pictureBoxHOLD
            // 
            this.pictureBoxHOLD.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHOLD.FlatAppearance.BorderSize = 0;
            this.pictureBoxHOLD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pictureBoxHOLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.pictureBoxHOLD.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pictureBoxHOLD.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHOLD.Image")));
            this.pictureBoxHOLD.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pictureBoxHOLD.Location = new System.Drawing.Point(256, 225);
            this.pictureBoxHOLD.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxHOLD.Name = "pictureBoxHOLD";
            this.pictureBoxHOLD.Size = new System.Drawing.Size(104, 75);
            this.pictureBoxHOLD.TabIndex = 12;
            this.pictureBoxHOLD.Text = "On Hold";
            this.pictureBoxHOLD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pictureBoxHOLD.UseVisualStyleBackColor = false;
            this.pictureBoxHOLD.Click += new System.EventHandler(this.onMouseClick);
            // 
            // pictureBoxViewHold
            // 
            this.pictureBoxViewHold.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxViewHold.FlatAppearance.BorderSize = 0;
            this.pictureBoxViewHold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pictureBoxViewHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.pictureBoxViewHold.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pictureBoxViewHold.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxViewHold.Image")));
            this.pictureBoxViewHold.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pictureBoxViewHold.Location = new System.Drawing.Point(368, 225);
            this.pictureBoxViewHold.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxViewHold.Name = "pictureBoxViewHold";
            this.pictureBoxViewHold.Size = new System.Drawing.Size(104, 75);
            this.pictureBoxViewHold.TabIndex = 11;
            this.pictureBoxViewHold.Text = "Hold List";
            this.pictureBoxViewHold.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pictureBoxViewHold.UseVisualStyleBackColor = false;
            this.pictureBoxViewHold.Click += new System.EventHandler(this.onMouseClick);
            // 
            // info_background
            // 
            this.info_background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(62)))), ((int)(((byte)(127)))));
            this.info_background.Dock = System.Windows.Forms.DockStyle.Top;
            this.info_background.Location = new System.Drawing.Point(0, 0);
            this.info_background.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.info_background.Name = "info_background";
            this.info_background.Size = new System.Drawing.Size(749, 219);
            this.info_background.TabIndex = 4;
            this.info_background.TabStop = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(480, 225);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 75);
            this.button1.TabIndex = 2;
            this.button1.Text = "Settings";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button2.Image = global::ServicingTerminalApplication.Properties.Resources.logoutBtn;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(592, 225);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 75);
            this.button2.TabIndex = 16;
            this.button2.Text = "Logout";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(749, 315);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBoxNEXT);
            this.Controls.Add(this.pictureBoxDELETE);
            this.Controls.Add(this.pictureBoxHOLD);
            this.Controls.Add(this.pictureBoxViewHold);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textType);
            this.Controls.Add(this.textTransaction);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.info_background);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terminal Controller";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.DarkRed;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.info_background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox info_background;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label textCQN;
        private System.Windows.Forms.TextBox textType;
        private System.Windows.Forms.TextBox textTransaction;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button pictureBoxViewHold;
        private System.Windows.Forms.Button pictureBoxHOLD;
        private System.Windows.Forms.Button pictureBoxDELETE;
        private System.Windows.Forms.Button pictureBoxNEXT;
        private System.Windows.Forms.Button button2;
    }
}

