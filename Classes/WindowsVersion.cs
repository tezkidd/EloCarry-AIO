

namespace EloCarry_AIO.Classes
{
    internal class WindowsVersion
    {
        public Microsoft.Win32.RegistryKey localMachine = Microsoft.Win32.Registry.LocalMachine;

        public static bool Winver()
        {
            Microsoft.Win32.RegistryKey Key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(Constants.winverSubKey);
            string Value = Key.GetValue(Constants.currentBuild).ToString();
            int Winver = int.Parse(Value);

            if (Winver < 18362)
                return true;
            
            return false; 
        }
    }
}
