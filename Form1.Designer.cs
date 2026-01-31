namespace computer_club
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
            this.labelPc1 = new System.Windows.Forms.Label();
            this.labelPc2 = new System.Windows.Forms.Label();
            this.labelPc3 = new System.Windows.Forms.Label();
            this.buttonPc1 = new System.Windows.Forms.Button();
            this.buttonPc2 = new System.Windows.Forms.Button();
            this.buttonPc3 = new System.Windows.Forms.Button();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelClientMinutes = new System.Windows.Forms.Label();
            this.labelClientName = new System.Windows.Forms.Label();
            this.buttonOtkaz = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelPc4 = new System.Windows.Forms.Label();
            this.labelPc5 = new System.Windows.Forms.Label();
            this.labelPc6 = new System.Windows.Forms.Label();
            this.labelPc7 = new System.Windows.Forms.Label();
            this.labelPc8 = new System.Windows.Forms.Label();
            this.labelPc9 = new System.Windows.Forms.Label();
            this.buttonPc4 = new System.Windows.Forms.Button();
            this.buttonPc5 = new System.Windows.Forms.Button();
            this.buttonPc6 = new System.Windows.Forms.Button();
            this.buttonPc7 = new System.Windows.Forms.Button();
            this.buttonPc8 = new System.Windows.Forms.Button();
            this.buttonPc9 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPc1
            // 
            this.labelPc1.Location = new System.Drawing.Point(301, 58);
            this.labelPc1.Name = "labelPc1";
            this.labelPc1.Size = new System.Drawing.Size(147, 37);
            this.labelPc1.TabIndex = 1;
            this.labelPc1.Text = "label1";
            this.labelPc1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPc2
            // 
            this.labelPc2.Location = new System.Drawing.Point(490, 58);
            this.labelPc2.Name = "labelPc2";
            this.labelPc2.Size = new System.Drawing.Size(147, 37);
            this.labelPc2.TabIndex = 2;
            this.labelPc2.Text = "label2";
            // 
            // labelPc3
            // 
            this.labelPc3.Location = new System.Drawing.Point(697, 58);
            this.labelPc3.Name = "labelPc3";
            this.labelPc3.Size = new System.Drawing.Size(147, 37);
            this.labelPc3.TabIndex = 3;
            this.labelPc3.Text = "label3";
            // 
            // buttonPc1
            // 
            this.buttonPc1.Location = new System.Drawing.Point(304, 98);
            this.buttonPc1.Name = "buttonPc1";
            this.buttonPc1.Size = new System.Drawing.Size(83, 23);
            this.buttonPc1.TabIndex = 4;
            this.buttonPc1.Text = "Посадить";
            this.buttonPc1.UseVisualStyleBackColor = true;
            // 
            // buttonPc2
            // 
            this.buttonPc2.Location = new System.Drawing.Point(477, 98);
            this.buttonPc2.Name = "buttonPc2";
            this.buttonPc2.Size = new System.Drawing.Size(83, 23);
            this.buttonPc2.TabIndex = 5;
            this.buttonPc2.Text = "Посадить";
            this.buttonPc2.UseVisualStyleBackColor = true;
            // 
            // buttonPc3
            // 
            this.buttonPc3.Location = new System.Drawing.Point(683, 98);
            this.buttonPc3.Name = "buttonPc3";
            this.buttonPc3.Size = new System.Drawing.Size(85, 23);
            this.buttonPc3.TabIndex = 6;
            this.buttonPc3.Text = "Посадить";
            this.buttonPc3.UseVisualStyleBackColor = true;
            // 
            // labelBalance
            // 
            this.labelBalance.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelBalance.Location = new System.Drawing.Point(680, 510);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(240, 44);
            this.labelBalance.TabIndex = 7;
            this.labelBalance.Text = "label1";
            this.labelBalance.Click += new System.EventHandler(this.labelBalance_Click);
            // 
            // labelClientMinutes
            // 
            this.labelClientMinutes.Location = new System.Drawing.Point(3, 46);
            this.labelClientMinutes.Name = "labelClientMinutes";
            this.labelClientMinutes.Size = new System.Drawing.Size(240, 49);
            this.labelClientMinutes.TabIndex = 1;
            this.labelClientMinutes.Text = "label1";
            // 
            // labelClientName
            // 
            this.labelClientName.Location = new System.Drawing.Point(3, 0);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(240, 46);
            this.labelClientName.TabIndex = 0;
            this.labelClientName.Text = "label1";
            // 
            // buttonOtkaz
            // 
            this.buttonOtkaz.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonOtkaz.Location = new System.Drawing.Point(3, 98);
            this.buttonOtkaz.Name = "buttonOtkaz";
            this.buttonOtkaz.Size = new System.Drawing.Size(240, 63);
            this.buttonOtkaz.TabIndex = 2;
            this.buttonOtkaz.Text = "Отказать клиенту";
            this.buttonOtkaz.UseVisualStyleBackColor = true;
            this.buttonOtkaz.Click += new System.EventHandler(this.buttonOtkaz_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelClientName);
            this.flowLayoutPanel1.Controls.Add(this.labelClientMinutes);
            this.flowLayoutPanel1.Controls.Add(this.buttonOtkaz);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(255, 554);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // labelPc4
            // 
            this.labelPc4.Location = new System.Drawing.Point(301, 208);
            this.labelPc4.Name = "labelPc4";
            this.labelPc4.Size = new System.Drawing.Size(147, 37);
            this.labelPc4.TabIndex = 7;
            this.labelPc4.Text = "label1";
            // 
            // labelPc5
            // 
            this.labelPc5.Location = new System.Drawing.Point(474, 208);
            this.labelPc5.Name = "labelPc5";
            this.labelPc5.Size = new System.Drawing.Size(147, 37);
            this.labelPc5.TabIndex = 8;
            this.labelPc5.Text = "label1";
            // 
            // labelPc6
            // 
            this.labelPc6.Location = new System.Drawing.Point(680, 208);
            this.labelPc6.Name = "labelPc6";
            this.labelPc6.Size = new System.Drawing.Size(147, 37);
            this.labelPc6.TabIndex = 9;
            this.labelPc6.Text = "label1";
            // 
            // labelPc7
            // 
            this.labelPc7.Location = new System.Drawing.Point(301, 321);
            this.labelPc7.Name = "labelPc7";
            this.labelPc7.Size = new System.Drawing.Size(147, 37);
            this.labelPc7.TabIndex = 10;
            this.labelPc7.Text = "label1";
            // 
            // labelPc8
            // 
            this.labelPc8.Location = new System.Drawing.Point(474, 321);
            this.labelPc8.Name = "labelPc8";
            this.labelPc8.Size = new System.Drawing.Size(147, 37);
            this.labelPc8.TabIndex = 11;
            this.labelPc8.Text = "label1";
            // 
            // labelPc9
            // 
            this.labelPc9.Location = new System.Drawing.Point(680, 321);
            this.labelPc9.Name = "labelPc9";
            this.labelPc9.Size = new System.Drawing.Size(147, 37);
            this.labelPc9.TabIndex = 12;
            this.labelPc9.Text = "label1";
            // 
            // buttonPc4
            // 
            this.buttonPc4.Location = new System.Drawing.Point(304, 258);
            this.buttonPc4.Name = "buttonPc4";
            this.buttonPc4.Size = new System.Drawing.Size(83, 23);
            this.buttonPc4.TabIndex = 13;
            this.buttonPc4.Text = "Посадить";
            this.buttonPc4.UseVisualStyleBackColor = true;
            // 
            // buttonPc5
            // 
            this.buttonPc5.Location = new System.Drawing.Point(477, 258);
            this.buttonPc5.Name = "buttonPc5";
            this.buttonPc5.Size = new System.Drawing.Size(83, 23);
            this.buttonPc5.TabIndex = 14;
            this.buttonPc5.Text = "Посадить";
            this.buttonPc5.UseVisualStyleBackColor = true;
            // 
            // buttonPc6
            // 
            this.buttonPc6.Location = new System.Drawing.Point(683, 258);
            this.buttonPc6.Name = "buttonPc6";
            this.buttonPc6.Size = new System.Drawing.Size(96, 23);
            this.buttonPc6.TabIndex = 15;
            this.buttonPc6.Text = "Посадить";
            this.buttonPc6.UseVisualStyleBackColor = true;
            // 
            // buttonPc7
            // 
            this.buttonPc7.Location = new System.Drawing.Point(304, 370);
            this.buttonPc7.Name = "buttonPc7";
            this.buttonPc7.Size = new System.Drawing.Size(83, 23);
            this.buttonPc7.TabIndex = 16;
            this.buttonPc7.Text = "Посадить";
            this.buttonPc7.UseVisualStyleBackColor = true;
            // 
            // buttonPc8
            // 
            this.buttonPc8.Location = new System.Drawing.Point(463, 370);
            this.buttonPc8.Name = "buttonPc8";
            this.buttonPc8.Size = new System.Drawing.Size(81, 23);
            this.buttonPc8.TabIndex = 17;
            this.buttonPc8.Text = "Посадить";
            this.buttonPc8.UseVisualStyleBackColor = true;
            // 
            // buttonPc9
            // 
            this.buttonPc9.Location = new System.Drawing.Point(683, 370);
            this.buttonPc9.Name = "buttonPc9";
            this.buttonPc9.Size = new System.Drawing.Size(85, 23);
            this.buttonPc9.TabIndex = 18;
            this.buttonPc9.Text = "Посадить";
            this.buttonPc9.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 554);
            this.Controls.Add(this.buttonPc9);
            this.Controls.Add(this.buttonPc8);
            this.Controls.Add(this.buttonPc7);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.buttonPc6);
            this.Controls.Add(this.buttonPc5);
            this.Controls.Add(this.buttonPc4);
            this.Controls.Add(this.labelPc9);
            this.Controls.Add(this.labelPc8);
            this.Controls.Add(this.labelPc7);
            this.Controls.Add(this.labelPc6);
            this.Controls.Add(this.labelPc5);
            this.Controls.Add(this.labelPc4);
            this.Controls.Add(this.buttonPc3);
            this.Controls.Add(this.buttonPc2);
            this.Controls.Add(this.buttonPc1);
            this.Controls.Add(this.labelPc3);
            this.Controls.Add(this.labelPc2);
            this.Controls.Add(this.labelPc1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelPc1;
        private System.Windows.Forms.Label labelPc2;
        private System.Windows.Forms.Label labelPc3;
        private System.Windows.Forms.Button buttonPc1;
        private System.Windows.Forms.Button buttonPc2;
        private System.Windows.Forms.Button buttonPc3;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelClientMinutes;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.Button buttonOtkaz;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelPc4;
        private System.Windows.Forms.Label labelPc5;
        private System.Windows.Forms.Label labelPc6;
        private System.Windows.Forms.Label labelPc7;
        private System.Windows.Forms.Label labelPc8;
        private System.Windows.Forms.Label labelPc9;
        private System.Windows.Forms.Button buttonPc4;
        private System.Windows.Forms.Button buttonPc5;
        private System.Windows.Forms.Button buttonPc6;
        private System.Windows.Forms.Button buttonPc7;
        private System.Windows.Forms.Button buttonPc8;
        private System.Windows.Forms.Button buttonPc9;
    }
}

