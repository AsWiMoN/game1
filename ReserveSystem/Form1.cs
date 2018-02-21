using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReserveSystem
{
    public partial class Form1 : Form
    {
        public int ClickCount = 0;
        ProgressBar[] progressBar;        
        public Form1()
        {
            InitializeComponent();

            progressBar = new ProgressBar[]
            {
                progressBar1,
                progressBar2,
                progressBar3,
                progressBar4
            };
            vsegoMestLabel.Text = "Всего мест в ресторане: " + VsegoMestVRestorane();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {            
            Button button = (Button)sender;
            int tableNumber = Convert.ToInt32(button.Tag.ToString());

            

            ProgressBar table = progressBar[tableNumber];            
            if (table.Value != table.Maximum)
            {
                
                int ostalosMestZaStolikom = (table.Maximum - 1) - table.Value;
                table.Value++;
                //logLabel.Text = tableName.ToString() + " забронирован на " + table.Value;
                logLabel.Text = string.Format("Столик забронирован на {0} мест. Свободных мест за столиком: {1}.", table.Value, ostalosMestZaStolikom);
            }
            else
            {
                logLabel.Text = String.Format("Все {0} мест забронированы.", table.Maximum);
            }
        }

        public int VsegoMestVRestorane()
        {
            int mestVRestorane = 0;
            for (int i = 0; i < progressBar.Length; i++)
            {
                mestVRestorane = progressBar[i].Maximum + mestVRestorane;
            }
            Console.WriteLine(mestVRestorane);
            return mestVRestorane;
        }

      
    }
}
