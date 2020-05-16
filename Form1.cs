using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mobile_reg_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            fieldName.Text = "Name";
            fieldName.ForeColor = Color.LightGray;
            fieldName.Tag = "Name";

            fieldSurname.Text = "Surname";
            fieldSurname.ForeColor = Color.LightGray;
            fieldSurname.Tag = "Surname";

            fieldEmail.Text = "Email";
            fieldEmail.ForeColor = Color.LightGray;
            fieldEmail.Tag = "Email";

            fieldPassword.Text = "Password";
            fieldPassword.ForeColor = Color.LightGray;
            fieldPassword.Tag = "Password";
            

            fieldPasswordRepeat.Text = "PasswordRepeat";
            fieldPasswordRepeat.ForeColor = Color.LightGray;
            fieldPasswordRepeat.Tag = "PasswordRepeat";

            registerdUsers.Columns.Add("Name");
            registerdUsers.Columns.Add("Surname");
            registerdUsers.Columns.Add("Email");
            registerdUsers.Columns.Add("Age");
            registerdUsers.Columns.Add("Password");


        }

        private void Field_Enter(object sender, EventArgs e)
        {
            TextBox field = (TextBox)sender;
            if(field.Text == (string)field.Tag)
            {
                
                field.Text = string.Empty;
                field.ForeColor = Color.Black;      
                if((string)field.Tag == "Password" || 
                    (string)field.Tag == "PasswordRepeat")
                {
                    field.PasswordChar = '*';
                }
            }           
        }

        private void Field_Leave(object sender, EventArgs e)
        {
            TextBox field = (TextBox)sender;
            if (field.Text == string.Empty)
            {
                field.Text = (string)field.Tag;
                field.ForeColor = Color.LightGray;
                if ((string)field.Tag == "Password" ||
                    (string)field.Tag == "PasswordRepeat")
                {
                    field.PasswordChar = '\0';
                }
            }
        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkShowPassword.Checked)
            {
                fieldPassword.PasswordChar = '\0';
                fieldPasswordRepeat.PasswordChar = '\0';
            }
            else
            {
                if(fieldPassword.Text != (string)fieldPassword.Tag)
                {
                    fieldPassword.PasswordChar = '*';
                }
                if(fieldPasswordRepeat.Text != (string)fieldPasswordRepeat.Tag)
                {
                    fieldPasswordRepeat.PasswordChar = '*';
                }                
            }
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (fieldPassword.Text != fieldPasswordRepeat.Text)
            {
                //passwords not equal
                fieldPassword.BackColor = Color.Red;
                fieldPasswordRepeat.BackColor = Color.Red;
                return;

            }
            //MessageBox.Show("User registered!");



            //regiesterdUserList.Items.Add(fieldName.Text);
            //regiesterdUserList.Items.Add(fieldSurname.Text);
            //regiesterdUserList.Items.Add(fieldAge.Text);
            //regiesterdUserList.Items.Add(fieldPassword.Text);            
            //regiesterdUserList.Items.Add("__________");

            var item = new ListViewItem(new[] { fieldName.Text, fieldSurname.Text, fieldEmail.Text, fieldAge.Value.ToString(), fieldPassword.Text });
            registerdUsers.Items.Add(item);

            


        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

            if(fieldPassword.Text == (string)fieldPassword.Tag || fieldPasswordRepeat.Text == (string)fieldPasswordRepeat.Tag)
            {
                return;
            }

            if(fieldPassword.Text == fieldPasswordRepeat.Text)
            {
                fieldPassword.BackColor = Color.LightGreen;
                fieldPasswordRepeat.BackColor = Color.LightGreen;
            }

            else
            {
                fieldPassword.BackColor = Color.LightYellow;
                fieldPasswordRepeat.BackColor = Color.LightYellow;
            }
        }
    }
}
