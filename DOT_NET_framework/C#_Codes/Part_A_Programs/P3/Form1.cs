namespace P3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender, qualification;
            if (radioButton1.Checked)
                gender = "Male";
            else
            if (radioButton2.Checked)
                gender = "FeMale";
            else if (radioButton3.Checked)
                gender = "Other";
            else gender = "Gender not selected.";
            if (checkBox1.Checked)
                qualification = "Post Graduate";
            else if (checkBox2.Checked)
                qualification = "Graduate";
            else if (checkBox3.Checked)
                qualification = "PUC";
            else qualification = "Not Checked";
            MessageBox.Show("Name : " + textBox1.Text + "\nAddress : " + textBox2.Text
           + "\nDOB :" + dateTimePicker1 + "\nGender : " + gender + "\nState : " +
           comboBox1.Text + "\nQualification : " + qualification);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}