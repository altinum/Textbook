using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TextBook
{
    public partial class FormAddStudent : Form
    {
        public Models.Student NewSudent = new Models.Student();

        public FormAddStudent()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        void Check()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                textBoxName.BackColor = Color.Salmon;
                isValid = false;
            }
            else
            {
                textBoxName.BackColor = Color.LightGreen;
            }

            Regex regex = new Regex(@"^[A-Z][A-Z0-9]{5}$");
            if (!regex.IsMatch(textBoxNeptun.Text))
            {
                textBoxNeptun.BackColor = Color.Salmon;
                isValid = false;
            }
            else
            {
                textBoxNeptun.BackColor = Color.LightGreen;
            }

            buttonOk.Enabled = isValid;

        }

        private void FormAddStudent_Load(object sender, EventArgs e)
        {
            Check();
            studentBindingSource.DataSource = NewSudent;
        }
    }
}
