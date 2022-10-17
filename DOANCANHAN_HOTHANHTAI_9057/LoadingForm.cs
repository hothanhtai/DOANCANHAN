﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANCANHAN_HOTHANHTAI_9057
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }
        public LoadingForm(Form parent)
        {
            InitializeComponent();
            if(parent != null)
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(parent.Location.X+parent.Width/2-this.Width/2,
                    parent.Location.Y+parent.Height/2-this.Height/2);
            }
            else
            {
                this.StartPosition = FormStartPosition.CenterParent;
            }
        }

        public void CloseLoadingForm()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            if (label1.Image != null)
            {
                label1.Image.Dispose();
            }
        } 
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
