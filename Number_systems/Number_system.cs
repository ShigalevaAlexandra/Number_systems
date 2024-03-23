using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Number_systems
{
    public partial class Number_system_2_19 : Form
    {
        string user_input;  //строка введеная пользователем
        char[] user_chars;  //массив для хранения введенной строки в виде символов

        public Number_system_2_19()
        {
            InitializeComponent();
        }

        private void btn_convert_number_Click(object sender, EventArgs e)
        {
            //обработка исключительных ситуаций
            try
            {
                //считываем число введеное пользователем
                //и разбиваем его на отдельные элементы(символы)
                user_input = txtBox_user_number.Text;
                user_chars = user_input.ToCharArray();

                //обработка символов введенного числа
                foreach (char one_char in user_chars)
                {
                    //если введены буквенные символы
                    if (!char.IsDigit(one_char))
                    {
                        MessageBox.Show("Введены недопустимые символы!!");
                        return;
                    }

                    //если число введено не в 2-ой СС
                    if (one_char != '0' && one_char != '1')
                    {
                        MessageBox.Show("Введите число в 2-ой СС!!" +
                            "\n(число должно состоять из 0 и 1)");
                        return;
                    }
                }
            }
            catch (Exception ex)  //возникла другая ошибка
            {
                MessageBox.Show("Ошибка при конвертации: " + ex.Message);
            }

            //выполнение перевода числа из 2-ой в 7-ую СС

            //сначала переведем число в 10-ую СС
            uint user_number = 0;
            var mnojitel = 0u;

            for (int i = user_chars.Length - 1; i >= 0; i--)
            {
                if (user_chars[i] == '1')
                {
                    user_number += Convert.ToUInt32(Math.Pow(2, mnojitel));
                }
                mnojitel++;
            }

            //затем переведем число в 7-ую СС
            string result = string.Empty;

            while (user_number > 0)
            {
                result = (user_number % 7) + result;
                user_number /=  7;
            }

            txtBox_new_number.Text = result;
        }
    }
}