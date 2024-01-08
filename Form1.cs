using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw_busStop
{
    public partial class Form1 : Form
    {
        Thread _th_addP;
        Thread _th_busPick;
        object _locker = new object();

        public Form1()
        {
            InitializeComponent();
            
        }
        //метод добавляет людей на остановку каждую секунду
        private void addPoepleToBusStop() {
            while (true)
            {
                Random random = new Random();
                Invoke((MethodInvoker)delegate{
                    lock (_locker)
                    {
                        l_people.Text = (Convert.ToInt32(l_people.Text) + random.Next(20)).ToString();
                    }
                });
                Thread.Sleep(1000);
            }
        }
        //метод вычитающий людей с остановки
        private void busPickPeople()
        {
            while (true)
            {
                Thread.Sleep(3000);
                lock (_locker)
                {
                    if (Convert.ToInt32(l_people.Text) < 30)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            l_people.Text = "0";
                        });
                    }
                    else
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            l_people.Text = (Convert.ToInt32(l_people.Text) - 30).ToString();
                        });
                    }
                }
                cb_timeBus.Text = DateTime.Now.ToString("mm.ss");
                cb_timeBus.Items.Add(DateTime.Now.ToString("mm.ss"));
            }
        }
        private void b_start_Click(object sender, EventArgs e)
        {
            _th_addP = new Thread(addPoepleToBusStop);
            _th_busPick = new Thread(busPickPeople);
            _th_addP.Start();
            _th_busPick.Start();
        }

    }
}
