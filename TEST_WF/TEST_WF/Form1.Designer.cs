namespace TEST_WF
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Variant = new System.Windows.Forms.Panel();
            this.v5 = new System.Windows.Forms.Button();
            this.v4 = new System.Windows.Forms.Button();
            this.v3 = new System.Windows.Forms.Button();
            this.v2 = new System.Windows.Forms.Button();
            this.v1 = new System.Windows.Forms.Button();
            this.question = new System.Windows.Forms.Label();
            this.TestHistory = new System.Windows.Forms.TreeView();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.OPFD = new System.Windows.Forms.OpenFileDialog();
            this.randVariant = new System.Windows.Forms.CheckBox();
            this.variantValue = new System.Windows.Forms.Label();
            this.panel_Variant.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Variant
            // 
            this.panel_Variant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Variant.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel_Variant.Controls.Add(this.v5);
            this.panel_Variant.Controls.Add(this.v4);
            this.panel_Variant.Controls.Add(this.v3);
            this.panel_Variant.Controls.Add(this.v2);
            this.panel_Variant.Controls.Add(this.v1);
            this.panel_Variant.Location = new System.Drawing.Point(260, 155);
            this.panel_Variant.Name = "panel_Variant";
            this.panel_Variant.Size = new System.Drawing.Size(528, 283);
            this.panel_Variant.TabIndex = 0;
            // 
            // v5
            // 
            this.v5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.v5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.v5.Location = new System.Drawing.Point(3, 189);
            this.v5.Name = "v5";
            this.v5.Size = new System.Drawing.Size(522, 23);
            this.v5.TabIndex = 4;
            this.v5.Tag = "4";
            this.v5.UseVisualStyleBackColor = true;
            this.v5.Click += new System.EventHandler(this.v_Click);
            // 
            // v4
            // 
            this.v4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.v4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.v4.Location = new System.Drawing.Point(3, 160);
            this.v4.Name = "v4";
            this.v4.Size = new System.Drawing.Size(522, 23);
            this.v4.TabIndex = 3;
            this.v4.Tag = "3";
            this.v4.UseVisualStyleBackColor = true;
            this.v4.Click += new System.EventHandler(this.v_Click);
            // 
            // v3
            // 
            this.v3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.v3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.v3.Location = new System.Drawing.Point(3, 131);
            this.v3.Name = "v3";
            this.v3.Size = new System.Drawing.Size(522, 23);
            this.v3.TabIndex = 2;
            this.v3.Tag = "2";
            this.v3.UseVisualStyleBackColor = true;
            this.v3.Click += new System.EventHandler(this.v_Click);
            // 
            // v2
            // 
            this.v2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.v2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.v2.Location = new System.Drawing.Point(3, 102);
            this.v2.Name = "v2";
            this.v2.Size = new System.Drawing.Size(522, 23);
            this.v2.TabIndex = 1;
            this.v2.Tag = "1";
            this.v2.UseVisualStyleBackColor = true;
            this.v2.Click += new System.EventHandler(this.v_Click);
            // 
            // v1
            // 
            this.v1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.v1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.v1.Location = new System.Drawing.Point(3, 73);
            this.v1.Name = "v1";
            this.v1.Size = new System.Drawing.Size(522, 23);
            this.v1.TabIndex = 0;
            this.v1.Tag = "0";
            this.v1.UseVisualStyleBackColor = true;
            this.v1.Click += new System.EventHandler(this.v_Click);
            // 
            // question
            // 
            this.question.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.question.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.question.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.question.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.question.Location = new System.Drawing.Point(260, 9);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(528, 143);
            this.question.TabIndex = 1;
            // 
            // TestHistory
            // 
            this.TestHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TestHistory.Location = new System.Drawing.Point(12, 155);
            this.TestHistory.Name = "TestHistory";
            this.TestHistory.Size = new System.Drawing.Size(245, 283);
            this.TestHistory.TabIndex = 2;
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpen.Location = new System.Drawing.Point(12, 9);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(245, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHelp.Location = new System.Drawing.Point(12, 129);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(245, 23);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // OPFD
            // 
            this.OPFD.Filter = "\"Testfiles|*.xml|Все файлы|*.*\"";
            this.OPFD.InitialDirectory = "C://Users/Acer/Documents/test";
            // 
            // randVariant
            // 
            this.randVariant.AutoSize = true;
            this.randVariant.Checked = true;
            this.randVariant.CheckState = System.Windows.Forms.CheckState.Checked;
            this.randVariant.Location = new System.Drawing.Point(12, 38);
            this.randVariant.Name = "randVariant";
            this.randVariant.Size = new System.Drawing.Size(128, 17);
            this.randVariant.TabIndex = 5;
            this.randVariant.Text = "перемешать ответы";
            this.randVariant.UseVisualStyleBackColor = true;
            // 
            // variantValue
            // 
            this.variantValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.variantValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.variantValue.Location = new System.Drawing.Point(12, 103);
            this.variantValue.Name = "variantValue";
            this.variantValue.Size = new System.Drawing.Size(245, 23);
            this.variantValue.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.variantValue);
            this.Controls.Add(this.randVariant);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.TestHistory);
            this.Controls.Add(this.question);
            this.Controls.Add(this.panel_Variant);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.panel_Variant.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Variant;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Button v5;
        private System.Windows.Forms.Button v4;
        private System.Windows.Forms.Button v3;
        private System.Windows.Forms.Button v2;
        private System.Windows.Forms.Button v1;
        private System.Windows.Forms.TreeView TestHistory;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.OpenFileDialog OPFD;
        private System.Windows.Forms.CheckBox randVariant;
        private System.Windows.Forms.Label variantValue;
    }
}

