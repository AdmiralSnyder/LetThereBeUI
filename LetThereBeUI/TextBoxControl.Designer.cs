namespace LetThereBeUI
{
    partial class TextBoxControl
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
            this.ContentTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ContentTB
            // 
            this.ContentTB.Location = new System.Drawing.Point(15, 46);
            this.ContentTB.Name = "ContentTB";
            this.ContentTB.Size = new System.Drawing.Size(100, 23);
            this.ContentTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // LabelTB
            // 
            this.LabelTB.Location = new System.Drawing.Point(15, 15);
            this.LabelTB.Name = "LabelTB";
            this.LabelTB.Size = new System.Drawing.Size(100, 23);
            this.LabelTB.TabIndex = 2;
            this.LabelTB.Leave += new System.EventHandler(this.LabelTB_Leave);
            // 
            // TextBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContentTB);
            this.Name = "TextBoxControl";
            this.Size = new System.Drawing.Size(129, 87);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ContentTB;
        private Label label1;
        private TextBox LabelTB;
    }
}
