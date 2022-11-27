namespace SQL_Perf_Light
{
    partial class SQLServerTreeView
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
            this.treeViewSQL = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewSQL
            // 
            this.treeViewSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewSQL.Location = new System.Drawing.Point(13, 49);
            this.treeViewSQL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeViewSQL.Name = "treeViewSQL";
            this.treeViewSQL.Size = new System.Drawing.Size(392, 949);
            this.treeViewSQL.TabIndex = 0;
            this.treeViewSQL.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewSQL_NodeMouseClick);
            this.treeViewSQL.Click += new System.EventHandler(this.treeViewSQL_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(429, 49);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1112, 949);
            this.dataGridView1.TabIndex = 1;
            // 
            // SQLServerTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 1050);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeViewSQL);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SQLServerTreeView";
            this.Text = "SQLServerTreeView";
            this.Load += new System.EventHandler(this.SQLServerTreeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewSQL;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}