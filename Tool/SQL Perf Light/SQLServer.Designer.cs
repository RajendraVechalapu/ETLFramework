namespace SQL_Perf_Light
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAllDatabases = new System.Windows.Forms.ComboBox();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.treeViewSQL = new System.Windows.Forms.TreeView();
            this.lblSelectedTable = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtSelectedOption = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(425, 70);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1233, 851);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Database";
            // 
            // cmbAllDatabases
            // 
            this.cmbAllDatabases.FormattingEnabled = true;
            this.cmbAllDatabases.Location = new System.Drawing.Point(100, 25);
            this.cmbAllDatabases.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbAllDatabases.Name = "cmbAllDatabases";
            this.cmbAllDatabases.Size = new System.Drawing.Size(319, 28);
            this.cmbAllDatabases.TabIndex = 25;
            this.cmbAllDatabases.SelectedIndexChanged += new System.EventHandler(this.cmbAllDatabases_SelectedIndexChanged);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(1527, 25);
            this.btnExportToExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(158, 35);
            this.btnExportToExcel.TabIndex = 39;
            this.btnExportToExcel.Text = "Export to Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // treeViewSQL
            // 
            this.treeViewSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewSQL.HideSelection = false;
            this.treeViewSQL.LineColor = System.Drawing.Color.Coral;
            this.treeViewSQL.Location = new System.Drawing.Point(11, 71);
            this.treeViewSQL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeViewSQL.Name = "treeViewSQL";
            this.treeViewSQL.Size = new System.Drawing.Size(406, 850);
            this.treeViewSQL.TabIndex = 43;
            this.treeViewSQL.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSQL_AfterSelect);
            // 
            // lblSelectedTable
            // 
            this.lblSelectedTable.AutoSize = true;
            this.lblSelectedTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedTable.Location = new System.Drawing.Point(1046, 37);
            this.lblSelectedTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedTable.Name = "lblSelectedTable";
            this.lblSelectedTable.Size = new System.Drawing.Size(204, 20);
            this.lblSelectedTable.TabIndex = 44;
            this.lblSelectedTable.Text = "Selected Table : Empty";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(706, 25);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(135, 35);
            this.btnRefresh.TabIndex = 45;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSelectedOption
            // 
            this.txtSelectedOption.Location = new System.Drawing.Point(452, 25);
            this.txtSelectedOption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSelectedOption.Name = "txtSelectedOption";
            this.txtSelectedOption.Size = new System.Drawing.Size(244, 26);
            this.txtSelectedOption.TabIndex = 46;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1713, 930);
            this.Controls.Add(this.txtSelectedOption);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblSelectedTable);
            this.Controls.Add(this.treeViewSQL);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.cmbAllDatabases);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Server Diagnostic Information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAllDatabases;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.TreeView treeViewSQL;
        private System.Windows.Forms.Label lblSelectedTable;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSelectedOption;
    }
}

