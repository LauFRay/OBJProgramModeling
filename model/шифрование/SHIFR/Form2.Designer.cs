namespace SHIFR
{
    partial class ShCezar
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
            this.TextInput = new System.Windows.Forms.TextBox();
            this.KeyNum = new System.Windows.Forms.NumericUpDown();
            this.Cipher = new System.Windows.Forms.Button();
            this.Decipher = new System.Windows.Forms.Button();
            this.TextOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.KeyNum)).BeginInit();
            this.SuspendLayout();
            // 
            // TextInput
            // 
            this.TextInput.Location = new System.Drawing.Point(12, 12);
            this.TextInput.Multiline = true;
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(776, 112);
            this.TextInput.TabIndex = 2;
            // 
            // KeyNum
            // 
            this.KeyNum.Location = new System.Drawing.Point(12, 130);
            this.KeyNum.Name = "KeyNum";
            this.KeyNum.Size = new System.Drawing.Size(86, 20);
            this.KeyNum.TabIndex = 3;
            // 
            // Cipher
            // 
            this.Cipher.Location = new System.Drawing.Point(104, 130);
            this.Cipher.Name = "Cipher";
            this.Cipher.Size = new System.Drawing.Size(103, 20);
            this.Cipher.TabIndex = 4;
            this.Cipher.Text = "Зашифровать";
            this.Cipher.UseVisualStyleBackColor = true;
            this.Cipher.Click += new System.EventHandler(this.Cipher_Click);
            // 
            // Decipher
            // 
            this.Decipher.Location = new System.Drawing.Point(213, 130);
            this.Decipher.Name = "Decipher";
            this.Decipher.Size = new System.Drawing.Size(103, 20);
            this.Decipher.TabIndex = 5;
            this.Decipher.Text = "Расшифровать";
            this.Decipher.UseVisualStyleBackColor = true;
            this.Decipher.Click += new System.EventHandler(this.Decipher_Click);
            // 
            // TextOutput
            // 
            this.TextOutput.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TextOutput.Location = new System.Drawing.Point(12, 197);
            this.TextOutput.Name = "TextOutput";
            this.TextOutput.Size = new System.Drawing.Size(776, 242);
            this.TextOutput.TabIndex = 6;
            // 
            // ShCezar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextOutput);
            this.Controls.Add(this.Decipher);
            this.Controls.Add(this.Cipher);
            this.Controls.Add(this.KeyNum);
            this.Controls.Add(this.TextInput);
            this.Name = "ShCezar";
            this.Text = "Шифр Цезаря";
            ((System.ComponentModel.ISupportInitialize)(this.KeyNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextInput;
        private System.Windows.Forms.NumericUpDown KeyNum;
        private System.Windows.Forms.Button Cipher;
        private System.Windows.Forms.Button Decipher;
        private System.Windows.Forms.Label TextOutput;
    }
}