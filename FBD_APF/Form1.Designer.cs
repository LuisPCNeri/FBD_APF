namespace FBD_APF
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Clubs");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Employees");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Clients");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Equipements");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Aulas");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Exercises");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Managers");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Clients by Class");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("PTs");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Training plans");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Subscription Plans");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Tecnicians");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("BarbClub", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            this.dataBox = new System.Windows.Forms.ListBox();
            this.tableTree = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // dataBox
            // 
            this.dataBox.FormattingEnabled = true;
            this.dataBox.Location = new System.Drawing.Point(33, 243);
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(699, 173);
            this.dataBox.TabIndex = 0;
            this.dataBox.SelectedIndexChanged += new System.EventHandler(this.dataBox_SelectedIndexChanged);
            // 
            // tableTree
            // 
            this.tableTree.Location = new System.Drawing.Point(33, 13);
            this.tableTree.Name = "tableTree";
            treeNode1.Name = "CLUB";
            treeNode1.Text = "Clubs";
            treeNode2.Name = "FUNCIONARIO";
            treeNode2.Text = "Employees";
            treeNode3.Name = "CLIENTE";
            treeNode3.Text = "Clients";
            treeNode4.Name = "EQUIPAMENTO";
            treeNode4.Text = "Equipements";
            treeNode5.Name = "AULA_DE_GRUPO";
            treeNode5.Text = "Aulas";
            treeNode6.Name = "EXERCICIO";
            treeNode6.Text = "Exercises";
            treeNode7.Name = "GERENTE";
            treeNode7.Text = "Managers";
            treeNode8.Name = "INSCREVE_CLIENTE_AULA";
            treeNode8.Text = "Clients by Class";
            treeNode9.Name = "PERSONAL_TRAINER";
            treeNode9.Text = "PTs";
            treeNode10.Name = "PLANO_TREINO";
            treeNode10.Text = "Training plans";
            treeNode11.Name = "SUBSCRICAO";
            treeNode11.Text = "Subscription Plans";
            treeNode12.Name = "TECNICO";
            treeNode12.Text = "Tecnicians";
            treeNode13.Name = "rNode";
            treeNode13.Text = "BarbClub";
            this.tableTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.tableTree.Size = new System.Drawing.Size(121, 204);
            this.tableTree.TabIndex = 1;
            this.tableTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tableTree_AfterSelect);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(598, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(598, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(598, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 39);
            this.button3.TabIndex = 4;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableTree);
            this.Controls.Add(this.dataBox);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox dataBox;
        private System.Windows.Forms.TreeView tableTree;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList imageList1;
    }
}

