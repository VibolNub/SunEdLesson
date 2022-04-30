namespace ClassInheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            clsStudent stu = new clsStudent();

            
           
            if (txtScore.Text == "")
            {
                MessageBox.Show("Please enter student score!");
            }
            else
            {
                stu.name = txtStuName.Text;
                stu.gender = txtGender.Text;
                stu.dob = txtDoB.Text;
                stu.address = txtAddr.Text;
                stu.score = int.Parse(txtScore.Text);
                dgvStu.Rows.Add(stu.name, stu.gender, stu.dob, stu.address, stu.score);
                txtStuName.Focus();
            }
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult sms = MessageBox.Show("Do you want to update this information?", "Question",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(sms == DialogResult.Yes)
            {
                if (dgvStu.Rows.Count >= 0)
                {
                    dgvStu.Rows[dgvStu.CurrentRow.Index].Cells["colName"].Value = txtStuName.Text;
                    dgvStu.Rows[dgvStu.CurrentRow.Index].Cells["colGender"].Value = txtGender.Text;
                    dgvStu.Rows[dgvStu.CurrentRow.Index].Cells["colDoB"].Value = txtDoB.Text;
                    dgvStu.Rows[dgvStu.CurrentRow.Index].Cells["colAddress"].Value = txtAddr.Text;
                    dgvStu.Rows[dgvStu.CurrentRow.Index].Cells["colScore"].Value = txtScore.Text;
                }
            }
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvStu.SelectedRows)
            {
                dgvStu.Rows.RemoveAt(row.Index);
            }
        }

        private void dgvStu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStu.Rows[e.RowIndex];
                txtStuName.Text = row.Cells["colName"].Value.ToString();
                txtGender.Text = row.Cells["colGender"].Value.ToString();
                txtDoB.Text = row.Cells["colDoB"].Value.ToString();
                txtAddr.Text = row.Cells["colAddress"].Value.ToString();
                txtScore.Text = row.Cells["colScore"].Value.ToString();

            }
        }
    }
}