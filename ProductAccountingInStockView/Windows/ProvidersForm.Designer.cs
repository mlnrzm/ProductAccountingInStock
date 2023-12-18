namespace ProductAccountingInStockView.Windows
{
    partial class ProvidersForm
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
            dataGridViewProviders = new System.Windows.Forms.DataGridView();
            buttonAdd = new System.Windows.Forms.Button();
            buttonDelete = new System.Windows.Forms.Button();
            buttonProducts = new System.Windows.Forms.Button();
            buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProviders).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProviders
            // 
            dataGridViewProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProviders.Location = new System.Drawing.Point(12, 10);
            dataGridViewProviders.Name = "dataGridViewProviders";
            dataGridViewProviders.RowHeadersWidth = 51;
            dataGridViewProviders.RowTemplate.Height = 29;
            dataGridViewProviders.Size = new System.Drawing.Size(766, 542);
            dataGridViewProviders.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new System.Drawing.Point(803, 36);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(248, 38);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new System.Drawing.Point(803, 148);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new System.Drawing.Size(248, 38);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonProducts
            // 
            buttonProducts.Location = new System.Drawing.Point(803, 201);
            buttonProducts.Name = "buttonProducts";
            buttonProducts.Size = new System.Drawing.Size(248, 38);
            buttonProducts.TabIndex = 4;
            buttonProducts.Text = "Продукция поставщика";
            buttonProducts.UseVisualStyleBackColor = true;
            buttonProducts.Click += buttonProducts_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new System.Drawing.Point(803, 93);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new System.Drawing.Size(248, 38);
            buttonUpdate.TabIndex = 5;
            buttonUpdate.Text = "Редактировать";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // ProvidersForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1075, 564);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonProducts);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewProviders);
            Font = new System.Drawing.Font("Gilroy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "ProvidersForm";
            Text = "Поставщики";
            Load += ProvidersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProviders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProviders;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button buttonUpdate;
    }
}