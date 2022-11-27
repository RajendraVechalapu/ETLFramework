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
            this.components = new System.ComponentModel.Container();
            this.grdViewDataLoadDetails = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAllDatabases = new System.Windows.Forms.ComboBox();
            this.treeViewSQL = new System.Windows.Forms.TreeView();
            this.lblSelectedTable = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.txtSourceServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSourceDatabase = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSourceTable = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSourceQuery = new System.Windows.Forms.TextBox();
            this.lblLandingTable = new System.Windows.Forms.Label();
            this.txtLandingTargetTable = new System.Windows.Forms.TextBox();
            this.lblTargetTable = new System.Windows.Forms.Label();
            this.txtTargetTable = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdentityColumn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWatermarkColumn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKeyColumns = new System.Windows.Forms.TextBox();
            this.btnInsertUpdate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSourceTableColumnNames = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewDataLoadDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // grdViewDataLoadDetails
            // 
            this.grdViewDataLoadDetails.AllowUserToAddRows = false;
            this.grdViewDataLoadDetails.AllowUserToDeleteRows = false;
            this.grdViewDataLoadDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.grdViewDataLoadDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.grdViewDataLoadDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewDataLoadDetails.Location = new System.Drawing.Point(283, 549);
            this.grdViewDataLoadDetails.Name = "grdViewDataLoadDetails";
            this.grdViewDataLoadDetails.Size = new System.Drawing.Size(1135, 204);
            this.grdViewDataLoadDetails.TabIndex = 1;
            this.grdViewDataLoadDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.grdViewDataLoadDetails.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Source Database";
            // 
            // cmbAllDatabases
            // 
            this.cmbAllDatabases.FormattingEnabled = true;
            this.cmbAllDatabases.Location = new System.Drawing.Point(92, 16);
            this.cmbAllDatabases.Name = "cmbAllDatabases";
            this.cmbAllDatabases.Size = new System.Drawing.Size(189, 21);
            this.cmbAllDatabases.TabIndex = 25;
            this.cmbAllDatabases.SelectedIndexChanged += new System.EventHandler(this.cmbAllDatabases_SelectedIndexChanged);
            // 
            // treeViewSQL
            // 
            this.treeViewSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewSQL.HideSelection = false;
            this.treeViewSQL.LineColor = System.Drawing.Color.Coral;
            this.treeViewSQL.Location = new System.Drawing.Point(7, 82);
            this.treeViewSQL.Name = "treeViewSQL";
            this.treeViewSQL.Size = new System.Drawing.Size(272, 671);
            this.treeViewSQL.TabIndex = 43;
            this.treeViewSQL.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSQL_AfterSelect);
            // 
            // lblSelectedTable
            // 
            this.lblSelectedTable.AutoSize = true;
            this.lblSelectedTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedTable.Location = new System.Drawing.Point(714, 24);
            this.lblSelectedTable.Name = "lblSelectedTable";
            this.lblSelectedTable.Size = new System.Drawing.Size(139, 13);
            this.lblSelectedTable.TabIndex = 44;
            this.lblSelectedTable.Text = "Selected Table : Empty";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(304, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 23);
            this.btnRefresh.TabIndex = 45;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSourceServer
            // 
            this.txtSourceServer.Location = new System.Drawing.Point(285, 82);
            this.txtSourceServer.Name = "txtSourceServer";
            this.txtSourceServer.Size = new System.Drawing.Size(193, 20);
            this.txtSourceServer.TabIndex = 47;
            this.txtSourceServer.Text = "[LAPTOP-NI0AKHN4]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "SourceServer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "SourceDatabase";
            // 
            // txtSourceDatabase
            // 
            this.txtSourceDatabase.Location = new System.Drawing.Point(501, 82);
            this.txtSourceDatabase.Name = "txtSourceDatabase";
            this.txtSourceDatabase.Size = new System.Drawing.Size(193, 20);
            this.txtSourceDatabase.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(717, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "SourceTable";
            // 
            // txtSourceTable
            // 
            this.txtSourceTable.Location = new System.Drawing.Point(717, 82);
            this.txtSourceTable.Name = "txtSourceTable";
            this.txtSourceTable.Size = new System.Drawing.Size(193, 20);
            this.txtSourceTable.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "SourceQuery";
            // 
            // txtSourceQuery
            // 
            this.txtSourceQuery.Location = new System.Drawing.Point(289, 188);
            this.txtSourceQuery.Multiline = true;
            this.txtSourceQuery.Name = "txtSourceQuery";
            this.txtSourceQuery.Size = new System.Drawing.Size(603, 342);
            this.txtSourceQuery.TabIndex = 53;
            // 
            // lblLandingTable
            // 
            this.lblLandingTable.AutoSize = true;
            this.lblLandingTable.Location = new System.Drawing.Point(957, 63);
            this.lblLandingTable.Name = "lblLandingTable";
            this.lblLandingTable.Size = new System.Drawing.Size(109, 13);
            this.lblLandingTable.TabIndex = 56;
            this.lblLandingTable.Text = "Landing Target Table";
            // 
            // txtLandingTargetTable
            // 
            this.txtLandingTargetTable.Location = new System.Drawing.Point(957, 82);
            this.txtLandingTargetTable.Name = "txtLandingTargetTable";
            this.txtLandingTargetTable.Size = new System.Drawing.Size(193, 20);
            this.txtLandingTargetTable.TabIndex = 55;
            // 
            // lblTargetTable
            // 
            this.lblTargetTable.AutoSize = true;
            this.lblTargetTable.Location = new System.Drawing.Point(1184, 63);
            this.lblTargetTable.Name = "lblTargetTable";
            this.lblTargetTable.Size = new System.Drawing.Size(68, 13);
            this.lblTargetTable.TabIndex = 58;
            this.lblTargetTable.Text = "Target Table";
            // 
            // txtTargetTable
            // 
            this.txtTargetTable.Location = new System.Drawing.Point(1184, 82);
            this.txtTargetTable.Name = "txtTargetTable";
            this.txtTargetTable.Size = new System.Drawing.Size(193, 20);
            this.txtTargetTable.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1033, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Identity Column";
            // 
            // txtIdentityColumn
            // 
            this.txtIdentityColumn.Location = new System.Drawing.Point(1115, 139);
            this.txtIdentityColumn.Name = "txtIdentityColumn";
            this.txtIdentityColumn.Size = new System.Drawing.Size(193, 20);
            this.txtIdentityColumn.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(718, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Watermark Column";
            // 
            // txtWatermarkColumn
            // 
            this.txtWatermarkColumn.Location = new System.Drawing.Point(821, 140);
            this.txtWatermarkColumn.Name = "txtWatermarkColumn";
            this.txtWatermarkColumn.Size = new System.Drawing.Size(193, 20);
            this.txtWatermarkColumn.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Key/Unique Columns (If multiple use \',\')";
            // 
            // txtKeyColumns
            // 
            this.txtKeyColumns.Location = new System.Drawing.Point(288, 140);
            this.txtKeyColumns.Name = "txtKeyColumns";
            this.txtKeyColumns.Size = new System.Drawing.Size(421, 20);
            this.txtKeyColumns.TabIndex = 59;
            // 
            // btnInsertUpdate
            // 
            this.btnInsertUpdate.Location = new System.Drawing.Point(1273, 271);
            this.btnInsertUpdate.Name = "btnInsertUpdate";
            this.btnInsertUpdate.Size = new System.Drawing.Size(127, 103);
            this.btnInsertUpdate.TabIndex = 65;
            this.btnInsertUpdate.Text = "InsertUpdate DataLoadTable";
            this.btnInsertUpdate.UseVisualStyleBackColor = true;
            this.btnInsertUpdate.Click += new System.EventHandler(this.btnInsertUpdate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 66;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1273, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 68;
            this.label9.Text = "Target/ETL Database";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1273, 210);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(193, 20);
            this.textBox2.TabIndex = 67;
            this.textBox2.Text = "ETLFramework";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1276, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 49);
            this.button1.TabIndex = 69;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(954, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 71;
            this.label10.Text = "Table Columns";
            // 
            // txtSourceTableColumnNames
            // 
            this.txtSourceTableColumnNames.Location = new System.Drawing.Point(957, 188);
            this.txtSourceTableColumnNames.Multiline = true;
            this.txtSourceTableColumnNames.Name = "txtSourceTableColumnNames";
            this.txtSourceTableColumnNames.Size = new System.Drawing.Size(279, 342);
            this.txtSourceTableColumnNames.TabIndex = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1525, 781);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSourceTableColumnNames);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnInsertUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdentityColumn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtWatermarkColumn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtKeyColumns);
            this.Controls.Add(this.lblTargetTable);
            this.Controls.Add(this.txtTargetTable);
            this.Controls.Add(this.lblLandingTable);
            this.Controls.Add(this.txtLandingTargetTable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSourceQuery);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSourceTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSourceDatabase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSourceServer);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblSelectedTable);
            this.Controls.Add(this.treeViewSQL);
            this.Controls.Add(this.cmbAllDatabases);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdViewDataLoadDetails);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Server Diagnostic Information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewDataLoadDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grdViewDataLoadDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAllDatabases;
        private System.Windows.Forms.TreeView treeViewSQL;
        private System.Windows.Forms.Label lblSelectedTable;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.TextBox txtSourceServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSourceDatabase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSourceTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSourceQuery;
        private System.Windows.Forms.Label lblLandingTable;
        private System.Windows.Forms.TextBox txtLandingTargetTable;
        private System.Windows.Forms.Label lblTargetTable;
        private System.Windows.Forms.TextBox txtTargetTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdentityColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWatermarkColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKeyColumns;
        private System.Windows.Forms.Button btnInsertUpdate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSourceTableColumnNames;
    }
}

