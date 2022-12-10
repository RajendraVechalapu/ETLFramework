using BIFramework;
//using DataGridViewAutoFilter;
using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace SQL_Perf_Light
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            //Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            //int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            //int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            //this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            //this.Size = new Size(w, h);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }

        

        
        //private string getQuery(string queryText)
        //{
        //    try
        //    {

            
        //    //var dsInfo = SQLHelper.getDataSet(queryText,"sqlperftool",false);
        //    var dsInfo = SQLHelper.getDataSet(queryText,"sqlperftool",false);

        //    foreach (DataRow item in dsInfo.Tables[0].Rows)
        //    {
        //        return item[0].ToString();
        //    }
        //    return "";
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //    return "";
        //}
      
        //private void showQuery(string name,string queryText) {
        //    Clipboard.SetText(name + ":"+queryText);
        //}
        
        //private void ExportToExcel(DataSet dsInfo,string sheetname)
        //{
        //    try
        //    {
        //        //buttonname = buttonname + "" + DateTime.Now.ToShortDateString();
        //        sheetname = sheetname.Replace(@"[", "").Replace(@"\", "").Replace(@"/", "").Replace(@"?", "").Replace(@"]", "").Replace(@"*", "");
        //        sheetname = sheetname.Replace(" ","");
        //        if (sheetname.Length > 20)
        //        {
        //            sheetname = sheetname.Substring(0, Math.Min(sheetname.Length, 20));
        //        }
        //        sheetname = sheetname + long.Parse(DateTime.Now.ToString("ddHHmmss"));
        //        //Match m = Regex.Match(buttonname, @"[\[/?]*]");
        //        //bool nameIsValid = (m.Success || (string.IsNullOrEmpty(buttonname)) || (buttonname.Length > 31)) ? false : true;
        //        //if (nameIsValid == false)
        //        //{
        //        //    MessageBox.Show("Invalid worksheet name:" + buttonname);
        //        //    return;
        //        //}

        //        string filepath = AppDomain.CurrentDomain.BaseDirectory + " " + sheetname + ".xlsx";
        //        XLWorkbook wb = new XLWorkbook();

        //        foreach (DataTable table in dsInfo.Tables)
        //        {


        //            wb.Worksheets.Add(table, sheetname);
        //        }
        //        wb.SaveAs(filepath);
        //        OpenExcel(filepath);
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
            

        //}
        private void OpenExcel(string path)
        {
            System.Diagnostics.Process.Start(path);
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SQLHelper.InitializeIcons();
                InitialPageLoadwithAllData();
                fetch_DataLoadDetails(nodetextselect);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void InitialPageLoadwithAllData()
        {
            
            grdViewDataLoadDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            try
            {
                txtSourceServer.Text= SQLHelper.source_sql_server;
                txtSourceDatabase.Text = SQLHelper.source_sql_db;
                txtTargetServer.Text = SQLHelper.target_sql_server;
                txtTargetDatabase.Text = SQLHelper.target_sql_db;

                LoadintoTreeView();
                treeViewSQL.Nodes[0].Expand();
                treeViewSQL.Nodes[0].EnsureVisible();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void InitialPageLoadwithAllDataDBChanged()
        {
            
            grdViewDataLoadDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            try
            {
                LoadintoTreeView();
                treeViewSQL.Nodes[nodeLevelSelected].Expand();
               treeViewSQL.Nodes[nodeLevelSelected].EnsureVisible();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        DataSet dsInfo = null;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int columnIndex = grdViewDataLoadDetails.CurrentCell.ColumnIndex;
                string columnName = grdViewDataLoadDetails.Columns[columnIndex].Name;
                if (columnName.ToLower() == "tablename")
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row = grdViewDataLoadDetails.SelectedRows[0];
                    if (row.Cells[0].Value != null)
                    {
                        //tableSelectedForColumnSize = row.Cells[0].Value.ToString();
                        //lblSelectedTable.Text = "Selected Table : " + row.Cells[0].Value.ToString() + "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       

        private void cmbAllDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                InitialPageLoadwithAllDataDBChanged();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadintoTreeView()
        {
            try
            {

            
                treeViewSQL.Nodes.Clear();
                
                string sourceTablesQuery = "SELECT '['+TABLE_SCHEMA+'].['+TABLE_NAME+']' TableName FROM [INFORMATION_SCHEMA].[TABLES] ORDER BY 1";

                DataSet dsGetSourceTables = SQLHelper.getDataSet(sourceTablesQuery, SQLHelper.source_connectionString);
                DataSet dsGetTargetTables = SQLHelper.getDataSet(sourceTablesQuery, SQLHelper.target_connectionString);

                foreach (DataRow dr in dsGetSourceTables.Tables[0].Rows)
                {
                    string sourceTableName = dr["TableName"].ToString();
                    TreeNode tn = new TreeNode(sourceTableName);
                    foreach (DataRow drtarget in dsGetTargetTables.Tables[0].Rows)
                    {
                        string targetTableName = drtarget["TableName"].ToString();

                        if (SQLHelper.trimstringtocompare(sourceTableName) == SQLHelper.trimstringtocompare(targetTableName))
                        {
                            tn.BackColor = Color.LightSkyBlue;
                        }
                    }
                    
                    treeViewSQL.Nodes.Add(tn);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
      
        string selectedOption = "";
        int nodeLevelSelected = 0;
        string nodetextselect = "";

        private void treeViewSQL_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ShowStatusChildForm();

            nodeLevelSelected = e.Node.Level;
            selectedOption = e.Node.Text;
            
            txtSourceTable.Text = selectedOption;
            txtLandingTargetTable.Text = txtSourceTable.Text.Replace(".[", ".[Landing");
            txtTargetTable.Text = txtSourceTable.Text;

            fetch_TableColumns();
            fetch_DataLoadDetails(selectedOption);

            if (grdViewDataLoadDetails.Rows.Count <=0)
            {
                btnTargetTablesCreate.Enabled = false;

            }
            else
            {
                btnTargetTablesCreate.Enabled = true;
            }

            string script =   SQLHelper.GenerateTableScript(txtSourceTable.Text);

            

            //script = "--Script Created ";
            script = script + Environment.NewLine ;

            txtTargetTableScript.Text = script;

            script=script.Replace(".[", ".[Landing");

            txtLandingTableScript.Text = script; ;

            if (obj != null)
            {
                obj.Close();
            }

        }
        private void fillGridColumnWidth(DataGridView dgv)
        {

            //dgv.AutoGenerateColumns = false;
            //datagrid has calculated it's widths so we can store them
            for (int i = 0; i <= dgv.Columns.Count - 1; i++)
            {
                if (i <= 3)
                {
                    if (i <= dgv.Columns.Count - 1)
                    {
                        dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    }
                    else
                    {
                        dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }

                    //store autosized widths
                    int colw = dgv.Columns[i].Width;
                    //remove autosizing
                    dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    //set width to calculated by autosize
                    dgv.Columns[i].Width = colw;
                }

            }
            dgv.ScrollBars = ScrollBars.Both;
            //dgv.AutoResizeRows();
            //dgv.AutoResizeColumns();

        }
        void fetch_DataLoadDetails(string nodetextselect) {
                        try
                        {
                            nodetextselect = nodetextselect.Replace("[", "");
                            nodetextselect = nodetextselect.Replace("]", "");

                            string query = SQLHelper.fetch_DataLoadDetails + " WHERE replace(replace(SourceTable,'[',''),']','')	= '" + nodetextselect + "'";
                            if (nodetextselect == "")
                            {
                                query = SQLHelper.fetch_DataLoadDetails;
                            }
                            DataSet ds = SQLHelper.getDataSet(query, SQLHelper.target_connectionString_etlframework);
                            dataLoadGrdiview(ds);
               
                                
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
               
        }

        void fetch_TableColumns()
        {
           
                    try
                    {
                        DataSet ds = SQLHelper.fetchTableColumns(txtSourceTable.Text,false);

                    StringBuilder sbSelect = new StringBuilder();
                StringBuilder sbSourceTableColumnNames = new StringBuilder();
                

                sbSelect.AppendLine("SELECT ");
                
                
                int i = 1;

                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            if (i==1)
                            {
                                sbSelect.AppendLine("" + row["ColumnName"].ToString());
                                sbSourceTableColumnNames.AppendLine("" + row["ColumnName"].ToString());
                                
                            }
                            else
                            {
                                sbSelect.AppendLine("," + row["ColumnName"].ToString());
                                sbSourceTableColumnNames.AppendLine("," + row["ColumnName"].ToString());
                                
                            }

                            i = i + 1;
                        
                        }

                           sbSelect.AppendLine(" FROM " + txtSourceServer.Text+"."+txtSourceDatabase.Text+"."+txtSourceTable.Text+"");

                            txtSourceQuery.Text = sbSelect.ToString();
                            txtSourceTableColumnNames.Text = sbSourceTableColumnNames.ToString();
                            

            }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

            try
            {
                DataSet ds2 = SQLHelper.fetchTableColumnsProperties(txtSourceTable.Text);

                txtKeyColumns.Text = "";
                txtWatermarkColumn.Text = "";
                txtIdentityColumn.Text = "";
                foreach (DataRow row in ds2.Tables[0].Rows)
                {
                    string columnname= row["ColumnName"].ToString();
                    string CONSTRAINT_TYPE = row["CONSTRAINT_TYPE"].ToString();

                    if (CONSTRAINT_TYPE== "PRIMARY KEY" || CONSTRAINT_TYPE == "UNIQUE")
                    {
                        txtKeyColumns.Text = "["+columnname+"]";
                    }
                    if (CONSTRAINT_TYPE == "timestamp")
                    {
                        txtWatermarkColumn.Text = "[" + columnname + "]";
                    }
                    if (CONSTRAINT_TYPE == "Identity")
                    {
                        txtIdentityColumn.Text = "[" + columnname + "]";
                    }
                }

                

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void dataLoadGrdiview(DataSet ds) {
            try
            {
                grdViewDataLoadDetails.DataSource = ds.Tables[0];
                                
                // Resize the columns to fit their contents.
                grdViewDataLoadDetails.AutoResizeColumns();

                grdViewDataLoadDetails.MultiSelect = false;
                grdViewDataLoadDetails.ReadOnly = true;
                grdViewDataLoadDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grdViewDataLoadDetails.RowHeadersVisible = true;
                if (grdViewDataLoadDetails.Rows.Count > 0)
                {
                    grdViewDataLoadDetails.Rows[0].Cells[0].Style.ForeColor = Color.Blue;

                }
                fillGridColumnWidth(grdViewDataLoadDetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            
        }
        ProgressWindow obj = null;
        public void ShowStatusChildForm()
        {
            obj = null;
            obj = new ProgressWindow();
            obj.Show();
            int x = this.DesktopBounds.Left + (this.Width - obj.Width) / 2;
            int y = this.DesktopBounds.Top + (this.Height - obj.Height) / 2;
            obj.SetDesktopLocation(x, y);

            Application.DoEvents();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowStatusChildForm();

            try
            {
                if (obj != null)
                {
                    obj.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void btnInsertUpdate_Click(object sender, EventArgs e)
        {
            SQLHelper.InsertUpdateDataLoadTable(txtSourceTable.Text, txtSourceQuery.Text, 
                txtLandingTargetTable.Text, txtTargetTable.Text, txtWatermarkColumn.Text, txtIdentityColumn.Text, txtKeyColumns.Text,txtSourceTableColumnNames.Text );
            try
            {
               // InitialPageLoadwithAllData();
                fetch_DataLoadDetails(nodetextselect);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btnTargetTablesCreate.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SQLHelper.deleteFromDataLoadTable(txtSourceTable.Text,SQLHelper.target_sql_db_etlframework);
            try
            {
                //InitialPageLoadwithAllData();
                fetch_DataLoadDetails(nodetextselect);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            lblMessage.Text = "Successfully deleted.";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnTargetTablesCreate_Click(object sender, EventArgs e)
        {
            try
            {
                SQLHelper.executeTargetTableScripts(txtLandingTableScript.Text, txtTargetTableScript.Text);

                lblMessage.Text="Successfully Created.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }


}
