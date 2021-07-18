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
using FontAwesome.Sharp;

namespace DoAn1
{
    public partial class MainForm : Form
    {
        public static bool isLogin { get; private set; }

        public static void setIsLogin(bool IsLogin)
        {
            isLogin = IsLogin;
        }

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            setIsLogin(false);
        }

        //struct RBG
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(131, 44, 215);
            public static Color color2 = Color.FromArgb(0, 108, 169);
            public static Color color3 = Color.FromArgb(0, 90, 0);
            public static Color color4 = Color.FromArgb(180, 0, 1);
            public static Color color5 = Color.FromArgb(253, 63, 84);
            public static Color color6 = Color.FromArgb(171, 200, 230);
            public static Color color7 = Color.FromArgb(254, 81, 79);
            public static Color color8 = Color.FromArgb(45, 22, 0);
        }
        #region: giao diện button
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(208, 165, 112);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //leftBorder
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon current child form
                IconCurrentChildFormIcon.IconChar = currentBtn.IconChar;
                IconCurrentChildFormIcon.IconColor = color;
                labelTitleChildForm.Text = currentBtn.Text;
                labelTitleChildForm.ForeColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(225, 186, 145);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        #endregion
        #region: các button
        private void ButtonDashboard_Click(object sender, EventArgs e)
        {
            if (checkIsLogin())
            {
                ActivateButton(sender, RGBColors.color1);
                OpenChildForm(new DashBoard());
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Search());
        }

        private void ButtonCart_Click(object sender, EventArgs e)
        {
            if (checkIsLogin())
            {
                ActivateButton(sender, RGBColors.color3);
                OpenChildForm(new Cart());
            }
        }

        private void ButtonManage_Click(object sender, EventArgs e)
        {
            if (checkIsLogin())
            {
                ActivateButton(sender, RGBColors.color4);
                ShowSubMenu(subpanelManage);
            }
        }

        private void BtnManageResources_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new ManageResources());
        }

        private void BtnManageVIP_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            OpenChildForm(new ManageMemberCard());
        }

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            if (checkIsLogin())
            {
                ActivateButton(sender, RGBColors.color7);
                OpenChildForm(new Report());
            }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            Reset();
            customizeDesign();
        }

        #endregion
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            IconCurrentChildFormIcon.IconChar = IconChar.Home; ;
            IconCurrentChildFormIcon.IconColor = Color.BlueViolet;
            labelTitleChildForm.Text = "Home";
            labelTitleChildForm.ForeColor = Color.White;
        }
        #region: drag form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        #endregion
        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region: child Form
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void customizeDesign()
        {
            subpanelManage.Visible = false;
        }
        private void HideSubMenu()
        {
            if (subpanelManage.Visible == true)
                subpanelManage.Visible = false;
        }
        private void ShowSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        #endregion

        private void iconButton1_MouseEnter(object sender, EventArgs e)
        {
            iconButton1.BackColor = Color.Red;
            iconButton1.IconColor = Color.White;
        }

        private void iconButton1_MouseLeave(object sender, EventArgs e)
        {
            iconButton1.BackColor = Color.Transparent;
            iconButton1.IconColor = Color.Red;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        public bool checkIsLogin()
        {
            if (isLogin == false)
            {
                if ((MessageBox.Show("Chức năng cần đăng nhập", "Đăng nhập", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    Login login = new Login();
                    login.Show();
                    return false;
                }
                else
                {
                    setIsLogin(false);
                    return false;
                }
            }
            return true;
        }
    }
}
