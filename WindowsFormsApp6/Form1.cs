using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null && textBox1.Text != null)
            {
                if (listBox1.SelectedItem == "Админ")
                {
                    using (StreamReader reader = new StreamReader(@"C:\Users\Алексей\source\repos\WindowsFormsApp6\WindowsFormsApp6\bin\People\log1.ps"))
                    {
                        string buf;

                        while ((buf = reader.ReadLine()) != null)
                        {
                            if (textBox1.Text == buf)
                            {
                                MessageBox.Show("Приветствую: Администратор", "Успешно");
                                Form2 frm2 = new Form2();
                                frm2.Show();
                                this.Hide();
                            }



                        }

                        if (listBox1.SelectedItem == "Кассир")
                        {
                            using (StreamReader reader1 = new StreamReader(@"C:\Users\Алексей\source\repos\WindowsFormsApp6\WindowsFormsApp6\bin\People\log2.ps"))
                            {
                                string buf1;

                                while ((buf1 = reader1.ReadLine()) != null)
                                {
                                    if (textBox1.Text == buf1)
                                    {
                                        MessageBox.Show("Приветствую: Кассир", "Успешно");
                                        Form3 frm3 = new Form3();
                                        frm3.Show();
                                        this.Hide();
                                    }



                                }


                            }
                        }

                        if (listBox1.SelectedItem == "Товаровед")
                        {
                            using (StreamReader reader2 = new StreamReader(@"C:\Users\Алексей\source\repos\WindowsFormsApp6\WindowsFormsApp6\bin\People\log3.ps"))
                            {
                                string buf3;

                                while ((buf3 = reader2.ReadLine()) != null)
                                {
                                    if (textBox1.Text == buf3)
                                    {
                                        MessageBox.Show("Приветствую: Товаровед", "Успешно");
                                        Form4 frm4 = new Form4();
                                        frm4.Show();
                                        this.Hide();
                                    }



                                }


                            }
                        }

                    }
                }
    }   }   }
    
}
