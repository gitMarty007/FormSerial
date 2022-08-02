
namespace WindowsFormsSerial
{
    partial class SerialReveal
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
            this.btnListCom = new System.Windows.Forms.Button();
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnListCom
            // 
            this.btnListCom.Location = new System.Drawing.Point(25, 47);
            this.btnListCom.Name = "btnListCom";
            this.btnListCom.Size = new System.Drawing.Size(75, 23);
            this.btnListCom.TabIndex = 0;
            this.btnListCom.Text = "Serial List";
            this.btnListCom.UseVisualStyleBackColor = true;
            this.btnListCom.Click += new System.EventHandler(this.btnListCom_Click);
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Location = new System.Drawing.Point(155, 47);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCOM.TabIndex = 1;
            // 
            // textBoxOut
            // 
            this.textBoxOut.Location = new System.Drawing.Point(25, 166);
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut.Size = new System.Drawing.Size(678, 236);
            this.textBoxOut.TabIndex = 2;
            // 
            // SerialReveal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.comboBoxCOM);
            this.Controls.Add(this.btnListCom);
            this.Name = "SerialReveal";
            this.Text = "Serial Test";
            this.Load += new System.EventHandler(this.SerialReveal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListCom;
        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.TextBox textBoxOut;
    }
}

