namespace ProductAccountingInStockView.Windows
{
    partial class AuthorizationForm
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
            textBoxLogin = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            textBoxPassword = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            buttonSignIn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Gilroy", 13.7999992F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(110, 51);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(163, 27);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(110, 129);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(0, 21);
            label2.TabIndex = 1;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new System.Drawing.Point(122, 119);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new System.Drawing.Size(220, 28);
            textBoxLogin.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(39, 122);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(65, 21);
            label3.TabIndex = 3;
            label3.Text = "Логин:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new System.Drawing.Point(122, 176);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new System.Drawing.Size(220, 28);
            textBoxPassword.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(39, 179);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(77, 21);
            label4.TabIndex = 5;
            label4.Text = "Пароль:";
            // 
            // buttonSignIn
            // 
            buttonSignIn.Location = new System.Drawing.Point(122, 235);
            buttonSignIn.Name = "buttonSignIn";
            buttonSignIn.Size = new System.Drawing.Size(135, 42);
            buttonSignIn.TabIndex = 6;
            buttonSignIn.Text = "Войти";
            buttonSignIn.UseVisualStyleBackColor = true;
            buttonSignIn.Click += buttonSignIn_Click;
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.AliceBlue;
            ClientSize = new System.Drawing.Size(384, 316);
            Controls.Add(buttonSignIn);
            Controls.Add(label4);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(textBoxLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Gilroy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "AuthorizationForm";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSignIn;
    }
}