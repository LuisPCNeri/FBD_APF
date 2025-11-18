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
using FBD_APF.DataClasses;
using FBD_APF.DataClasses.EmplooyeTypes;

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
        private static Club clubInit(int nif, string loc, string name)
        {
            Club nClub = new Club(nif);
            nClub.setLocl(loc);
            nClub.setName(name);
            return nClub;   
        }

        private void createData(string nodeName, SqlDataReader r)
        {
            switch(nodeName)
            {
                case "CLUB":
                    while (r.Read())
                    {
                        Club nClub = new Club(int.Parse(r["NIF"].ToString()));
                        nClub.setLocl(r["Localizacao"].ToString());
                        nClub.setName(r["Nome"].ToString());
                        dataBox.Items.Add(nClub.ToString());
                    }
                    break;
                case "FUNCIONARIO":
                    while (r.Read())
                    {
                        Employee func = new Employee(
                                int.Parse(r["NIF"].ToString()),
                                r["Nome"].ToString(),
                                double.Parse(r["Salario"].ToString()),
                                r["Horario"].ToString(),
                                int.Parse(r["NIF_Club"].ToString())
                        );
                        dataBox.Items.Add(func.ToString());
                    }
                    break;
                case "GERENTE":
                    while (r.Read())
                    {
                        Manager mgr = new Manager(
                                int.Parse(r["NIF"].ToString()),
                                r["Name"].ToString(),
                                double.Parse(r["Salario"].ToString()),
                                r["Horario"].ToString(),
                                int.Parse(r["NIF_Club"].ToString())
                        );
                        dataBox.Items.Add(mgr.ToString());
                    }
                    break;
                case "EQUIPAMENTO":
                    while (r.Read())
                    {
                        Equipment equip = new Equipment(
                                int.Parse(r["Id"].ToString()),
                                r["Nome"].ToString(),
                                r["Estado"].ToString(),
                                int.Parse(r["Quantidade"].ToString()),
                                int.Parse(r["NIF_CLUB"].ToString()),
                                int.Parse(r["NIF_TEC"].ToString())
                        );
                        dataBox.Items.Add(equip.ToString());
                    }
                    break;
                default:
                    return;
            }
        }

        private void TableTreeInit()
        {
            if (!isConValid(sConnection)) return;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sConnection;

            string nName = null;

            if (sTree != null){
                cmd.CommandText = $"SELECT * FROM BARBARIAN_CLUB.{sTree.Name}";
                nName = sTree.Name;
            }
            else
                cmd.CommandText = "SELECT * FROM BARBARIAN_CLUB.CLUB";
                SqlDataReader r = cmd.ExecuteReader();

            if(dataBox.Items.Count != 0) dataBox.Items.Clear();

            if(nName == null) createData("CLUB", r); 
            else createData(nName, r);

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
