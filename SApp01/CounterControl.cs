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
    public partial class CounterControl : UserControl
    {

        #region шапка даю переменные итд
        public event EventHandler<CounterEventArgs> CounterEvent;        
        //private int counter = 0;
        private int i = 0;
        private int shag = 0; // добавим переменную шаг
        // 
        public int Counter { get; set; } = 1;
        //////////////////////////////////получим рандом////////////////////////////////////
        public int Target { get; set; } = 0;
         public int GetTarget()
        {
            Random rand = new Random();
        int Target = rand.Next(1, 100);
            return Target; // типа прописал инт таргет = рандом // else
        }  
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////
        public CounterControl()
        {
            InitializeComponent();
            UpdateUI();
           


            // переподпишу кнопки так удобней чем в свойствах
            btnplus.Text = "+1";
            btnX2.Text = "x2";

            //resetCounterButton.Text = "Сброс";          

        }



        #endregion

        private void btnplus_Click(object sender, EventArgs e)
        {
            i++;
            Counter++;
            shag++;
            UpdateUI();
            i = 0;
            //if (i >= 3)
            //{
            //    if (CounterEvent != null)
            //    {
            //        CounterEvent.Invoke(this, new CounterEventArgs() { Counter = Counter });
            //    }
            //    i = 0;
            //}
        }
        /// ////////////////////////////////////////////////////////////// надо описать методы которые манипулируют в каунтер итд. типа + и х2
        private void textBoxCounter_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(counterChanger.Text, out int number))
            {
                Counter = number;
                UpdateUI();
                
            }
            else
            {
                Counter = 0;
                UpdateUI();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Counter *= 2;
            shag++;
            UpdateUI();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
                /*public bool CheckGoal()
            {
                return this.value == this.goal ? true : false;
            }*/
        }
        #region чекеры обновляторы
        public void ResetCounter() // метод кнопки сброса снизу который 
        {
            Counter = 0;
            shag = 0;
            if (Target == 0) Target = GetTarget();
            UpdateUI();
        }

        private void UpdateUI() // метод который  обновляет значение каунтера когда мы его вызываем
        {
            counter.Text = Counter.ToString(); // каунтер
            steps.Text = shag.ToString(); // количество кликов
                                          //if (MainForm(Target.Visible) // если гол визибл
            if (CheckTHIS() == true) // на апдейт вызываем проверку метода чек гол из удвоителя
            {
                Target = 0;
                MessageBox.Show($"Поздравляем, вы достигли заданного числа за {steps.Text} ходов");

            }

        }
        /// ////////////////////// метод который будет проверять равен каунтер таргету или нет

        public bool CheckTHIS()
        {
            return this.Counter == this.Target ? true : false;
        }
        /// ////////////////////// метод который будет проверять равен каунтер таргету или нет
    }
    #endregion
    public class CounterEventArgs : EventArgs
    {
        public int Counter { get; set; }
        public int shag { get; set; }
        public int Target { get; set; }
    }
}
