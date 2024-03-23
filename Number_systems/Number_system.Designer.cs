namespace Number_systems
{
    partial class Number_system_2_19
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
            this.lbl_title_programm = new System.Windows.Forms.Label();
            this.lbl_user_number = new System.Windows.Forms.Label();
            this.txtBox_user_number = new System.Windows.Forms.TextBox();
            this.btn_convert_number = new System.Windows.Forms.Button();
            this.txtBox_new_number = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_title_programm
            // 
            this.lbl_title_programm.AutoSize = true;
            this.lbl_title_programm.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_title_programm.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_title_programm.Location = new System.Drawing.Point(87, 67);
            this.lbl_title_programm.Name = "lbl_title_programm";
            this.lbl_title_programm.Size = new System.Drawing.Size(494, 33);
            this.lbl_title_programm.TabIndex = 0;
            this.lbl_title_programm.Text = "Перевод числа из 2-ой СС в 7-ую:";
            // 
            // lbl_user_number
            // 
            this.lbl_user_number.AutoSize = true;
            this.lbl_user_number.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_user_number.Location = new System.Drawing.Point(139, 176);
            this.lbl_user_number.Name = "lbl_user_number";
            this.lbl_user_number.Size = new System.Drawing.Size(162, 25);
            this.lbl_user_number.TabIndex = 1;
            this.lbl_user_number.Text = "Введите число:";
            // 
            // txtBox_user_number
            // 
            this.txtBox_user_number.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_user_number.Location = new System.Drawing.Point(318, 173);
            this.txtBox_user_number.Name = "txtBox_user_number";
            this.txtBox_user_number.Size = new System.Drawing.Size(195, 33);
            this.txtBox_user_number.TabIndex = 2;
            // 
            // btn_convert_number
            // 
            this.btn_convert_number.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_convert_number.Location = new System.Drawing.Point(144, 244);
            this.btn_convert_number.Name = "btn_convert_number";
            this.btn_convert_number.Size = new System.Drawing.Size(369, 53);
            this.btn_convert_number.TabIndex = 3;
            this.btn_convert_number.Text = "Перевести";
            this.btn_convert_number.UseVisualStyleBackColor = true;
            this.btn_convert_number.Click += new System.EventHandler(this.btn_convert_number_Click);
            // 
            // txtBox_new_number
            // 
            this.txtBox_new_number.BackColor = System.Drawing.SystemColors.Control;
            this.txtBox_new_number.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_new_number.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBox_new_number.Location = new System.Drawing.Point(144, 336);
            this.txtBox_new_number.Multiline = true;
            this.txtBox_new_number.Name = "txtBox_new_number";
            this.txtBox_new_number.ReadOnly = true;
            this.txtBox_new_number.Size = new System.Drawing.Size(369, 72);
            this.txtBox_new_number.TabIndex = 4;
            this.txtBox_new_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Number_system_2_19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 490);
            this.Controls.Add(this.txtBox_new_number);
            this.Controls.Add(this.btn_convert_number);
            this.Controls.Add(this.txtBox_user_number);
            this.Controls.Add(this.lbl_user_number);
            this.Controls.Add(this.lbl_title_programm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Number_system_2_19";
            this.Text = "Системы счисления";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title_programm;
        private System.Windows.Forms.Label lbl_user_number;
        private System.Windows.Forms.TextBox txtBox_user_number;
        private System.Windows.Forms.Button btn_convert_number;
        private System.Windows.Forms.TextBox txtBox_new_number;
    }
}

