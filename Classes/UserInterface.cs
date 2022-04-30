using Siticone.UI.WinForms;
using System.Drawing;
using System.Windows.Forms;

namespace EloCarry_AIO.Classes
{
    internal class UserInterface
    {
        public static void Update(SiticoneAnimateWindow windowAnimate, SiticoneShadowForm shadowForm, Form main)
        {
            windowAnimate.SetAnimateWindow(main, Siticone.UI.WinForms.SiticoneAnimateWindow.AnimateWindowType.AW_BLEND);
            shadowForm.SetShadowForm(main);
        }
        public static void UpdateInterface(SiticoneButton button, SiticoneProgressIndicator progressIndicator, Label label)
        {
            button.Visible = false;
            label.Visible = true;
            progressIndicator.Visible = true;
            progressIndicator.Start();
        }

        public static void Status(Label label, Form form, string text)
        {
            label.Text = text;
            int x = (form.Size.Width - label.Size.Width) / 2;
            label.Location = new Point(x, label.Location.Y);
        }
    }
}
