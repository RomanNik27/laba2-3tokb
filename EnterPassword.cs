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

namespace Password
{
    public partial class EnterPassword : Form
    {
        int CountLose = 0;

        public EnterPassword()
        {
            InitializeComponent();
        }
       

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            if(PasswordTxtBx.Text=="")
            { MessageBox.Show("Введите пароль");return; }

            bool IsPassEq = false;
            using (FileStream fstream = new FileStream("password", FileMode.OpenOrCreate))
            {
                if (fstream.Length != 0)
                {
                    fstream.Close();
                    if (Encryption.Is_pass_eq(PasswordTxtBx.Text))
                    {
                        IsPassEq = true;
                    }
                    else
                    {
                        MessageBox.Show("Введен неверный пароль. Осталось "+(2-CountLose).ToString()+" попыток.");
                        CountLose++;
                        if (CountLose == 3)
                        {
                            Application.Exit();
                        }
                    }
                                        
                   
                }
                else // если файл с паролем пуст или не найден
                {
                    fstream.Close();
                    Encryption.new_password_key(PasswordTxtBx.Text);
                    IsPassEq = true;
                }
            }

            if (IsPassEq)
            {
                MainForm MF = new MainForm();
                MF.Show();
                this.Hide();
            }
        }
    }
}
