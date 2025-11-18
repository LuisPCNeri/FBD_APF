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
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Clubs");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Employees");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Clients");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Equipements");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Aulas");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Exercises");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Managers");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Clients by Class");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("PTs");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Training plans");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Subscription Plans");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Tecnicians");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("BarbClub", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34,
            treeNode35,
            treeNode36,
            treeNode37,
            treeNode38});
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
            this.dataBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dataBox.FormattingEnabled = true;
            this.dataBox.ItemHeight = 20;
            this.dataBox.Location = new System.Drawing.Point(33, 243);
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(721, 164);
            this.dataBox.TabIndex = 0;
            this.dataBox.SelectedIndexChanged += new System.EventHandler(this.dataBox_SelectedIndexChanged);
            // 
            // tableTree
            // 
            this.tableTree.BackColor = System.Drawing.SystemColors.Control;
            this.tableTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableTree.Location = new System.Drawing.Point(33, 13);
            this.tableTree.Name = "tableTree";
            treeNode27.Name = "CLUB";
            treeNode27.Text = "Clubs";
            treeNode28.Name = "FUNCIONARIO";
            treeNode28.Text = "Employees";
            treeNode29.Name = "CLIENTE";
            treeNode29.Text = "Clients";
            treeNode30.Name = "EQUIPAMENTO";
            treeNode30.Text = "Equipements";
            treeNode31.Name = "AULA_DE_GRUPO";
            treeNode31.Text = "Aulas";
            treeNode32.Name = "EXERCICIO";
            treeNode32.Text = "Exercises";
            treeNode33.Name = "GERENTE";
            treeNode33.Text = "Managers";
            treeNode34.Name = "INSCREVE_CLIENTE_AULA";
            treeNode34.Text = "Clients by Class";
            treeNode35.Name = "PERSONAL_TRAINER";
            treeNode35.Text = "PTs";
            treeNode36.Name = "PLANO_TREINO";
            treeNode36.Text = "Training plans";
            treeNode37.Name = "SUBSCRICAO";
            treeNode37.Text = "Subscription Plans";
            treeNode38.Name = "TECNICO";
            treeNode38.Text = "Tecnicians";
            treeNode39.Name = "rNode";
            treeNode39.Text = "BarbClub";
            this.tableTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode39});
            this.tableTree.Size = new System.Drawing.Size(217, 204);
            this.tableTree.TabIndex = 1;
            this.tableTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tableTree_AfterSelect);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(621, 48);
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
            this.button2.Location = new System.Drawing.Point(621, 113);
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
            this.button3.Location = new System.Drawing.Point(621, 178);
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

