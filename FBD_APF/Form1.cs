using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FBD_APF
{
    public partial class Form1 : Form
    {
        private SqlConnection sConnection;
        private TreeNode sTree;
        private int selectIndex;

        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection initCon()
        {
            return new SqlConnection("data source=GECKO;integrated security=true;initial catalog=BarbHut;uid=sa;password=1298;Encrypt=false");
        }

        private bool isConValid(SqlConnection sCon)
        {
            if (sCon == null) sCon = initCon();
            if (sCon.State != ConnectionState.Open) sCon.Open();

            return sCon.State == ConnectionState.Open;

        }

        private static void createObj(string nodeName)
        {
            switch(nodeName)
            {
                case "Club":
                    Club nClub = new Club(0);
                    break;
                case "Employee":
                    Employee nEmployee = new Employee();
                    break;
            }
        }

        private void TableTreeInit()
        {
            if (!isConValid(sConnection)) return;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sConnection;

            if (sTree != null)
                cmd.CommandText = $"SELECT * FROM BARBARIAN_CLUB.{tableTree.SelectedNode.Name}";
            else
                cmd.CommandText = "SELECT * FROM BARBARIAN_CLUB.CLUB";
                SqlDataReader r = cmd.ExecuteReader();

            if(dataBox.Items.Count != 0) dataBox.Items.Clear();
            while (r.Read()){
                Club nClub = new Club(int.Parse(r["NIF"].ToString()));
                nClub.setLocl(r["Localizacao"].ToString());
                nClub.setName(r["Nome"].ToString());

                dataBox.Items.Add(nClub);
            }

            sConnection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sConnection = initCon();
            TableTreeInit();
        }

        private void dataBox_SelectedIndexChanged(object sender, EventArgs e)
        {   
            if(dataBox.SelectedIndex >= 0)  selectIndex = dataBox.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tableTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(tableTree.SelectedNode == null || tableTree.SelectedNode.Name == "rNode") return;
            sTree = tableTree.SelectedNode;
            TableTreeInit();
        }
    }
}
