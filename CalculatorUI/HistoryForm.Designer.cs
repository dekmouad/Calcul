namespace CalculatorUI
{
    partial class HistoryForm
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
            this.components = new System.ComponentModel.Container();
            this.LstResultBox = new System.Windows.Forms.TextBox();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calculatorDataSet = new CalculatorUI.CalculatorDataSet();
            this.calculatorTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calculator_TableTableAdapter = new CalculatorUI.CalculatorDataSetTableAdapters.Calculator_TableTableAdapter();
            this.num1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LstResultBox
            // 
            this.LstResultBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LstResultBox.Location = new System.Drawing.Point(46, 40);
            this.LstResultBox.Name = "LstResultBox";
            this.LstResultBox.Size = new System.Drawing.Size(665, 43);
            this.LstResultBox.TabIndex = 3;
            this.LstResultBox.Text = "Last Results";
            this.LstResultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstHistory
            // 
            this.lstHistory.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.ItemHeight = 37;
            this.lstHistory.Location = new System.Drawing.Point(46, 89);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(556, 337);
            this.lstHistory.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num1DataGridViewTextBoxColumn,
            this.optDataGridViewTextBoxColumn,
            this.num2DataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.calculatorTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(46, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(665, 349);
            this.dataGridView1.TabIndex = 4;
            // 
            // calculatorDataSet
            // 
            this.calculatorDataSet.DataSetName = "CalculatorDataSet";
            this.calculatorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calculatorTableBindingSource
            // 
            this.calculatorTableBindingSource.DataMember = "Calculator_Table";
            this.calculatorTableBindingSource.DataSource = this.calculatorDataSet;
            // 
            // calculator_TableTableAdapter
            // 
            this.calculator_TableTableAdapter.ClearBeforeFill = true;
            // 
            // num1DataGridViewTextBoxColumn
            // 
            this.num1DataGridViewTextBoxColumn.DataPropertyName = "Num1";
            this.num1DataGridViewTextBoxColumn.HeaderText = "Num1";
            this.num1DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.num1DataGridViewTextBoxColumn.Name = "num1DataGridViewTextBoxColumn";
            this.num1DataGridViewTextBoxColumn.Width = 150;
            // 
            // optDataGridViewTextBoxColumn
            // 
            this.optDataGridViewTextBoxColumn.DataPropertyName = "Opt";
            this.optDataGridViewTextBoxColumn.HeaderText = "Opt";
            this.optDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.optDataGridViewTextBoxColumn.Name = "optDataGridViewTextBoxColumn";
            this.optDataGridViewTextBoxColumn.Width = 150;
            // 
            // num2DataGridViewTextBoxColumn
            // 
            this.num2DataGridViewTextBoxColumn.DataPropertyName = "Num2";
            this.num2DataGridViewTextBoxColumn.HeaderText = "Num2";
            this.num2DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.num2DataGridViewTextBoxColumn.Name = "num2DataGridViewTextBoxColumn";
            this.num2DataGridViewTextBoxColumn.Width = 150;
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "Result";
            this.resultDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            this.resultDataGridViewTextBoxColumn.Width = 150;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LstResultBox);
            this.Controls.Add(this.lstHistory);
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LstResultBox;
        public System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CalculatorDataSet calculatorDataSet;
        private System.Windows.Forms.BindingSource calculatorTableBindingSource;
        private CalculatorDataSetTableAdapters.Calculator_TableTableAdapter calculator_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn num1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn optDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn num2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
    }
}