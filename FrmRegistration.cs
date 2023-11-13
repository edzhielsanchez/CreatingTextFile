using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace CreatingTextFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            String[] data =
            {
                $"Student Number: {txtStudNo.Text}",
                $"Full Name: {txtLastName.Text}, {txtFirstName.Text} {txtMI.Text}",
                $"Program: {cbProgram.Text}",
                $"Gender: {cbGender.Text}",
                $"Age: {txtAge.Text}",
                $"Birthday: {dateTimePicker.Value}",
                $"Contact Number: {txtContact.Text}"
            };

            using (StreamWriter write = new StreamWriter($"{path}\\{txtLastName.Text} {txtStudNo.Text}.txt"))
            {
                foreach (var item in data)
                {
                    write.WriteLine(item);
                }
            }
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            List<string> programs = new List<string>
            {
                "Bachelor of Science in Computer Science",
                "Bachelor of Science in Information Technology",
                "Bachelor of Science in Information Systems",
                "Bachelor of Science in Computer Engineering"
            };

            cbProgram.DataSource = programs;

            List<string> gender = new List<string>
            {
                "Female",
                "Male",
                "Others"
            };

            cbGender.DataSource = gender;
        }
    }
}
