﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class FormKhac : Form
    {
        XuLyHienThi xlht = new XuLyHienThi();
        public FormKhac()
        {
            InitializeComponent();
        }
        string loaimathang = "Khac";
        private void FormKhac_Load(object sender, EventArgs e)
        {
            xlht.LoadDanhSach(loaimathang, flowLPKhac);
        }
    }
}
