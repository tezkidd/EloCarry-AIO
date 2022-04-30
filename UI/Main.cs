using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using EloCarry_AIO.Classes;

namespace EloCarry_AIO
{
    public partial class Main : Form
    {
        public bool Defender;
        public bool DirectX;
        public bool Redistributable;
        public Main()
        {
            InitializeComponent();
            UserInterface.Update(WindowAnimate, ShadowForm, this);
            ExitIfProcessesAreRunning();

        }

        private async void StartBtn_Click(object sender, EventArgs e)
        {
            UserInterface.UpdateInterface(StartBtn, ProgressIndicator, statusLabel);

            UserInterface.Status(statusLabel, this, "Checking Windows Version");
            bool Version = WindowsVersion.Winver();
            if(Version)
            {
                UI.MessageBox.ShowBox("You need to update your Windows Version as the version\nyou are currently on is not compatible with EloCarry", "Windows Version Error", true);
            }


            if (Defender)
            {
                UserInterface.Status(statusLabel, this, "Disabling Windows Defender");
                await Task.Delay(5000);
                Registry.DisableWindowsDefender();
            }
            if(DirectX)
            {
                await FileHandler.Download(statusLabel);
                UserInterface.Status(statusLabel, this, "Extracting files");
                FileHandler.Extract();
                UserInterface.Status(statusLabel, this, "Installing DirectX");
                DirectXInstaller.RunWorkerAsync();
                await Task.Delay(20000);

            }
            if(Redistributable)
            {
                UserInterface.Status(statusLabel, this, "Installing Redistributable Packages");
                RedistributableInstaller.RunWorkerAsync();
                await Task.Delay(20000);
            }


            UserInterface.Status(statusLabel, this, "Enabling DirectX9 Legacy Mode");
            FileHandler.GameCFG();
            await Task.Delay(3000);
            UserInterface.Status(statusLabel, this, "Disabling \"Use Movement Prediction\" ");
            await Task.Delay(3000);

            UserInterface.Status(statusLabel, this, "Complete - Closing in 5 seconds");
            ProgressIndicator.Visible = false;
            await Task.Delay(5000);
            Environment.Exit(0);
        }

        private void DirectX_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(directX_CheckBox.Checked)
                DirectX = true;
            else      
                DirectX = false;
        }
        private void RedistributableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (redistributable_CheckBox.Checked)
                Redistributable = true;
            else
                Redistributable = false;
        }
        private void DefenderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (defender_CheckBox.Checked)
                Defender = true;
            else
                Defender = false;
        }
        private async void RedistributableInstallerInstaller_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            await FileHandler.InstallRedistributables();
        }
        private async void DirectXInstaller_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            await FileHandler.InstallDirectX();
        }
        public static void ExitIfProcessesAreRunning()
        {
            Process[] processToClose = Process.GetProcessesByName("LeagueClient");
                foreach (Process process in processToClose)
            {
                process.Kill();
            }
        }
    }
}
