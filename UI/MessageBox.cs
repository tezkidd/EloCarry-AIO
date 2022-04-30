using EloCarry_AIO.Classes;
using System;
using System.Media;
using System.Windows.Forms;

namespace EloCarry_AIO.UI
{
    public partial class MessageBox : Form
    {
        public static bool isError;

        static MessageBox newMessageBox;
        static string ID;
        public MessageBox()
        {
            InitializeComponent();
            ShadowForm.SetShadowForm(this);
        }
        

        public static string ShowBox(string txtMessage, string txtTitle, bool Error = true)
        {
            if (Error)
            {
                isError = true;
                var sound = new SoundPlayer(Constants.windowsError);
                sound.Play();
            }

            newMessageBox = new MessageBox();
            newMessageBox.msgBox_Title.Text = txtTitle;
            newMessageBox.msgBox_Label.Text = txtMessage;
            newMessageBox.ShowDialog();
            return ID;
        }

        private void Ok_Btn_Click(object sender, EventArgs e)
        {
            if(isError)
            {
                Application.Exit();
            }
            else
            ID = "1";
            newMessageBox.Dispose();
        }
    }
}
