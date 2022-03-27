using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            treeView.Nodes.Add("par1", "Parent 1");
            treeView.Nodes["par1"].Nodes.Add("child11", "Child 1.1");
            treeView.Nodes["par1"].Nodes["child11"].Nodes.Add("child111","Child 1.1.1");
            treeView.Nodes["par1"].Nodes["child11"].Nodes.Add("child112","Child 1.1.2");
            treeView.Nodes["par1"].Nodes.Add("child12", "Child 1.2");
            treeView.Nodes["par1"].Nodes["child12"].Nodes.Add("child121", "Child 1.2.1");
            treeView.Nodes.Add("par2", "Parent 2");
            treeView.Nodes["par2"].Nodes.Add("child21", "Child 2.1");
            treeView.Nodes["par2"].Nodes.Add("child22", "Child 2.2");
        }
    }
}
