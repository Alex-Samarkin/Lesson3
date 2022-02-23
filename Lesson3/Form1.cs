using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // список адресов
            SList.Add(@"http://rasp.pskgu.ru/PrepsRasp.html");
            SList.Add(@"http://rasp.pskgu.ru/preps/samarkinai.html");
            SList.Add(@"http://rasp.pskgu.ru/preps/samarkinaei.html");
            SList.Add(@"http://rasp.pskgu.ru/preps/mudrovas.html");

            // заполняем адресами combobox
            toolStripComboBox1.Items.AddRange(SList.ToArray());
            // выбираем из этого списка первый (элемент с номером 0)
            toolStripComboBox1.SelectedIndex = 0;
            // при этом (см. далее) происходит СОБЫТИЕ - SelectedIndexChanged
        }

        public List<string> SList { get; set; } = new List<string>();

        private void общееРасписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new Uri(SList[0]);
        }

        private void самаркинАИToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new Uri(SList[1]); // Самаркин
        }

        private void самаркинаЕИToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new Uri(SList[2]); // Самаркина Е.И.
        }

        private void мудровАСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new Uri(SList[3]); // Мудров
        }

        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Url = new Uri(toolStripTextBox1.Text);
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(toolStripComboBox1.Text);
        }
    }
}
