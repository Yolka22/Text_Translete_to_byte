namespace Text_Translete_to_byte
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
            this.Init_textbox = new System.Windows.Forms.TextBox();
            this.Save_button = new System.Windows.Forms.Button();
            this.Load_button = new System.Windows.Forms.Button();
            this.Translate_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Init_textbox
            // 
            this.Init_textbox.Location = new System.Drawing.Point(57, 12);
            this.Init_textbox.Multiline = true;
            this.Init_textbox.Name = "Init_textbox";
            this.Init_textbox.Size = new System.Drawing.Size(681, 380);
            this.Init_textbox.TabIndex = 0;
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(538, 410);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(75, 23);
            this.Save_button.TabIndex = 1;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Load_button
            // 
            this.Load_button.Location = new System.Drawing.Point(73, 410);
            this.Load_button.Name = "Load_button";
            this.Load_button.Size = new System.Drawing.Size(75, 23);
            this.Load_button.TabIndex = 2;
            this.Load_button.Text = "Load";
            this.Load_button.UseVisualStyleBackColor = true;
            this.Load_button.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // Translate_button
            // 
            this.Translate_button.Location = new System.Drawing.Point(268, 409);
            this.Translate_button.Name = "Translate_button";
            this.Translate_button.Size = new System.Drawing.Size(199, 23);
            this.Translate_button.TabIndex = 3;
            this.Translate_button.Text = "Translate";
            this.Translate_button.UseVisualStyleBackColor = true;
            this.Translate_button.Click += new System.EventHandler(this.Translate_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.Translate_button);
            this.Controls.Add(this.Load_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Init_textbox);
            this.Name = "Form1";
            this.Text = "Text_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Init_textbox;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Load_button;
        private System.Windows.Forms.Button Translate_button;
    }
}

