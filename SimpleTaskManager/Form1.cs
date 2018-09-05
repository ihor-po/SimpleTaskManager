using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTaskManager
{
    public partial class main_form : Form
    {
        Timer mainTimer;
        public main_form()
        {
            InitializeComponent();

            this.Load += Main_form_Load;
            Application.ApplicationExit += Application_ApplicationExit;
        }

        /// <summary>
        /// Событие завершение приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            if (mainTimer != null)
            {
                mainTimer.Stop();
            }
        }

        private void Main_form_Load(object sender, EventArgs e)
        {
            mainTimer = new Timer();
            mainTimer.Interval = 1000;

            mainTimer.Tick += MainTimer_Tick;

            


            mainTimer.Start();
            AllProcess();

        }

        /// <summary>
        /// Обработка тика таймера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainTimer_Tick(object sender, EventArgs e)
        {
            AllProcess();
        }

        /// <summary>
        /// Получение всех запущенных процессов
        /// </summary>
        private void AllProcess()
        {
            List<Process> processes = Process.GetProcesses().ToList();
            foreach (Process item in processes)
            {
                ListViewItem i = new ListViewItem(item.Id.ToString());
                i.SubItems.Add(item.ProcessName);
                mf_lv.Items.Add(i);
            }

            this.Text = "Всего запущено процессов: " + processes.Count().ToString(); 
        }
    }

    
}
