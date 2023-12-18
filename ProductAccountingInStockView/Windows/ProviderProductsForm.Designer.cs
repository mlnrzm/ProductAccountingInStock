namespace ProductAccountingInStockView.Windows
{
    partial class ProviderProductsForm
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
            dataGridViewProducts = new System.Windows.Forms.DataGridView();
            buttonAdd = new System.Windows.Forms.Button();
            buttonUpdate = new System.Windows.Forms.Button();
            buttonDelete = new System.Windows.Forms.Button();
            labelProviderName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new System.Drawing.Point(14, 56);
            dataGridViewProducts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.RowTemplate.Height = 29;
            dataGridViewProducts.Size = new System.Drawing.Size(509, 404);
            dataGridViewProducts.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new System.Drawing.Point(558, 56);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(174, 41);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new System.Drawing.Point(558, 118);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new System.Drawing.Size(174, 41);
            buttonUpdate.TabIndex = 2;
            buttonUpdate.Text = "Редактировать";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new System.Drawing.Point(558, 178);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new System.Drawing.Size(174, 41);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelProviderName
            // 
            labelProviderName.AutoSize = true;
            labelProviderName.Location = new System.Drawing.Point(16, 16);
            labelProviderName.Name = "labelProviderName";
            labelProviderName.Size = new System.Drawing.Size(114, 21);
            labelProviderName.TabIndex = 4;
            labelProviderName.Text = "Поставщик: ";
            // 
            // ProviderProductsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(769, 472);
            Controls.Add(labelProviderName);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewProducts);
            Font = new System.Drawing.Font("Gilroy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "ProviderProductsForm";
            Text = "Продукция поставщика";
            Load += ProviderProductsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelProviderName;
    }
}