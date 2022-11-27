using ClosedXML.Excel;
using DataGridViewAutoFilter;
using System;
using System.Data;
using System.Drawing;
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

        

        
        private string getQuery(string queryText)
        {
            try
            {

            
            var dsInfo = SQLHelper.getDataSet(queryText,"sqlperftool",false);

            foreach (DataRow item in dsInfo.Tables[0].Rows)
            {
                return item[0].ToString();
            }
            return "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return "";
        }
        private void showQuery(string name,string queryText) {
            Clipboard.SetText(name + ":"+queryText);
        }
        
        private void ExportToExcel(DataSet dsInfo,string sheetname)
        {
            try
            {
                //buttonname = buttonname + "" + DateTime.Now.ToShortDateString();
                sheetname = sheetname.Replace(@"[", "").Replace(@"\", "").Replace(@"/", "").Replace(@"?", "").Replace(@"]", "").Replace(@"*", "");
                sheetname = sheetname.Replace(" ","");
                if (sheetname.Length > 20)
                {
                    sheetname = sheetname.Substring(0, Math.Min(sheetname.Length, 20));
                }
                sheetname = sheetname + long.Parse(DateTime.Now.ToString("ddHHmmss"));
                //Match m = Regex.Match(buttonname, @"[\[/?]*]");
                //bool nameIsValid = (m.Success || (string.IsNullOrEmpty(buttonname)) || (buttonname.Length > 31)) ? false : true;
                //if (nameIsValid == false)
                //{
                //    MessageBox.Show("Invalid worksheet name:" + buttonname);
                //    return;
                //}

                string filepath = AppDomain.CurrentDomain.BaseDirectory + " " + sheetname + ".xlsx";
                XLWorkbook wb = new XLWorkbook();

                foreach (DataTable table in dsInfo.Tables)
                {


                    wb.Worksheets.Add(table, sheetname);
                }
                wb.SaveAs(filepath);
                OpenExcel(filepath);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }
        private void OpenExcel(string path)
        {
            System.Diagnostics.Process.Start(path);
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                InitialPageLoadwithAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void InitialPageLoadwithAllData()
        {
            
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            try
            {
                dsInfo = SQLHelper.getDataSet(SQLHelper.fetch_user_databases, "master",true);

                foreach (DataRow item in dsInfo.Tables[0].Rows)
                {
                    string dbname = item[0].ToString();

                    cmbAllDatabases.Items.Add(dbname);
                }

                if (cmbAllDatabases.Items.Count >= 1)
                {
                    cmbAllDatabases.SelectedIndex = 0;
                }

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
            
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            try
            {
                LoadintoTreeView();
                treeViewSQL.Nodes[nodeLevelSelected].Expand();
                treeViewSQL.Nodes[nodeLevelSelected].EnsureVisible();

                dataGridView1.DataSource = null;

                if (grdLoadSelectedOption != "")
                {
                    LoadGridView(grdLoadSelectedOption);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        DataSet dsInfo = null;
        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            if (dsInfo == null || dsInfo.Tables[0].Rows.Count <=0)
            {
                MessageBox.Show("DataSet is empty!");
            }
            else
            {
                ExportToExcel(dsInfo, txtSelectedOption.Text);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
                string columnName = dataGridView1.Columns[columnIndex].Name;
                if (columnName.ToLower() == "tablename")
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row = dataGridView1.SelectedRows[0];
                    if (row.Cells[0].Value != null)
                    {
                        //tableSelectedForColumnSize = row.Cells[0].Value.ToString();
                        lblSelectedTable.Text = "Selected Table : " + row.Cells[0].Value.ToString() + "";
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

            DataSet dsparent = SQLHelper.getDataSet("select distinct grouptext from [perfqueries] order by 1 asc", "sqlperftool",false);
            DataSet dsalltables = SQLHelper.getDataSet(SQLHelper.fetch_user_all_tables_bydatabase, cmbAllDatabases.SelectedItem.ToString(),true);
            foreach (DataRow dr in dsparent.Tables[0].Rows)
            {
                string grouptext = dr["grouptext"].ToString();
                TreeNode tn = new TreeNode(dr["grouptext"].ToString());

                DataSet dschild = SQLHelper.getDataSet("select distinct displaytext,isChildTablesList from [perfqueries] where grouptext='" + grouptext + "' order by 1,2 asc", "sqlperftool",false);

                foreach (DataRow drChild in dschild.Tables[0].Rows)
                {
                    var tndisplaytext=tn.Nodes.Add(drChild["displaytext"].ToString());

                    if (Convert.ToBoolean(drChild["isChildTablesList"].ToString()))
                    {
                        foreach (DataRow item in dsalltables.Tables[0].Rows)
                        {
                            tndisplaytext.Nodes.Add(item["TableName"].ToString());
                        }
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
        string nodeparenttext = "";

        private void treeViewSQL_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ShowStatusChildForm();

            nodeLevelSelected = e.Node.Level;
            selectedOption = e.Node.Text;
            if (e.Node.Parent != null)
            {
                nodeparenttext = e.Node.Parent.Text;
            }

            //using (ProgressBarForm frm=new ProgressBarForm(LoadData))
            //{
            //    frm.ShowDialog(this);
            //}

            LoadData();

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
        void LoadData() {
            try
            {


                
                txtSelectedOption.Text = selectedOption;
                string seletectedNodeParent = string.Empty;

                if (nodeparenttext != "")
                {
                    seletectedNodeParent = nodeparenttext;
                }
                else
                {
                    return;
                }

                if (nodeLevelSelected == 2) // assumption table selected, queries at 2nd level only
                {
                    LoadGridView(seletectedNodeParent);
                }
                else
                {
                    LoadGridView(selectedOption);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        static string grdLoadSelectedOption = "";
        private void LoadGridView(string lcselectedOption)
        {
            try
            {
                grdLoadSelectedOption = lcselectedOption;

                var querytext = getQuery("select [perfquery] from [perfqueries] where displaytext='" + lcselectedOption + "'");

                if (querytext!=string.Empty)
                {
                    Clipboard.SetText(querytext);

                }

                string frmtQueryIfTblExists = string.Format(SQLHelper.fetch_tablename_if_exists, selectedOption);
                var dsTblExists = SQLHelper.getDataSet(frmtQueryIfTblExists, cmbAllDatabases.SelectedItem.ToString(), true);

                if (dsTblExists.Tables[0].Rows.Count <= 0)
                {
                    querytext = querytext.Replace("@tablename", "");
                }
                else
                {
                    querytext = querytext.Replace("@tablename", selectedOption);
                }



                showQuery(selectedOption, querytext);
                if (querytext != "")
                {
                    dsInfo = SQLHelper.getDataSet(querytext, cmbAllDatabases.SelectedItem.ToString(), true);
                    dataGridView1.DataSource = null;
                    
                    dataLoadGrdiview(dsInfo.Tables[0]);
                }
                else
                {
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
        }
        //private void cmbtables_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cmbtables.SelectedItem == null)
        //    {
        //        MessageBox.Show("please select a table.");
        //    }
        //    else
        //    {
        //        if (cmbtables.SelectedItem.ToString() == "")
        //        {
        //            MessageBox.Show("please select a table.");
        //        }
        //        else
        //        {


        //            var querytext = getQuery("select [perfquery] from [perfqueries] where [perfname]='fetch_table_column_size'").Replace("@dbname", cmbAllDatabases.SelectedItem.ToString()).Replace("@tablename", cmbtables.SelectedItem.ToString());
        //            showQuery("fetch_table_column_size", querytext);
        //            dsInfo = SQLHelper.getDataSet(querytext, cmbAllDatabases.SelectedItem.ToString());
        //            dataGridView1.DataSource = null;
        //            if (dsInfo != null)
        //            {
        //                //dataGridView1.DataSource = dsInfo.Tables[0];
        //                dataLoadGrdiview(dsInfo.Tables[0]);
        //            }
        //        }
        //    }
        //}
        private void dataLoadGrdiview(DataTable data) {
            try
            {
                BindingSource dataSource = new BindingSource(data, null);
                dataGridView1.DataSource = dataSource;

                if (dataGridView1.DataSource == null)
                {
                    return;
                }

                // Add the AutoFilter header cell to each column.
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    col.HeaderCell = new
                        DataGridViewAutoFilterColumnHeaderCell(col.HeaderCell);
                }
                //// Format the OrderTotal column as currency. 
                //dataGridView1.Columns["OrderTotal"].DefaultCellStyle.Format = "c";

                // Resize the columns to fit their contents.
                dataGridView1.AutoResizeColumns();

                dataGridView1.MultiSelect = false;
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.RowHeadersVisible = true;
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[0].Cells[0].Style.ForeColor = Color.Blue;

                }
                fillGridColumnWidth(dataGridView1);
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
               // InitialPageLoadwithAllData();

                if (grdLoadSelectedOption != "")
                {
                    LoadGridView(grdLoadSelectedOption);
                }

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
    }
}
