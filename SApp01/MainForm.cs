using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SApp01
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = "Удвоитель";
            needNUM.Visible = false;

        }



        private void counterControl1_CounterEvent(object sender, CounterEventArgs e)
        {
            MessageBox.Show($"Вы 3 раза нажали на кнопку. Значение счетчика: {e.Counter}",
                "Счетчик", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void resetCounterButton_Click(object sender, EventArgs e)
        {
            counterControl1.ResetCounter();
            
        }

        private void counterControl1_Load(object sender, EventArgs e)
        {
            
        }


        private void MainMenu_1_Click(object sender, EventArgs e) // запуск игры , набери число
        {
            counterControl1.ResetCounter();            
            // сбрасываем счетчикки
            needNUM.Visible = true;
            int target = counterControl1.GetTarget();
            needNUM.Text = target.ToString();
            MessageBox.Show($"Получите значение: {target}");
            //lblGoal.Visible = true;
            //lblGoalText.Visible = true;
            //lblGoal.Text = doubler.Goal.ToString();
            //doubler.Reset();
            Update();            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
