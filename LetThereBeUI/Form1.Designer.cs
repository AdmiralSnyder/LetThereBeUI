namespace LetThereBeUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LetThereBeUIB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LetThereBeUIB
            // 
            this.LetThereBeUIB.Location = new System.Drawing.Point(273, 38);
            this.LetThereBeUIB.Name = "LetThereBeUIB";
            this.LetThereBeUIB.Size = new System.Drawing.Size(160, 23);
            this.LetThereBeUIB.TabIndex = 0;
            this.LetThereBeUIB.Text = "Let There Be UI...";
            this.LetThereBeUIB.UseVisualStyleBackColor = true;
            this.LetThereBeUIB.Click += new System.EventHandler(this.LetThereBeUIB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LetThereBeUIB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button LetThereBeUIB;
    }
}