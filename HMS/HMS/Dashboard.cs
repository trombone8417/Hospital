using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtName.Text;
                String address = txtAddress.Text;
                Int64 contact = Convert.ToInt64(txtContact.Text);
                int age = Convert.ToInt32(txtAge.Text);
                String gender = comboGender.Text;
                String blood = txtBlood.Text;
                String any = txtAny.Text;
                int pid = Convert.ToInt32(txtPID.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-E4UN3CO;initial catalog=hospital;integrated security=true;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into AddPatient values ('" + name + "','" + address + "'," + contact + "," + age + ",'" + gender + "','"+ blood + "','" + any + "'," + pid + ");";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();

                DA.Fill(DS);
            }
            catch (Exception)
            {
                MessageBox.Show("indvalid data format or invalid pid");
            }

            MessageBox.Show("Data Saved!");

            txtName.Clear();
            txtAddress.Clear();
            txtContact.Clear();
            txtAge.Clear();
            txtBlood.Clear();
            txtAny.Clear();
            txtPID.Clear();
            comboGender.ResetText();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                int pid = Convert.ToInt32(textBox1.Text);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-E4UN3CO;initial catalog=hospital;integrated security=true;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from AddPatient where pid = " + pid + "";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = Convert.ToInt32(textBox1.Text);
                String sympt = txtBxSymptoms.Text;
                String diag = txtBxDiagonosis.Text;
                String medicine = txtBxMedicines.Text;
                String ward = comboBxWard.Text;
                String wardType = comboBxWardType.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-E4UN3CO;initial catalog=hospital;integrated security=true;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into PatientMore values (" + pid + ",'" + sympt +"','" + diag + "','" + medicine + "','" + ward + "','"+ wardType + "');"; ;

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
            }
            catch (Exception)
            {
                MessageBox.Show("Any field is empty 'OR' Data is in WRONG format");
            }

            MessageBox.Show("Data Saved!");

            textBox1.Clear();
            txtBxSymptoms.Clear();
            txtBxDiagonosis.Clear();
            txtBxMedicines.Clear();
            comboBxWard.ResetText();
            comboBxWardType.ResetText();

        }
    }
}
