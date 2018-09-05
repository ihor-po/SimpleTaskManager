using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            SetLogData("Запуск программы");
            
            mainTimer = new Timer();
            mainTimer.Interval = 1000;

            mf_dp_time.CustomFormat = "HH:mm:ss tt";

            mainTimer.Tick += MainTimer_Tick;
            mf_goBtn.Click += Mf_goBtn_Click;
            mf_cb_fin.CheckedChanged += Mf_cb_fin_CheckedChanged;

            try
            {
                mainTimer.Start();
                SetLogData(this.Text);
            }
            catch (Exception ex)
            {
                SetLogData(ex.Message);
                throw;
            }

            

        }

        /// <summary>
        /// Измеенение состояния чекбокса Завершить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mf_cb_fin_CheckedChanged(object sender, EventArgs e)
        {
            if (mf_cb_fin.Checked == true)
            {
                mf_tb_procParam.Text = "";
                mf_tb_procParam.Enabled = false;
            }
            else
            {
                mf_tb_procParam.Enabled = true;
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки "GO"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mf_goBtn_Click(object sender, EventArgs e)
        {
            if (mf_tb_procName.Text == "")
            {
                Error("Ошибка! Вы не ввели процесс!");
                return;
            }

            if (mf_cb_plan.Checked == true && mf_cb_fin.Checked == true)
            {

            }
            else if (mf_cb_plan.Checked == true)
            {

            }
            else if (mf_cb_fin.Checked == true)
            {

            }
            else
            {
                StartProcess(mf_tb_procName.Text, mf_tb_procParam.Text);
            }

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
                i.SubItems.Add(GetPriority(item.BasePriority));
                i.SubItems.Add(item.Responding.ToString());
                mf_lv.Items.Add(i);
            }

            this.Text = "Всего запущено процессов: " + processes.Count().ToString(); 
        }

        private string GetPriority(int p)
        {
            string res = "";
            switch(p)
            {
                case 4:
                    res = "Низкий";
                    break;
                case 8:
                    res = "Нормальный";
                    break;
                case 13:
                    res = "Высокий";
                    break;
                case 24:
                    res = "Реальное время";
                    break;
                default:
                    res = p.ToString();
                    break;
            }
            return res;
        }

        /// <summary>
        /// Запись события в лог файл
        /// </summary>
        /// <param name="str"></param>
        private void SetLogData(string str)
        {
            string path = @"..\..\Log";
            string file = "logData.log";
            string pathFile = path + @"\" + file;

            if (File.Exists(pathFile))
            {
                using (StreamWriter sw = new StreamWriter(pathFile, true))
                {
                    sw.WriteLine(DateTime.Now.ToString() + ' ' + str);
                    sw.Close();
                }
                
            }
            else //создание файла если такого не было
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                
                using (FileStream fs = File.Create(pathFile))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes($"{ DateTime.Now.ToString() } Создание файла для храниения логов " + 
                        $"\n { DateTime.Now.ToString() } { str }\n");
                    fs.Write(info, 0, info.Length);
                }
            }
            
        }

        /// <summary>
        /// Запись в лог и сообщение об ошибке 
        /// </summary>
        /// <param name="msg"></param>
        private void Error(string msg)
        {
            SetLogData(msg);
            ShowMessage(msg);
        }
        
        /// <summary>
        /// Отображение сообщения
        /// </summary>
        /// <param name="msg"></param>
        private void ShowMessage(string msg)
        {
            MessageBox.Show(msg, "Простой таск менеджер", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Запуск процесса
        /// </summary>
        /// <param name="proc"></param>
        /// <param name="param"></param>
        private void StartProcess(string proc, string param)
        {
            try
            {
                if (param != "")
                {
                    Process.Start(proc, param);
                    SetLogData($"Запущен процесс {proc} с параметрами {param}");
                }
                else
                {
                    Process.Start(proc);
                    SetLogData($"Запущен процесс {proc}");
                }
                
            }
            catch (Exception ex)
            {
                Error(ex.Message);
            }
            
        }
    }

    
}
