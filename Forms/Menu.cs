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
using Bhop.Cheats;
using Bhop.Utilities;

namespace Bhop
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (Main.RunStartup())
            {
                OffsetUpdater.UpdateOffsets();
                #region Start Threads
                // found the process and everything, lets start our cheats in a new thread
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    CheckMenu();
                }).Start();

                Tools.InitializeGlobals();

                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    Bunnyhop.Run();
                }).Start();

                #endregion
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            TopMost = true; // make this hover over the game, can remove if you want
        }

        public void CheckMenu()
        {
            // Here we make the main variables equal to what our menu checkboxes say
            while (true)
            {
                Main.S.BunnyhopEnabled = BunnyhopCheck.Checked;

                Thread.Sleep(50); // Greatly reduces cpu usage
            }
        }

        private void GithubBTN_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mixikk/Bhop-for-csgo");
        }
    }
}
