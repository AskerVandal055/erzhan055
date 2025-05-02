namespace RICHCOLLECTOR
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
            this.labelPointInfo = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.btnShowPoint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPointInfo
            // 
            this.labelPointInfo.AutoSize = true;
            this.labelPointInfo.Location = new System.Drawing.Point(122, 23);
            this.labelPointInfo.Name = "labelPointInfo";
            this.labelPointInfo.Size = new System.Drawing.Size(35, 13);
            this.labelPointInfo.TabIndex = 0;
            this.labelPointInfo.Text = "label1";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(125, 57);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 2;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(125, 189);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 20);
            this.textBoxY.TabIndex = 3;
            // 
            // btnShowPoint
            // 
            this.btnShowPoint.Location = new System.Drawing.Point(363, 349);
            this.btnShowPoint.Name = "btnShowPoint";
            this.btnShowPoint.Size = new System.Drawing.Size(75, 23);
            this.btnShowPoint.TabIndex = 4;
            this.btnShowPoint.Text = "button1";
            this.btnShowPoint.UseVisualStyleBackColor = true;
            this.btnShowPoint.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowPoint);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelPointInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPointInfo;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Button btnShowPoint;
    }
}

