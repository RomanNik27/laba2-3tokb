using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
           

        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            if(OldPassTxtBx.TextLength == 0)
            {
                MessageBox.Show("Введите старый пароль для изменения");
                return;
            }

            if(NewPassTxtBx.TextLength == 0)
            {
                MessageBox.Show("Новый пароль должен содержать хотя бы один символ");
                return;
            }

            if(Encryption.Is_pass_eq(OldPassTxtBx.Text))
            {
                Encryption.new_password_key(NewPassTxtBx.Text);
                MessageBox.Show("Пароль успешно изменён");
            }
        }

      
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
