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
    public partial class FormThoiTrang : Form
    {
        XuLyHienThi xlht = new XuLyHienThi();
        public FormThoiTrang()
        {
            InitializeComponent();
        }
        string loaimathang = "Thoi trang";
        private void FormThoiTrang_Load(object sender, EventArgs e)
        {
            xlht.LoadDanhSach(loaimathang, flowLPThoitrang);
        }
    }
}
