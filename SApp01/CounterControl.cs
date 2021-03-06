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
        public int Counter { get; set; } = 0;
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
        #region кнопки кликаю
        private void btnplus_Click(object sender, EventArgs e)
        {
            plus1();
            //i++;
            //Counter++;
            //shag++;
            //UpdateUI();
            //i = 0;
            ////if (i >= 3)
            ////{
            ////    if (CounterEvent != null)
            ////    {
            ////        CounterEvent.Invoke(this, new CounterEventArgs() { Counter = Counter });
            ////    }
            ////    i = 0;
            ////}
        }
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
            thisX2();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            /*public bool CheckGoal()
        {
            return this.value == this.goal ? true : false;
        }*/
        }


        #endregion
        /// ////////////////////////////////////////////////////////////// надо описать методы которые манипулируют в каунтер итд. типа + и х2
        /// 

        #region плюсы минусы и прочее
        public delegate void goback();
        Stack<goback> undolast = new Stack<goback>();

        public void plus1()
        {
            this.Counter++;
            this.shag++;
            UpdateUI();
            undolast.Push(new goback(minus1));
        }

        public void minus1()
        {
            this.Counter--;
            this.shag++;
            UpdateUI();
        }
        public void thisX2()
        {
            this.Counter *= 2;
            this.shag++;
            UpdateUI();
            undolast.Push(new goback(fromthis2));

        }
        public void fromthis2()
        {
            this.Counter /= 2;
            this.shag++;
            UpdateUI();
        }
        /// <summary>Функция отмены действия. Проверяет стэк, если не пустой, выполняет операцию, обратную последней</summary>
        public void otmena()
        {
            goback reverseFunc;
            if (undolast.Count > 0)
            {
                reverseFunc = undolast.Pop(); // стоковый метод поп удаляет и возвращает
                reverseFunc();
            }
            return;
        }

        #endregion

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
            steps.Text = shag.ToString(); // количество кликов //
                                          //if (MainForm(Target.Visible) // если гол визибл
if (shag != 0 || Counter > 0 || shag > 0)
            if (CheckTHIS() == true) // на апдейт вызываем проверку метода чек гол из удвоителя
            {
                Target = 0;
                MessageBox.Show($"Поздравляем, вы достигли заданного числа за {steps.Text} ходов");
                    
                  // MainForm needNUM.Visible; = false;
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
