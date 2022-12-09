using BIFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Perf_Light
{
    public partial class SQLServerTreeView : Form
    {
        public SQLServerTreeView()
        {
            InitializeComponent();
        }

        private void SQLServerTreeView_Load(object sender, EventArgs e)
        {
            //LoadintoTreeView();
            treeViewSQL.ExpandAll();
        }
        
        //private void LoadintoTreeView()
        //{
        //    DataSet dsparent = SQLHelper.getDataSet("select distinct grouptext from [perfqueries]", "sqlperftool",false);
        //    foreach (DataRow dr in dsparent.Tables[0].Rows)
        //    {
        //        string grouptext = dr["grouptext"].ToString();
        //        TreeNode tn = new TreeNode(dr["grouptext"].ToString());

        //        DataSet dschild = SQLHelper.getDataSet("select distinct displaytext from [perfqueries] where grouptext='"+ grouptext + "'", "sqlperftool",false);

        //        foreach (DataRow drChild in dschild.Tables[0].Rows)
        //        {
        //            tn.Nodes.Add(drChild["displaytext"].ToString());
        //        }
        //        treeViewSQL.Nodes.Add(tn);
        //    }
        //}

        private void treeViewSQL_Click(object sender, EventArgs e)
        {
            
        }

        private void treeViewSQL_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }
    }
}
