using System;

namespace EloCarry_AIO.Classes
{
    public class Constants
    {
        public const string winverSubKey = @"SOFTWARE\Wow6432Node\Microsoft\Windows NT\CurrentVersion";
        public const string currentBuild = "CurrentBuild";
        public const string windowsError = @"C:\Windows\Media\Windows Error.wav";
        public static string DirectX_DownloadPath => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DirectX.zip";
        public static string DirectX_Folder => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DirectX";
        public static string DirectX_DownloadLink = @"https://download850.mediafire.com/kbkh18kac4cg/xmjxifijgpupww6/DirectX.zip";
        public static string ExtractPath => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public const string windowsDefenderKeyName = @"SOFTWARE\Policies\Microsoft\Windows Defender"; //Windows Defender Checker
        public const string LMwindowsDefenderKeyName = @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender"; //Local Machine Windows Defender Checker
        public const string wdAntiSpywareValueName = "DisableAntiSpyware"; //Windows Defender Checker
        public const string wdAntiVirusValueName = "DisableAntiVirus"; //Windows Defender Checker
        public const string wdDisableRealtimeMonitoring = "DisableRealtimeMonitoring"; //Windows Defender Checker
        public const string RealTimeProtectionSubKey = @"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection"; //Real-time protection
        public const string LMRealTimeProtectionSubKey = @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection"; //Real-time protection
        public const string RealTimeProtectionValue = "DisableRealtimeMonitoring"; //Real-time protection value
        public const string DisableBehaviorMonitoring = "DisableBehaviorMonitoring"; //Real-time protection value
        public const string DisableOnAccessProtection = "DisableOnAccessProtection"; //Real-time protection value
        public const string DisableScanOnRealtimeEnable = "DisableScanOnRealtimeEnable"; //Real-time protection value
        public const string LoLClient = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Uninstall\Riot Game league_of_legends.live";
        public const string LoLClientInstallLocation = "InstallLocation";
    }
}
