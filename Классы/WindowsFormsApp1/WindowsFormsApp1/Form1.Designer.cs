namespace WindowsFormsApp1
{
    partial class myForm
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
            this.hello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hello
            // 
            this.hello.Location = new System.Drawing.Point(214, 185);
            this.hello.Name = "hello";
            this.hello.Size = new System.Drawing.Size(248, 77);
            this.hello.TabIndex = 0;
            this.hello.Text = "Click";
            this.hello.UseVisualStyleBackColor = true;
            this.hello.Click += new System.EventHandler(this.hello_Click);
            // 
            // myForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 392);
            this.Controls.Add(this.hello);
            this.Name = "myForm";
            this.Text = "myForm";
            this.Load += new System.EventHandler(this.myForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hello;
    }
}

