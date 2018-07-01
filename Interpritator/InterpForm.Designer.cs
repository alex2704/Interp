namespace Interpritator
{
    partial class InterpForm
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
            this.Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(13, 13);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(257, 20);
            this.Input.TabIndex = 0;
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "=";
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(295, 16);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(10, 13);
            this.Output.TabIndex = 2;
            this.Output.Text = " ";
            // 
            // InterpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 45);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input);
            this.Name = "InterpForm";
            this.Text = "Интерпритатор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Output;
    }
}

