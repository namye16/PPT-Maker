using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worship {
    public partial class MainForm : Form {
        private Button currentButton;
        bool dragging;
        int dragStartX, dragStartY;

        const int WM_NCHITTEST = 0x0084;
        const int HTCLIENT = 1;

        public MainForm() {
            InitializeComponent();            
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            Size = new Size(465, 682);

            morningWorshipPPT1.Show();
            openingHymnsPPT1.Hide();
            choirLyricsInput1.Hide();
        }

        protected override void OnShown(EventArgs e) {
            base.OnShown(e);            
            // 폼 리사이즈시 필요한 패딩
            Padding = new Padding(3);            
        }

        // 폼 이동, 리사이즈
        protected override void WndProc(ref Message m) {
            base.WndProc(ref m);
            switch (m.Msg) {
                case WM_NCHITTEST:
                    if (m.Result == (IntPtr)HTCLIENT) {
                        var p = this.PointToClient(new Point(m.LParam.ToInt32()));

                        m.Result =
                            (IntPtr)
                            (p.X <= 6
                                 ? p.Y <= 6 ? 13 : p.Y >= this.Height - 7 ? 16 : 10
                                 : p.X >= this.Width - 7
                                       ? p.Y <= 6 ? 14 : p.Y >= this.Height - 7 ? 17 : 11
                                       : p.Y <= 6 ? 12 : p.Y >= this.Height - 7 ? 15 : p.Y <= 24 ? 2 : 1);
                    }
                    break;
            }
        }

        private void ClickButton(object btnSender) {
            if (btnSender != null) {
                if (currentButton != (Button)btnSender) {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.White;
                    currentButton.ForeColor = Color.FromArgb(27, 28, 31);
                    currentButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));                    
                }
            }
        }
        
        private void DisableButton() {
            foreach (Control pre in pnlMenu.Controls) {
                if(pre.GetType() == typeof(Button)) {
                    pre.BackColor = Color.FromArgb(247, 247, 247);
                    pre.ForeColor = Color.FromArgb(27, 28, 31);
                    pre.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));                    
                }
            }
        }

        private void btnMorningWorshipPPT_Click(object sender, EventArgs e) {
            morningWorshipPPT1.Visible = true;
            openingHymnsPPT1.Visible = false;
            choirLyricsInput1.Visible = false;
            //tableOfContents1.Visible = false;
            ClickButton(btnMorningWorshipPPT);
        }

        private void btnChoirLyricsInput_Click(object sender, EventArgs e) {
            morningWorshipPPT1.Visible = false;
            openingHymnsPPT1.Visible = false;
            choirLyricsInput1.Visible = true;
            //tableOfContents1.Visible = false;

            //morningWorshipPPT1.Hide();
            //openingHymnsPPT1.Hide();
            //choirLyricsInput1.Show();
            ClickButton(btnChoirLyricsInput);
        }

        private void btnIndividualHymnsPPT_Click(object sender, EventArgs e) {
            morningWorshipPPT1.Visible = false;
            openingHymnsPPT1.Visible = true;
            choirLyricsInput1.Visible = false;
            //tableOfContents1.Visible = false;
            ClickButton(btnIndividualHymnsPPT);
        }

        private void btnTableOfContents_Click(object sender, EventArgs e) {
            morningWorshipPPT1.Visible = false;
            openingHymnsPPT1.Visible = false;
            choirLyricsInput1.Visible = false;
            //tableOfContents1.Visible = true;
            ClickButton(btnTableOfContents);
        }
        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e) {
            dragging =  true;
            dragStartX = e.X;
            dragStartY = e.Y;
        }
        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e) {
            if (dragging == true) {
                this.SetDesktopLocation(MousePosition.X - dragStartX, MousePosition.Y - dragStartY);
            }
        }

        private void pnlTitleBar_MouseUp(object sender, MouseEventArgs e) {
            dragging = false;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Normal) 
                this.WindowState = FormWindowState.Maximized;
            else 
                this.WindowState = FormWindowState.Normal;            
        }

        private void btnMinimize_Click(object sender, EventArgs e) {            
            this.WindowState = FormWindowState.Minimized;            
        }
    }
}
