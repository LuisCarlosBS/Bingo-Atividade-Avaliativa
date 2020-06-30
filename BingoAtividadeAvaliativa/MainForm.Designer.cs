namespace BingoAtividadeAvaliativa
{
    partial class MainForm
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
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.dataGridViewCard = new System.Windows.Forms.DataGridView();
            this.bDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(12, 12);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Gerar";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // dataGridViewCard
            // 
            this.dataGridViewCard.AllowUserToAddRows = false;
            this.dataGridViewCard.AllowUserToDeleteRows = false;
            this.dataGridViewCard.AutoGenerateColumns = false;
            this.dataGridViewCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bDataGridViewTextBoxColumn,
            this.iDataGridViewTextBoxColumn,
            this.nDataGridViewTextBoxColumn,
            this.gDataGridViewTextBoxColumn,
            this.oDataGridViewTextBoxColumn});
            this.dataGridViewCard.DataSource = this.rowBindingSource;
            this.dataGridViewCard.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewCard.Name = "dataGridViewCard";
            this.dataGridViewCard.ReadOnly = true;
            this.dataGridViewCard.Size = new System.Drawing.Size(545, 180);
            this.dataGridViewCard.TabIndex = 1;
            // 
            // bDataGridViewTextBoxColumn
            // 
            this.bDataGridViewTextBoxColumn.DataPropertyName = "B";
            this.bDataGridViewTextBoxColumn.HeaderText = "B";
            this.bDataGridViewTextBoxColumn.Name = "bDataGridViewTextBoxColumn";
            this.bDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDataGridViewTextBoxColumn
            // 
            this.iDataGridViewTextBoxColumn.DataPropertyName = "I";
            this.iDataGridViewTextBoxColumn.HeaderText = "I";
            this.iDataGridViewTextBoxColumn.Name = "iDataGridViewTextBoxColumn";
            this.iDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nDataGridViewTextBoxColumn
            // 
            this.nDataGridViewTextBoxColumn.DataPropertyName = "N";
            this.nDataGridViewTextBoxColumn.HeaderText = "N";
            this.nDataGridViewTextBoxColumn.Name = "nDataGridViewTextBoxColumn";
            this.nDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gDataGridViewTextBoxColumn
            // 
            this.gDataGridViewTextBoxColumn.DataPropertyName = "G";
            this.gDataGridViewTextBoxColumn.HeaderText = "G";
            this.gDataGridViewTextBoxColumn.Name = "gDataGridViewTextBoxColumn";
            this.gDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oDataGridViewTextBoxColumn
            // 
            this.oDataGridViewTextBoxColumn.DataPropertyName = "O";
            this.oDataGridViewTextBoxColumn.HeaderText = "O";
            this.oDataGridViewTextBoxColumn.Name = "oDataGridViewTextBoxColumn";
            this.oDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rowBindingSource
            // 
            this.rowBindingSource.DataSource = typeof(BingoAtividadeAvaliativa.Entities.Row);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 233);
            this.Controls.Add(this.dataGridViewCard);
            this.Controls.Add(this.buttonGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bingo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.BindingSource rowBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oDataGridViewTextBoxColumn;
    }
}

