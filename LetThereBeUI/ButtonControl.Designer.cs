﻿namespace LetThereBeUI
{
    partial class ButtonControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.TitleTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TitleTB
            // 
            this.TitleTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleTB.Location = new System.Drawing.Point(17, 12);
            this.TitleTB.Name = "TitleTB";
            this.TitleTB.Size = new System.Drawing.Size(109, 16);
            this.TitleTB.TabIndex = 1;
            this.TitleTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TitleTB.TextChanged += new System.EventHandler(this.TitleTB_TextChanged);
            this.TitleTB.Leave += new System.EventHandler(this.TitleTB_Leave);
            // 
            // ButtonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TitleTB);
            this.Controls.Add(this.button1);
            this.Name = "ButtonControl";
            this.Size = new System.Drawing.Size(144, 44);
            this.DoubleClick += new System.EventHandler(this.ButtonControl_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox TitleTB;
    }
}
