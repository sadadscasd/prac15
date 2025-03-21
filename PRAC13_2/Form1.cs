using System;
using System.Windows.Forms;

namespace PRAC13_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person employee = new Person();

            employee.FirstName = textBox1.Text;
            employee.LastName = textBox2.Text;

            DateTime dob = dateTimePicker1.Value;

            int age = employee.Age(dob);

            string text = $"Имя: {employee.FirstName}\nФамилия: {employee.LastName}\nВозраст: {age}";
            if (age % 10 == 1)
            {
                if (age % 100 == 11)
                {
                    text += " лет";
                }
                else{ text += " год";}
                
            }
            else if(age % 10 == 2|| age % 10 == 3|| age % 10 == 4)
            {
                if (age % 100 == 12 || age % 100 == 13 || age % 100 == 14)
                {
                    text += " лет";

                }
                else { text += " года"; }
               
            }
            else if(age <= 0)
            {
                text = $"Имя: {employee.FirstName}\nФамилия: {employee.LastName}\nЕще не родился(";
            }
            else
            {
                text += " лет";
            }
            MessageBox.Show(text,
                "Информация о сотруднике", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Имя";
            textBox2.Text = "Фамилия";
        }

    }
}