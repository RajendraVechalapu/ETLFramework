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
            this.treeViewSQL = new System.Windows.Forms.TreeView();
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
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSourceTableColumnNames = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTargetDatabase = new System.Windows.Forms.TextBox();
            this.txtTargetServer = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLandingTableScript = new System.Windows.Forms.TextBox();
            this.txtTargetTableScript = new System.Windows.Forms.TextBox();
            this.btnTargetTablesCreate = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewDataLoadDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdViewDataLoadDetails
            // 
            this.grdViewDataLoadDetails.AllowUserToAddRows = false;
            this.grdViewDataLoadDetails.AllowUserToDeleteRows = false;
            this.grdViewDataLoadDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.grdViewDataLoadDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.grdViewDataLoadDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewDataLoadDetails.Location = new System.Drawing.Point(285, 101);
            this.grdViewDataLoadDetails.Name = "grdViewDataLoadDetails";
            this.grdViewDataLoadDetails.Size = new System.Drawing.Size(1231, 207);
            this.grdViewDataLoadDetails.TabIndex = 1;
            this.grdViewDataLoadDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.grdViewDataLoadDetails.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // treeViewSQL
            // 
            this.treeViewSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewSQL.HideSelection = false;
            this.treeViewSQL.LineColor = System.Drawing.Color.Coral;
            this.treeViewSQL.Location = new System.Drawing.Point(7, 101);
            this.treeViewSQL.Name = "treeViewSQL";
            this.treeViewSQL.Size = new System.Drawing.Size(272, 652);
            this.treeViewSQL.TabIndex = 43;
            this.treeViewSQL.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSQL_AfterSelect);
            // 
            // txtSourceServer
            // 
            this.txtSourceServer.BackColor = System.Drawing.Color.White;
            this.txtSourceServer.Location = new System.Drawing.Point(3, 16);
            this.txtSourceServer.Name = "txtSourceServer";
            this.txtSourceServer.ReadOnly = true;
            this.txtSourceServer.Size = new System.Drawing.Size(239, 20);
            this.txtSourceServer.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "SourceServer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "SourceDatabase";
            // 
            // txtSourceDatabase
            // 
            this.txtSourceDatabase.BackColor = System.Drawing.Color.White;
            this.txtSourceDatabase.Location = new System.Drawing.Point(248, 16);
            this.txtSourceDatabase.Name = "txtSourceDatabase";
            this.txtSourceDatabase.ReadOnly = true;
            this.txtSourceDatabase.Size = new System.Drawing.Size(178, 20);
            this.txtSourceDatabase.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "SourceTable";
            // 
            // txtSourceTable
            // 
            this.txtSourceTable.BackColor = System.Drawing.Color.White;
            this.txtSourceTable.Location = new System.Drawing.Point(90, 52);
            this.txtSourceTable.Name = "txtSourceTable";
            this.txtSourceTable.ReadOnly = true;
            this.txtSourceTable.Size = new System.Drawing.Size(159, 20);
            this.txtSourceTable.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "SourceQuery";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtSourceQuery
            // 
            this.txtSourceQuery.BackColor = System.Drawing.Color.White;
            this.txtSourceQuery.Location = new System.Drawing.Point(297, 330);
            this.txtSourceQuery.Multiline = true;
            this.txtSourceQuery.Name = "txtSourceQuery";
            this.txtSourceQuery.ReadOnly = true;
            this.txtSourceQuery.Size = new System.Drawing.Size(565, 126);
            this.txtSourceQuery.TabIndex = 53;
            this.txtSourceQuery.WordWrap = false;
            // 
            // lblLandingTable
            // 
            this.lblLandingTable.AutoSize = true;
            this.lblLandingTable.Location = new System.Drawing.Point(1539, 337);
            this.lblLandingTable.Name = "lblLandingTable";
            this.lblLandingTable.Size = new System.Drawing.Size(109, 13);
            this.lblLandingTable.TabIndex = 56;
            this.lblLandingTable.Text = "Landing Target Table";
            // 
            // txtLandingTargetTable
            // 
            this.txtLandingTargetTable.BackColor = System.Drawing.Color.White;
            this.txtLandingTargetTable.Location = new System.Drawing.Point(1542, 354);
            this.txtLandingTargetTable.Name = "txtLandingTargetTable";
            this.txtLandingTargetTable.ReadOnly = true;
            this.txtLandingTargetTable.Size = new System.Drawing.Size(193, 20);
            this.txtLandingTargetTable.TabIndex = 55;
            // 
            // lblTargetTable
            // 
            this.lblTargetTable.AutoSize = true;
            this.lblTargetTable.Location = new System.Drawing.Point(1542, 389);
            this.lblTargetTable.Name = "lblTargetTable";
            this.lblTargetTable.Size = new System.Drawing.Size(68, 13);
            this.lblTargetTable.TabIndex = 58;
            this.lblTargetTable.Text = "Target Table";
            // 
            // txtTargetTable
            // 
            this.txtTargetTable.BackColor = System.Drawing.Color.White;
            this.txtTargetTable.Location = new System.Drawing.Point(1542, 405);
            this.txtTargetTable.Name = "txtTargetTable";
            this.txtTargetTable.ReadOnly = true;
            this.txtTargetTable.Size = new System.Drawing.Size(193, 20);
            this.txtTargetTable.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1034, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Identity Column";
            // 
            // txtIdentityColumn
            // 
            this.txtIdentityColumn.BackColor = System.Drawing.Color.White;
            this.txtIdentityColumn.Location = new System.Drawing.Point(1116, 64);
            this.txtIdentityColumn.Name = "txtIdentityColumn";
            this.txtIdentityColumn.ReadOnly = true;
            this.txtIdentityColumn.Size = new System.Drawing.Size(193, 20);
            this.txtIdentityColumn.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(719, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Watermark Column";
            // 
            // txtWatermarkColumn
            // 
            this.txtWatermarkColumn.BackColor = System.Drawing.Color.White;
            this.txtWatermarkColumn.Location = new System.Drawing.Point(822, 65);
            this.txtWatermarkColumn.Name = "txtWatermarkColumn";
            this.txtWatermarkColumn.ReadOnly = true;
            this.txtWatermarkColumn.Size = new System.Drawing.Size(193, 20);
            this.txtWatermarkColumn.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Key/Unique Columns (If multiple use \',\')";
            // 
            // txtKeyColumns
            // 
            this.txtKeyColumns.BackColor = System.Drawing.Color.White;
            this.txtKeyColumns.Location = new System.Drawing.Point(289, 65);
            this.txtKeyColumns.Name = "txtKeyColumns";
            this.txtKeyColumns.ReadOnly = true;
            this.txtKeyColumns.Size = new System.Drawing.Size(421, 20);
            this.txtKeyColumns.TabIndex = 59;
            // 
            // btnInsertUpdate
            // 
            this.btnInsertUpdate.Location = new System.Drawing.Point(1542, 92);
            this.btnInsertUpdate.Name = "btnInsertUpdate";
            this.btnInsertUpdate.Size = new System.Drawing.Size(199, 60);
            this.btnInsertUpdate.TabIndex = 65;
            this.btnInsertUpdate.Text = "InsertUpdate DataLoadTable";
            this.btnInsertUpdate.UseVisualStyleBackColor = true;
            this.btnInsertUpdate.Click += new System.EventHandler(this.btnInsertUpdate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1009, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 68;
            this.label9.Text = "Target/ETL Database";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(1009, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(193, 20);
            this.textBox2.TabIndex = 67;
            this.textBox2.Text = "ETLFramework";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1632, 172);
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
            this.label10.Location = new System.Drawing.Point(981, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 71;
            this.label10.Text = "Table Columns";
            // 
            // txtSourceTableColumnNames
            // 
            this.txtSourceTableColumnNames.BackColor = System.Drawing.Color.White;
            this.txtSourceTableColumnNames.Location = new System.Drawing.Point(984, 334);
            this.txtSourceTableColumnNames.Multiline = true;
            this.txtSourceTableColumnNames.Name = "txtSourceTableColumnNames";
            this.txtSourceTableColumnNames.ReadOnly = true;
            this.txtSourceTableColumnNames.Size = new System.Drawing.Size(532, 126);
            this.txtSourceTableColumnNames.TabIndex = 70;
            this.txtSourceTableColumnNames.WordWrap = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtTargetDatabase, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTargetServer, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSourceServer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSourceDatabase, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(982, 44);
            this.tableLayoutPanel1.TabIndex = 72;
            // 
            // txtTargetDatabase
            // 
            this.txtTargetDatabase.BackColor = System.Drawing.Color.White;
            this.txtTargetDatabase.Location = new System.Drawing.Point(802, 16);
            this.txtTargetDatabase.Name = "txtTargetDatabase";
            this.txtTargetDatabase.ReadOnly = true;
            this.txtTargetDatabase.Size = new System.Drawing.Size(178, 20);
            this.txtTargetDatabase.TabIndex = 54;
            // 
            // txtTargetServer
            // 
            this.txtTargetServer.BackColor = System.Drawing.Color.White;
            this.txtTargetServer.Location = new System.Drawing.Point(432, 16);
            this.txtTargetServer.Name = "txtTargetServer";
            this.txtTargetServer.ReadOnly = true;
            this.txtTargetServer.Size = new System.Drawing.Size(364, 20);
            this.txtTargetServer.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(802, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "TargetDatabase";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "TargetServer";
            // 
            // txtLandingTableScript
            // 
            this.txtLandingTableScript.BackColor = System.Drawing.Color.White;
            this.txtLandingTableScript.Location = new System.Drawing.Point(301, 482);
            this.txtLandingTableScript.Multiline = true;
            this.txtLandingTableScript.Name = "txtLandingTableScript";
            this.txtLandingTableScript.ReadOnly = true;
            this.txtLandingTableScript.Size = new System.Drawing.Size(561, 271);
            this.txtLandingTableScript.TabIndex = 73;
            // 
            // txtTargetTableScript
            // 
            this.txtTargetTableScript.BackColor = System.Drawing.Color.White;
            this.txtTargetTableScript.Location = new System.Drawing.Point(984, 482);
            this.txtTargetTableScript.Multiline = true;
            this.txtTargetTableScript.Name = "txtTargetTableScript";
            this.txtTargetTableScript.ReadOnly = true;
            this.txtTargetTableScript.Size = new System.Drawing.Size(532, 271);
            this.txtTargetTableScript.TabIndex = 74;
            // 
            // btnTargetTablesCreate
            // 
            this.btnTargetTablesCreate.Location = new System.Drawing.Point(1522, 482);
            this.btnTargetTablesCreate.Name = "btnTargetTablesCreate";
            this.btnTargetTablesCreate.Size = new System.Drawing.Size(213, 49);
            this.btnTargetTablesCreate.TabIndex = 75;
            this.btnTargetTablesCreate.Text = "Target Tables Scripts Create";
            this.btnTargetTablesCreate.UseVisualStyleBackColor = true;
            this.btnTargetTablesCreate.Click += new System.EventHandler(this.btnTargetTablesCreate_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(1522, 545);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(54, 17);
            this.lblMessage.TabIndex = 76;
            this.lblMessage.Text = "label12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1753, 781);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnTargetTablesCreate);
            this.Controls.Add(this.txtTargetTableScript);
            this.Controls.Add(this.txtLandingTableScript);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSourceTableColumnNames);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox2);
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
            this.Controls.Add(this.treeViewSQL);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grdViewDataLoadDetails;
        private System.Windows.Forms.TreeView treeViewSQL;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSourceTableColumnNames;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtTargetDatabase;
        private System.Windows.Forms.TextBox txtTargetServer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLandingTableScript;
        private System.Windows.Forms.TextBox txtTargetTableScript;
        private System.Windows.Forms.Button btnTargetTablesCreate;
        private System.Windows.Forms.Label lblMessage;
    }
}

