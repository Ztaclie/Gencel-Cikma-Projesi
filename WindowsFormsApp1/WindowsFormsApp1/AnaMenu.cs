using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZtashiaCompanyForm;

namespace WindowsFormsApp1
{
    public partial class AnaMenu : Form
    {
        //Fields
        int countDown = 3;
        public AnaMenu()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            lblCountDown.Text = countDown.ToString();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public void logoDegis(int a) // 1(TRUE) gelirse TURUNCU 0(FALSE) gelirse SİYAH LOGO
        {
            if(a==1)
            {
                Logo1.ImageLocation = ".\\Picts\\BLACK_icons8-fire-90.png";
            }
            else if(a==2)
            {
                Logo1.ImageLocation = ".\\Picts\\ORANGE_icons8-fire-90.png";
            }
            else if(a==3)
            {
                Logo1.ImageLocation = ".\\Picts\\RED_icons8-fire-90.png";
            }
            else
            {
                Logo1.ImageLocation = ".\\Picts\\BLACK_icons8-fire-90.png";
            }
            Logo1.Load();
            
        }
        private void Logo1_Click(object sender, EventArgs e)
        {

            try
            {
                string user = "Ztac", password = "DemirGMk";
                if (log_user_txtbx.Text.ToString() != "Ztac")
                {
                    if(countDown>1 && countDown<4)
                    {
                        logoDegis(3);
                        log_cvp_label.Text = "Unknown User";
                        countDown--;
                        lblCountDown.Text = countDown.ToString();
                    }
                    else if(countDown==1)
                    {
                        Application.Exit();
                    }
                }
                else if(log_user_txtbx.Text.ToString() == "Ztac" && log_password_txtbx.Text != "DemirGMk")
                {
                    if(countDown>1 && countDown<4)
                    {
                        logoDegis(3);
                        log_cvp_label.Text = "Wrong Password";
                        countDown--;
                        lblCountDown.Text = countDown.ToString();
                    }
                    else if (countDown == 1)
                    {
                        Application.Exit();
                    }
                }
                else if(log_user_txtbx.Text.ToString() == "Ztac" && log_password_txtbx.Text == "DemirGMk")
                {
                    logoDegis(2);
                    log_cvp_label.Text = "Welcome Boss";
                    AnaMenu anme = new AnaMenu();
                    MainMenuForm mame = new MainMenuForm();
                    Hide();
                    mame.Show();

                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void AnaMenu_Click(object sender, EventArgs e)
        {
            logoDegis(1);
            log_cvp_label.Text = "";
            log_user_txtbx.Text = "";
            log_password_txtbx.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            log_user_txtbx.Text = "Ztac";
            log_password_txtbx.Text = "DemirGMk";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
