namespace ProductAccountingInStockView.Windows
{
    partial class ShipmentsForm
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
            dataGridViewShipments = new System.Windows.Forms.DataGridView();
            buttonImport = new System.Windows.Forms.Button();
            buttonExport = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            buttonReport = new System.Windows.Forms.Button();
            buttonAdd = new System.Windows.Forms.Button();
            buttonSend = new System.Windows.Forms.Button();
            buttonFinish = new System.Windows.Forms.Button();
            buttonFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewShipments).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewShipments
            // 
            dataGridViewShipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewShipments.Location = new System.Drawing.Point(31, 60);
            dataGridViewShipments.Name = "dataGridViewShipments";
            dataGridViewShipments.RowHeadersWidth = 51;
            dataGridViewShipments.RowTemplate.Height = 29;
            dataGridViewShipments.Size = new System.Drawing.Size(1081, 513);
            dataGridViewShipments.TabIndex = 0;
            // 
            // buttonImport
            // 
            buttonImport.Location = new System.Drawing.Point(158, 15);
            buttonImport.Name = "buttonImport";
            buttonImport.Size = new System.Drawing.Size(96, 28);
            buttonImport.TabIndex = 1;
            buttonImport.Text = "Импорт";
            buttonImport.UseVisualStyleBackColor = true;
            buttonImport.Click += buttonImport_Click;
            // 
            // buttonExport
            // 
            buttonExport.Location = new System.Drawing.Point(260, 15);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new System.Drawing.Size(92, 28);
            buttonExport.TabIndex = 2;
            buttonExport.Text = "Экспорт";
            buttonExport.UseVisualStyleBackColor = true;
            buttonExport.Click += buttonExport_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(31, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(121, 21);
            label1.TabIndex = 3;
            label1.Text = "Фильтровать:";
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Location = new System.Drawing.Point(546, 19);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new System.Drawing.Size(250, 28);
            dateTimePickerFrom.TabIndex = 4;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Location = new System.Drawing.Point(862, 19);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new System.Drawing.Size(250, 28);
            dateTimePickerTo.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(497, 22);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(27, 21);
            label2.TabIndex = 6;
            label2.Text = "C:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(816, 22);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(37, 21);
            label3.TabIndex = 7;
            label3.Text = "По:";
            // 
            // buttonReport
            // 
            buttonReport.Location = new System.Drawing.Point(1129, 517);
            buttonReport.Name = "buttonReport";
            buttonReport.Size = new System.Drawing.Size(217, 36);
            buttonReport.TabIndex = 8;
            buttonReport.Text = "Отчёт";
            buttonReport.UseVisualStyleBackColor = true;
            buttonReport.Click += buttonReport_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new System.Drawing.Point(1129, 98);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(217, 37);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "Оформить поставку";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSend
            // 
            buttonSend.Location = new System.Drawing.Point(1129, 158);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new System.Drawing.Size(217, 37);
            buttonSend.TabIndex = 10;
            buttonSend.Text = "Отправить";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // buttonFinish
            // 
            buttonFinish.Location = new System.Drawing.Point(1129, 220);
            buttonFinish.Name = "buttonFinish";
            buttonFinish.Size = new System.Drawing.Size(217, 37);
            buttonFinish.TabIndex = 11;
            buttonFinish.Text = "Сообщить о прибытии";
            buttonFinish.UseVisualStyleBackColor = true;
            buttonFinish.Click += buttonFinish_Click;
            // 
            // buttonFilter
            // 
            buttonFilter.Location = new System.Drawing.Point(1129, 17);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new System.Drawing.Size(217, 30);
            buttonFilter.TabIndex = 12;
            buttonFilter.Text = "Фильтровать по дате";
            buttonFilter.UseVisualStyleBackColor = true;
            buttonFilter.Click += buttonFilter_Click;
            // 
            // ShipmentsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1367, 600);
            Controls.Add(buttonFilter);
            Controls.Add(buttonFinish);
            Controls.Add(buttonSend);
            Controls.Add(buttonAdd);
            Controls.Add(buttonReport);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePickerTo);
            Controls.Add(dateTimePickerFrom);
            Controls.Add(label1);
            Controls.Add(buttonExport);
            Controls.Add(buttonImport);
            Controls.Add(dataGridViewShipments);
            Font = new System.Drawing.Font("Gilroy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "ShipmentsForm";
            Text = "Поставки";
            Load += ShipmentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewShipments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShipments;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Button buttonFilter;
    }
}