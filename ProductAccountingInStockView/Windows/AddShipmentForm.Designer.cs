namespace ProductAccountingInStockView.Windows
{
    partial class AddShipmentForm
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
            comboBoxProvider = new System.Windows.Forms.ComboBox();
            comboBoxDirection = new System.Windows.Forms.ComboBox();
            dataGridViewProducts = new System.Windows.Forms.DataGridView();
            buttonAddProduct = new System.Windows.Forms.Button();
            buttonSave = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            comboBoxProducts = new System.Windows.Forms.ComboBox();
            buttonDelProduct = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            textBoxCount = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(33, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(109, 21);
            label1.TabIndex = 0;
            label1.Text = "Поставщик:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(33, 82);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(130, 21);
            label2.TabIndex = 1;
            label2.Text = "Направление:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Gilroy Bold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(136, 141);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(232, 22);
            label3.TabIndex = 2;
            label3.Text = "Поставляемая продукция:";
            // 
            // comboBoxProvider
            // 
            comboBoxProvider.FormattingEnabled = true;
            comboBoxProvider.Location = new System.Drawing.Point(178, 23);
            comboBoxProvider.Name = "comboBoxProvider";
            comboBoxProvider.Size = new System.Drawing.Size(290, 29);
            comboBoxProvider.TabIndex = 3;
            comboBoxProvider.SelectedIndexChanged += comboBoxProvider_SelectedIndexChanged;
            comboBoxProvider.SelectedValueChanged += comboBoxProvider_SelectedValueChanged;
            // 
            // comboBoxDirection
            // 
            comboBoxDirection.FormattingEnabled = true;
            comboBoxDirection.Location = new System.Drawing.Point(178, 79);
            comboBoxDirection.Name = "comboBoxDirection";
            comboBoxDirection.Size = new System.Drawing.Size(290, 29);
            comboBoxDirection.TabIndex = 4;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, ProductName, Count });
            dataGridViewProducts.Location = new System.Drawing.Point(33, 325);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.RowTemplate.Height = 29;
            dataGridViewProducts.Size = new System.Drawing.Size(435, 267);
            dataGridViewProducts.TabIndex = 5;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Location = new System.Drawing.Point(221, 273);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new System.Drawing.Size(117, 32);
            buttonAddProduct.TabIndex = 6;
            buttonAddProduct.Text = "Добавить";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new System.Drawing.Point(158, 613);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(150, 30);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new System.Drawing.Point(318, 613);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(150, 30);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // comboBoxProducts
            // 
            comboBoxProducts.FormattingEnabled = true;
            comboBoxProducts.Location = new System.Drawing.Point(178, 188);
            comboBoxProducts.Name = "comboBoxProducts";
            comboBoxProducts.Size = new System.Drawing.Size(290, 29);
            comboBoxProducts.TabIndex = 9;
            // 
            // buttonDelProduct
            // 
            buttonDelProduct.Location = new System.Drawing.Point(351, 273);
            buttonDelProduct.Name = "buttonDelProduct";
            buttonDelProduct.Size = new System.Drawing.Size(117, 32);
            buttonDelProduct.TabIndex = 10;
            buttonDelProduct.Text = "Удалить";
            buttonDelProduct.UseVisualStyleBackColor = true;
            buttonDelProduct.Click += buttonDelProduct_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(44, 188);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(107, 21);
            label4.TabIndex = 11;
            label4.Text = "Продукция:";
            // 
            // textBoxCount
            // 
            textBoxCount.Location = new System.Drawing.Point(178, 227);
            textBoxCount.Name = "textBoxCount";
            textBoxCount.Size = new System.Drawing.Size(125, 28);
            textBoxCount.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(44, 230);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(113, 21);
            label5.TabIndex = 13;
            label5.Text = "Количество:";
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Наименование";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.Width = 125;
            // 
            // Count
            // 
            Count.HeaderText = "Количество";
            Count.MinimumWidth = 6;
            Count.Name = "Count";
            Count.Width = 125;
            // 
            // AddShipmentForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            ClientSize = new System.Drawing.Size(502, 660);
            Controls.Add(label5);
            Controls.Add(textBoxCount);
            Controls.Add(label4);
            Controls.Add(buttonDelProduct);
            Controls.Add(comboBoxProducts);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(buttonAddProduct);
            Controls.Add(dataGridViewProducts);
            Controls.Add(comboBoxDirection);
            Controls.Add(comboBoxProvider);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Gilroy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "AddShipmentForm";
            Text = "Формирование поставки";
            Load += AddShipmentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxProvider;
        private System.Windows.Forms.ComboBox comboBoxDirection;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.Button buttonDelProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
    }
}