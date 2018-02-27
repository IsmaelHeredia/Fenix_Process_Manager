// Fenix Process Manager 0.6 
// © Ismael Heredia , Argentina , 2017
//GitHub : https://github.com/IsmaelHeredia

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;

namespace Manager
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        // Funciones

        public void get_process()
        {

            lvProcess.Items.Clear();
            
            Process[] procesos = Process.GetProcesses();

            foreach (Process proceso in procesos)
            {

                ListViewItem item = new ListViewItem();

                item.Text = Convert.ToString(proceso.Id);
                item.SubItems.Add(Convert.ToString(proceso.ProcessName));
                if (proceso.MainWindowTitle == "")
                {
                    item.SubItems.Add("--");
                }
                else
                {
                    item.SubItems.Add(Convert.ToString(proceso.MainWindowTitle));

                }

                try
                {
                    item.SubItems.Add(proceso.StartTime.ToString("dd/MM   HH:mm:ss"));
                }
                catch
                {
                    item.SubItems.Add("--");

                }

                try
                {
                    item.SubItems.Add(proceso.PriorityClass.ToString());
                }
                catch
                {
                    item.SubItems.Add("--");
                }

                lvProcess.Items.Add(item);

            }

            gbProcess.Text = "Process Found :  [" + Convert.ToString(lvProcess.Items.Count) + "]"; 

        }

        //

        private void FormHome_Load(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(Manager.Properties.Resources.formcreate);
            sound.Play();

            get_process();
        }

        private void tmReloadProcess_Tick(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(Manager.Properties.Resources.formcreate);
            sound.Play();

            get_process();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(Manager.Properties.Resources.formcreate);
            sound.Play();
            get_process();
        }

        private void KillProcess_Click(object sender, EventArgs e)
        {
            string control_pro = "";

            Process[] cerrando = Process.GetProcessesByName(lvProcess.FocusedItem.SubItems[1].Text);
            foreach (Process proceso in cerrando)
            {
                proceso.Kill();
                proceso.Close();
                control_pro = "yes";
            }

            if (control_pro == "yes")
            {
                SoundPlayer sound = new SoundPlayer(Manager.Properties.Resources.scanfin);
                sound.Play();

                MessageBox.Show("Process Closed");

                get_process();

            }
            else
            {
                MessageBox.Show("Error");

                get_process();

            }
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fenix Process Manager 0.6\nWritten By Ismael Heredia\nContact : ismael_heredia@hotmail.com\nWebsite : http://ismaelheredia123.wordpress.com\nGood Bye");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit ?", "Fenix Process Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FormHome_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(Manager.Properties.Resources.click);
            sound.Play();
        }

        private void pbWoman_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(Manager.Properties.Resources.click);
            sound.Play();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(Manager.Properties.Resources.click);
            sound.Play();
        }

        private void cmsOpciones_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(Manager.Properties.Resources.click);
            sound.Play();
        }

        private void lvProcess_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(Manager.Properties.Resources.click);
            sound.Play();
        }
    }
}