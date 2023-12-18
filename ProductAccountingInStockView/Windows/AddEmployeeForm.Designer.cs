namespace ProductAccountingInStockView.Windows
{
    partial class AddEmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            textBoxFIO = new System.Windows.Forms.TextBox();
            textBoxLogin = new System.Windows.Forms.TextBox();
            textBoxPassword = new System.Windows.Forms.TextBox();
            comboBoxPosts = new System.Windows.Forms.ComboBox();
            buttonAdd = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(40, 53);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 21);
            label1.TabIndex = 0;
            label1.Text = "ФИО:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(40, 95);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 21);
            label2.TabIndex = 1;
            label2.Text = "Логин:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(40, 139);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(77, 21);
            label3.TabIndex = 2;
            label3.Text = "Пароль:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(40, 186);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(106, 21);
            label4.TabIndex = 3;
            label4.Text = "Должность:";
            // 
            // textBoxFIO
            // 
            textBoxFIO.Location = new System.Drawing.Point(170, 50);
            textBoxFIO.Name = "textBoxFIO";
            textBoxFIO.Size = new System.Drawing.Size(269, 28);
            textBoxFIO.TabIndex = 4;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new System.Drawing.Point(170, 92);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new System.Drawing.Size(269, 28);
            textBoxLogin.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new System.Drawing.Point(170, 136);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new System.Drawing.Size(269, 28);
            textBoxPassword.TabIndex = 6;
            // 
            // comboBoxPosts
            // 
            comboBoxPosts.FormattingEnabled = true;
            comboBoxPosts.Location = new System.Drawing.Point(170, 183);
            comboBoxPosts.Name = "comboBoxPosts";
            comboBoxPosts.Size = new System.Drawing.Size(269, 29);
            comboBoxPosts.TabIndex = 7;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new System.Drawing.Point(181, 234);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(126, 36);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Сохранить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new System.Drawing.Point(313, 234);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(126, 36);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(481, 314);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            Controls.Add(comboBoxPosts);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxFIO);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Gilroy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "AddEmployeeForm";
            Text = "Добавление сотрудника склада";
            Load += AddEmployeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.ComboBox comboBoxPosts;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}