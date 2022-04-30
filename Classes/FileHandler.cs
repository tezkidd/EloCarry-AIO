using EloCarry_AIO.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EloCarry_AIO.Classes
{
    internal class FileHandler
    {

        public static async Task InstallRedistributables()
        {
            await RunExe(Resources.vcredist2008_x64, true);
            Console.WriteLine("Installed");
            await RunExe(Resources.vcredist2008_x86, true);
            Console.WriteLine("Installed");
            await RunExe(Resources.vcredist2010_x64, true);
            Console.WriteLine("Installed");
            await RunExe(Resources.vcredist2010_x86, true);
            Console.WriteLine("Installed");
            await RunExe(Resources.vcredist2012_x64, true);
            Console.WriteLine("Installed");
            await RunExe(Resources.vcredist2012_x86, true);
            Console.WriteLine("Installed");
            await RunExe(Resources.vcredist2013_x64, true);
            Console.WriteLine("Installed");
            await RunExe(Resources.vcredist2013_x86, true);
            Console.WriteLine("Installed");
            await RunExe(Resources.vcredist2015_2017_2019_2022_x64, true);
            Console.WriteLine("Installed");
            await RunExe(Resources.vcredist2015_2017_2019_2022_x86, true);
            Console.WriteLine("Installed");
        }

        public static void GameCFG()
        {
            try
            {
                var value = Microsoft.Win32.Registry.GetValue(Constants.LoLClient, Constants.LoLClientInstallLocation, null);
                Console.WriteLine(value.ToString());
                string path = value + @"\Config\game.cfg";
                string DX9 = File.ReadAllText(path);
                string movementPrediction = File.ReadAllText(path);
                movementPrediction = movementPrediction.Replace("PredictMovement=1", "PredictMovement=0");
                File.WriteAllText(path, movementPrediction);

            }
            catch
            {
                UI.MessageBox.ShowBox("Unable to find the location of the LoL Client, you will need to\nmanually disable Movement Prediction & Enable DX9 Legacy Mode", "Client Error", true);
            }
            try
            {
                var value = Microsoft.Win32.Registry.GetValue(Constants.LoLClient, Constants.LoLClientInstallLocation, null);
                Console.WriteLine(value.ToString());
                string path = value + @"\Config\game.cfg";
                string DX9 = File.ReadAllText(path);
                string movementPrediction = File.ReadAllText(path);
                DX9 = DX9.Replace("PreferDX9LegacyMode=0", "PreferDX9LegacyMode=1");
                File.WriteAllText(path, DX9);
            }
            catch
            {
                UI.MessageBox.ShowBox("Unable to find the location of the LoL Client, you will need to\nmanually disable Movement Prediction & Enable DX9 Legacy Mode", "Client Error", true);
            }

        }

        public static async Task InstallDirectX()
        {
            await Task.Delay(500);
            Process process = new Process();

            process.StartInfo.FileName = Constants.DirectX_Folder + @"\DXSETUP.exe";
            process.StartInfo.Arguments = "/silent";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            process.Start();
            process.WaitForExit();// Waits here for the process to exit.
        }

        public static async Task<bool> RunExe(byte[] data, bool runSilentInstallation = false)
        {
            await Task.Delay(100);
            if (data == null)
                throw new ArgumentNullException("Applcation data cannot be null");
            try
            {

                string tempExeName = Path.Combine(Directory.GetCurrentDirectory(), "temp.exe");
                if (File.Exists(tempExeName))
                    File.Delete(tempExeName);

                using (FileStream fsDst = new FileStream(tempExeName, FileMode.CreateNew, FileAccess.Write))
                    fsDst.Write(data, 0, data.Length);
                
                File.SetAttributes(tempExeName, FileAttributes.Hidden);

                var proc = new Process();
                proc.StartInfo.FileName = tempExeName;
                if (runSilentInstallation)
                {
                    proc.StartInfo.Arguments = "/quiet";
                }
                proc.Start();
                proc.WaitForExit();
                File.Delete(tempExeName);
            }
            catch (Exception ex)
            {
                UI.MessageBox.ShowBox(ex.ToString(), "Redistributable Error", true);
            }
            return true;
        }

        public async static Task Download(Label label)
        {
            try
            {
                File.Delete(Constants.DirectX_DownloadPath);
                Directory.Delete(Constants.DirectX_Folder, true);
            }
            catch
            { }


            try
            {              
                using (var client = new WebClient())
                {
                    client.DownloadProgressChanged += (s, e) => label.Text = ($"Downloading files {e.ProgressPercentage}%");
                    await client.DownloadFileTaskAsync(Constants.DirectX_DownloadLink, Constants.DirectX_DownloadPath);
                }
            }
            catch
            {
                UI.MessageBox.ShowBox("There was an error downloading the DirectX files", "DirectX", true);
            }
        }


        internal static void Extract()
        {
            try
            {
                ZipFile.ExtractToDirectory(Constants.DirectX_DownloadPath, Constants.ExtractPath);
            }
            catch (Exception)
            {
                UI.MessageBox.ShowBox("There was an error extracting the DirectX files", "DirectX", true);
            }
        }
    }
}
