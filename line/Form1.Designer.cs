namespace line
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
            this.button1 = new System.Windows.Forms.Button();
            this.boxX1 = new System.Windows.Forms.TextBox();
            this.boxX2 = new System.Windows.Forms.TextBox();
            this.boxY1 = new System.Windows.Forms.TextBox();
            this.boxY2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Показать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // boxX1
            // 
            this.boxX1.Location = new System.Drawing.Point(130, 54);
            this.boxX1.Name = "boxX1";
            this.boxX1.Size = new System.Drawing.Size(100, 22);
            this.boxX1.TabIndex = 1;
            // 
            // boxX2
            // 
            this.boxX2.Location = new System.Drawing.Point(130, 172);
            this.boxX2.Name = "boxX2";
            this.boxX2.Size = new System.Drawing.Size(100, 22);
            this.boxX2.TabIndex = 2;
            // 
            // boxY1
            // 
            this.boxY1.Location = new System.Drawing.Point(130, 94);
            this.boxY1.Name = "boxY1";
            this.boxY1.Size = new System.Drawing.Size(100, 22);
            this.boxY1.TabIndex = 3;
            // 
            // boxY2
            // 
            this.boxY2.Location = new System.Drawing.Point(130, 211);
            this.boxY2.Name = "boxY2";
            this.boxY2.Size = new System.Drawing.Size(100, 22);
            this.boxY2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "x1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "x2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "y1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "y2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 351);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxY2);
            this.Controls.Add(this.boxY1);
            this.Controls.Add(this.boxX2);
            this.Controls.Add(this.boxX1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Input data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox boxX1;
        private System.Windows.Forms.TextBox boxX2;
        private System.Windows.Forms.TextBox boxY1;
        private System.Windows.Forms.TextBox boxY2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

