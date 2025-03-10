﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class FormGioHang : Form
    {
        public FormGioHang()
        {
            InitializeComponent();
        }
        private void FormGioHang_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        XuLyHienThi xlht = new XuLyHienThi();
        public void LoadDanhSach()
        {
            string query2 = "";
            query2 = string.Format("SELECT *" +
            "FROM [GiỏHàng]");

            using (SqlConnection connection = xlht.GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            List<GioHang> ghs = new List<GioHang>();
                            while (reader.Read())
                            {
                               string id = reader["ID"].ToString();
                               string tennguoidung = reader["Tên_người_dùng"].ToString();   
                               if(tennguoidung == XuLyHienThi.Ten_Nguoi_Dung && id == XuLyHienThi.ID)
                               {
                                    string tenmathang = reader["Tên_mặt_hàng"].ToString();
                                    string loaimathang = reader["Loại_mặt_hàng"].ToString();
                                    string soluong = reader["Số_lượng"].ToString();
                                    string hinhanh = reader["Hình_ảnh"].ToString();
                                    string giacu = reader["Giá_cũ"].ToString();
                                    string giamoi = reader["Giá_mới"].ToString();
                                    string soluongchon = reader["Số_lượng_chọn"].ToString();
                                    string ngaydangban = reader["Ngày_đăng_bán"].ToString();
                                    string masanpham = reader["Mã_sản_phẩm"].ToString();
                                    string makiemtra = reader["Mã_kiểm_tra"].ToString();
                                    GioHang gh  = new GioHang(id, tennguoidung, tenmathang, loaimathang, soluong, hinhanh, giacu, giamoi, soluongchon, ngaydangban, masanpham, makiemtra);
                                    ghs.Add(gh);
                               }

                            }
                            foreach (GioHang j in ghs)
                            {
                                UCGioHang ucgh = new UCGioHang(j);
                                ucgh.Margin = new Padding(0, 0, 0, 8);
                                flowLPGioHang.Controls.Add(ucgh);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Không có sản phẩm nào trong giỏ hàng của bạn");
                        }
                    }
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FormDao fd = new FormDao();
            fd.OpenChildForm(new FormThanhToan(), ref FormDao.activeForm, FormTrangChu.panelTrangChu);
        }

        private void btnGHQuayLai_Click_1(object sender, EventArgs e)
        {

        }
    }
}
