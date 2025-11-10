using System;
using System.IO;
using System.Windows.Input;

namespace UserFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string age = txtAge.Text;

            using (StreamWriter writer = new StreamWriter("userdata.txt", true))
            {
                writer.WriteLine($"Name: {name}, Age: {age}");
            }

            MessageBox.Show("Data saved successfully");
        }
    }
}