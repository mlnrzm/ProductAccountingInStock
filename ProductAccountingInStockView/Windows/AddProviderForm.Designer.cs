namespace ProductAccountingInStockView.Windows
{
    partial class AddProviderForm
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
            textBoxFIO = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            textBoxAddress = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            textBoxPhone = new System.Windows.Forms.TextBox();
            buttonSave = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // textBoxFIO
            // 
            textBoxFIO.Location = new System.Drawing.Point(253, 43);
            textBoxFIO.Name = "textBoxFIO";
            textBoxFIO.Size = new System.Drawing.Size(354, 28);
            textBoxFIO.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(26, 46);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(196, 21);
            label1.TabIndex = 1;
            label1.Text = "Наименование (ФИО):";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new System.Drawing.Point(136, 94);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new System.Drawing.Size(471, 28);
            textBoxAddress.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(26, 97);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(68, 21);
            label2.TabIndex = 3;
            label2.Text = "Адрес:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(26, 143);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(87, 21);
            label3.TabIndex = 4;
            label3.Text = "Телефон:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new System.Drawing.Point(136, 140);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new System.Drawing.Size(471, 28);
            textBoxPhone.TabIndex = 5;
            // 
            // buttonSave
            // 
            buttonSave.Location = new System.Drawing.Point(335, 189);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(133, 41);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new System.Drawing.Point(474, 189);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(133, 41);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // AddProviderForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(645, 267);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxPhone);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxAddress);
            Controls.Add(label1);
            Controls.Add(textBoxFIO);
            Font = new System.Drawing.Font("Gilroy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "AddProviderForm";
            Text = "Поставщик";
            Load += AddProviderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}