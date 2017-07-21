using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesar_Cipher
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void labelClick_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxKey.Text != String.Empty) // проверить на пустое значение
                {
                    if (textBox.Text != String.Empty)
                    {
                        if (Char.IsDigit(Convert.ToChar(textBoxKey.Text))) // проверить на числовое значение
                        {
                            int key = Convert.ToInt32(textBoxKey.Text); // ключ
                            string message = textBox.Text;              // сообщение

                            textBox.Text = "";

                            if (radioButtonEncrypt.Checked == true)
                            {
                                textBox.Text = Converting.Encrypt(key, message); // шифровать
                            }
                            if (radioButtonDecrypt.Checked == true)
                            {
                                textBox.Text = Converting.Decrypt(key, message); // расшифровать
                            }
                        }
                        else { throw new Exception("Некорректный ключ!"); }
                    }
                    else { throw new Exception("Введите сообщение!"); }
                }
                else { throw new Exception("Введите ключ!"); }
            }
            catch (Exception ex) { textBox.Text = ex.Message; }
        }
    }
}
