namespace WindowsFormsApp16
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
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtSide = new System.Windows.Forms.Button();
            this.listShapes = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(97, 90);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(229, 20);
            this.txtRadius.TabIndex = 0;
            // 
            // txtSide
            // 
            this.txtSide.Location = new System.Drawing.Point(97, 159);
            this.txtSide.Name = "txtSide";
            this.txtSide.Size = new System.Drawing.Size(229, 54);
            this.txtSide.TabIndex = 1;
            this.txtSide.Text = "button1";
            this.txtSide.UseVisualStyleBackColor = true;
            this.txtSide.Click += new System.EventHandler(this.button1_Click);
            // 
            // listShapes
            // 
            this.listShapes.FormattingEnabled = true;
            this.listShapes.Location = new System.Drawing.Point(97, 298);
            this.listShapes.Name = "listShapes";
            this.listShapes.Size = new System.Drawing.Size(228, 95);
            this.listShapes.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 465);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(359, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 631);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listShapes);
            this.Controls.Add(this.txtSide);
            this.Controls.Add(this.txtRadius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Button txtSide;
        private System.Windows.Forms.ListBox listShapes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

