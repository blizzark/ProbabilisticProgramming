using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ulanov3Study
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int hh = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            Obrab.numbers.Clear();
            try
            {
                Obrab.ticketOrdinary = Convert.ToInt32(textBox1.Text);
                Obrab.ticketPreferential = Convert.ToInt32(textBox2.Text);
                Obrab.saturday = Convert.ToInt32(textBox3.Text);
                Obrab.sunday = Convert.ToInt32(textBox4.Text);
                Obrab.kolichestvo = Convert.ToInt32(textBox5.Text);



                if (Obrab.ticketOrdinary <= 0 || Obrab.ticketOrdinary >= 1000000)
                {
                    MessageBox.Show("Ошибка: стоимость билета не должна быть меньше 0 и больше 1000000", "Ошибка!");
                }
                else if (Obrab.ticketPreferential <= Obrab.ticketOrdinary || Obrab.ticketPreferential > Obrab.ticketOrdinary * 2)
                {
                    MessageBox.Show("Ошибка: стоимость льготного билета не должна быть меньше обычного и больше 2 * обычный", "Ошибка!");
                }
                else if (Obrab.saturday < 0 || Obrab.saturday > 100)
                {
                    MessageBox.Show("Ошибка: погрешность должна быть от 0 до 100", "Ошибка!");
                }
                else if (Obrab.sunday < 0 || Obrab.sunday > 100)
                {
                    MessageBox.Show("Ошибка: погрешность должна быть от 0 до 100", "Ошибка!");
                }
                else if (Obrab.kolichestvo <= 0 || Obrab.sunday > 1000)
                {
                    MessageBox.Show("Ошибка: выборка может быть от 1 до 1000", "Ошибка!");
                }
                else
                {
                    float ticket = 0.0000f;
                    for (int i = 0; i < Obrab.kolichestvo; i++)
                    {
                        Program.prog();
                        //MessageBox.Show(Convert.ToString(Obrab.vivod));
                        if (Obrab.vivod == 1)
                        {
                            ticket++;
                        
                        }
                        Obrab.vivod = 0;
                        //MessageBox.Show(Convert.ToString(ticket));
                    }
                    
                    float size = Obrab.kolichestvo;
                   // MessageBox.Show(Convert.ToString(ticket));
                    float otvTicketOrdinary = ticket / size;
                    
                  //  MessageBox.Show(Convert.ToString(size));
                    float otvTicketPreferential = 1 - otvTicketOrdinary;




                    label15.Text = Convert.ToString(otvTicketOrdinary);
                    label16.Text = Convert.ToString(otvTicketPreferential);

                    label12.Text = Convert.ToString(Obrab.result);


                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка: " + err.Message, "Ошибка!");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данную программу разработали студенты\nСПбГТИ(ТУ) факультета ИТиУ 475группы:\nОвчинников Роман Сергеевич\nАндрианова Карина Ивановна\nПекер Валерия Александровна", "Информация о разработчике");
        }
    }
}
