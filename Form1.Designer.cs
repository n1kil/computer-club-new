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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelClientName = new System.Windows.Forms.Label();
            this.labelClientMinutes = new System.Windows.Forms.Label();
            this.labelPc1 = new System.Windows.Forms.Label();
            this.labelPc2 = new System.Windows.Forms.Label();
            this.labelPc3 = new System.Windows.Forms.Label();
            this.buttonPc1 = new System.Windows.Forms.Button();
            this.buttonPc2 = new System.Windows.Forms.Button();
            this.buttonPc3 = new System.Windows.Forms.Button();
            this.buttonOtkaz = new System.Windows.Forms.Button();
            this.labelBalance = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelClientName);
            this.flowLayoutPanel1.Controls.Add(this.labelClientMinutes);
            this.flowLayoutPanel1.Controls.Add(this.buttonOtkaz);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(255, 554);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // labelClientName
            // 
            this.labelClientName.Location = new System.Drawing.Point(3, 0);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(240, 46);
            this.labelClientName.TabIndex = 0;
            this.labelClientName.Text = "label1";
            // 
            // labelClientMinutes
            // 
            this.labelClientMinutes.Location = new System.Drawing.Point(3, 46);
            this.labelClientMinutes.Name = "labelClientMinutes";
            this.labelClientMinutes.Size = new System.Drawing.Size(240, 49);
            this.labelClientMinutes.TabIndex = 1;
            this.labelClientMinutes.Text = "label1";
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
            this.buttonPc1.Size = new System.Drawing.Size(75, 23);
            this.buttonPc1.TabIndex = 4;
            this.buttonPc1.Text = "button1";
            this.buttonPc1.UseVisualStyleBackColor = true;
            // 
            // buttonPc2
            // 
            this.buttonPc2.Location = new System.Drawing.Point(477, 98);
            this.buttonPc2.Name = "buttonPc2";
            this.buttonPc2.Size = new System.Drawing.Size(75, 23);
            this.buttonPc2.TabIndex = 5;
            this.buttonPc2.Text = "button2";
            this.buttonPc2.UseVisualStyleBackColor = true;
            // 
            // buttonPc3
            // 
            this.buttonPc3.Location = new System.Drawing.Point(683, 98);
            this.buttonPc3.Name = "buttonPc3";
            this.buttonPc3.Size = new System.Drawing.Size(75, 23);
            this.buttonPc3.TabIndex = 6;
            this.buttonPc3.Text = "button3";
            this.buttonPc3.UseVisualStyleBackColor = true;
            // 
            // buttonOtkaz
            // 
            this.buttonOtkaz.Location = new System.Drawing.Point(3, 98);
            this.buttonOtkaz.Name = "buttonOtkaz";
            this.buttonOtkaz.Size = new System.Drawing.Size(240, 63);
            this.buttonOtkaz.TabIndex = 2;
            this.buttonOtkaz.Text = "button1";
            this.buttonOtkaz.UseVisualStyleBackColor = true;
            this.buttonOtkaz.Click += new System.EventHandler(this.buttonOtkaz_Click);
            // 
            // labelBalance
            // 
            this.labelBalance.Location = new System.Drawing.Point(433, 405);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(240, 44);
            this.labelBalance.TabIndex = 7;
            this.labelBalance.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 554);
            this.Controls.Add(this.labelBalance);
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

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.Label labelClientMinutes;
        private System.Windows.Forms.Label labelPc1;
        private System.Windows.Forms.Label labelPc2;
        private System.Windows.Forms.Label labelPc3;
        private System.Windows.Forms.Button buttonPc1;
        private System.Windows.Forms.Button buttonPc2;
        private System.Windows.Forms.Button buttonPc3;
        private System.Windows.Forms.Button buttonOtkaz;
        private System.Windows.Forms.Label labelBalance;
    }
}

