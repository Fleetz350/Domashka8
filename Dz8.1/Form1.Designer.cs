
namespace Dz8._1
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
            this.tbRes = new System.Windows.Forms.TextBox();
            this.numeric1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numeric1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRes
            // 
            this.tbRes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbRes.Location = new System.Drawing.Point(94, 12);
            this.tbRes.Name = "tbRes";
            this.tbRes.Size = new System.Drawing.Size(41, 22);
            this.tbRes.TabIndex = 0;
            // 
            // numeric1
            // 
            this.numeric1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numeric1.Location = new System.Drawing.Point(94, 52);
            this.numeric1.Name = "numeric1";
            this.numeric1.Size = new System.Drawing.Size(53, 22);
            this.numeric1.TabIndex = 1;
            this.numeric1.ValueChanged += new System.EventHandler(this.numeric1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 151);
            this.Controls.Add(this.numeric1);
            this.Controls.Add(this.tbRes);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(252, 198);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(252, 198);
            this.Name = "Form1";
            this.Text = "Задание 2";
            ((System.ComponentModel.ISupportInitialize)(this.numeric1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRes;
        private System.Windows.Forms.NumericUpDown numeric1;
    }
}

