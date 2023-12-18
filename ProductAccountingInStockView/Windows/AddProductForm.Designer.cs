namespace ProductAccountingInStockView.Windows
{
    partial class AddProductForm
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
            textBoxName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBoxCost = new System.Windows.Forms.TextBox();
            buttonSave = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Font = new System.Drawing.Font("Gilroy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxName.Location = new System.Drawing.Point(186, 41);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(209, 28);
            textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Gilroy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(25, 44);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(141, 21);
            label1.TabIndex = 1;
            label1.Text = "Наименование:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Gilroy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(25, 94);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 21);
            label2.TabIndex = 2;
            label2.Text = "Стоимость:";
            // 
            // textBoxCost
            // 
            textBoxCost.Font = new System.Drawing.Font("Gilroy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxCost.Location = new System.Drawing.Point(186, 91);
            textBoxCost.Name = "textBoxCost";
            textBoxCost.Size = new System.Drawing.Size(209, 28);
            textBoxCost.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.Font = new System.Drawing.Font("Gilroy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonSave.Location = new System.Drawing.Point(117, 140);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(136, 39);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new System.Drawing.Font("Gilroy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonCancel.Location = new System.Drawing.Point(259, 140);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(136, 39);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(439, 210);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxCost);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Name = "AddProductForm";
            Text = "Продукция";
            Load += AddProductForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}