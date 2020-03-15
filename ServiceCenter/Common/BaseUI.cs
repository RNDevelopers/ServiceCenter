using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceCenter.Common
{
    public partial class BaseUI : Form
    {
        private bool Drag;
        private int MouseX;
        private int MouseY;

        public BaseUI()
        {
            InitializeComponent();
        }

        public void SetFormName()
        {
            lblFormName.Text = this.Text + " | Nihal Car Service and Wax";
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblClose_MouseHover(object sender, EventArgs e)
        {
            lblClose.BackColor = System.Drawing.Color.White;
            lblClose.ForeColor = Color.FromArgb(36, 58, 81);
        }

        private void lblMinimize_MouseHover(object sender, EventArgs e)
        {
            lblMinimize.BackColor = System.Drawing.Color.White;
            lblMinimize.ForeColor = Color.FromArgb(36, 58, 81);
        }

        #region Move Form
        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            Drag = false;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                this.Top = Cursor.Position.Y - MouseY;
                this.Left = Cursor.Position.X - MouseX;
            }
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            MouseX = Cursor.Position.X - this.Left;
            MouseY = Cursor.Position.Y - this.Top;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.SizeAll;

        }
        #endregion

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.BackColor = System.Drawing.Color.Transparent;
            lblClose.ForeColor = System.Drawing.Color.White;
        }

        private void lblMinimize_MouseLeave(object sender, EventArgs e)
        {
            lblMinimize.BackColor = System.Drawing.Color.Transparent;
            lblMinimize.ForeColor = System.Drawing.Color.White;
        }


        private void BaseUI_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(36, 58, 81), 6), this.DisplayRectangle);
        }

    }
}
