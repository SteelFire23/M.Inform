using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M.Inform
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 main = Owner as Form1;
            string text = "";
            if (main.checkBox1.Checked)
            {
                text = "бакалавриата";
            }
            else if (main.checkBox2.Checked)
            {
                text = "магистратуры";
            }
            textBox1.Text = "Справка с места учёбы\n";
            textBox1.AppendText($"{Environment.NewLine}Студент {text} {main.textBox1.Text}, обучающийся на {main.comboBox1.Text} курсе специальности {main.textBox2.Text} в группе {main.comboBox2.Text}.");
            textBox1.AppendText($" Действительно обучается в высшем учебном заведении.");
            textBox1.AppendText($"{Environment.NewLine}Подпись _____                Дата: {DateTime.Now.ToShortDateString()}");
        }
    }
}
