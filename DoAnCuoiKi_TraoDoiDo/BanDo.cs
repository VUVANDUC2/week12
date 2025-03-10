﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace DoAnCuoiKi_TraoDoiDo
{
   
    public class BanDo
    {
        public string Ten_Mat_Hang { get; set; }
        public string Loai_Mat_Hang { get; set; }
        public string Gia_Ban { get; set; }
        public string Mo_ta_mat_hang { get; set; }
        public string Ngay_Dang_Ban { get; set; }
        public string Hinh_Anh_1 { get; set; }
        public string Hinh_Anh_2 { get; set; }
        public string Hinh_Anh_3 { get; set; }
        public string Hinh_Anh_4 { get; set; }
        public string Ma_Voucher { get; set; }
        public string Giam_Gia { get; set; }
        public string So_Luong_Voucher { get; set; }
        public string So_Luong { get; set; }
        public string Dia_Diem { get; set; }
        public string Phuong_Thuc_Giao_Hang { get; set; }
        public string Tinh_Trang_Mat_Hang { get; set; }
        public string Ma_San_Pham { get; set; } 
        public string ID { get; set; }

        public string Ten_Nguoi_Dung { get; set; }  

        public string Gia_Goc {  get; set; }    

        public string So_Luong_Chon { get; set; }   
        public BanDo()
        {

        }

        public BanDo(string ten_mat_hang, string loai_mat_hang, string gia_ban, string mo_ta_mat_hang, string ngay_dang_ban, string hinh_anh_1, string hinh_anh_2, string hinh_anh_3, string hinh_anh_4,
                    string ma_voucher, string giam_gia, string so_luong_voucher, string so_luong, string dia_diem, string phuong_thuc_giao_hang, string tinh_trang_mat_hang, string ma_san_pham, string iD, string ten_nguoi_dung, string gia_goc)
        {
            Ten_Mat_Hang = ten_mat_hang;
            Loai_Mat_Hang = loai_mat_hang;
            Gia_Ban = gia_ban;
            Mo_ta_mat_hang = mo_ta_mat_hang;
            Ngay_Dang_Ban = ngay_dang_ban;
            Hinh_Anh_1 = hinh_anh_1;
            Hinh_Anh_2 = hinh_anh_2;
            Hinh_Anh_3 = hinh_anh_3;
            Hinh_Anh_4 = hinh_anh_4;
            Ma_Voucher = ma_voucher;
            Giam_Gia = giam_gia;
            So_Luong_Voucher = so_luong_voucher;
            So_Luong = so_luong;
            Dia_Diem = dia_diem;
            Phuong_Thuc_Giao_Hang = phuong_thuc_giao_hang;
            Tinh_Trang_Mat_Hang = tinh_trang_mat_hang;
            Ma_San_Pham = ma_san_pham;
            ID = iD;
            Ten_Nguoi_Dung = ten_nguoi_dung;
            Gia_Goc = gia_goc;
        }
         public BanDo(string iD, string ten_nguoi_dung, string ten_mat_hang, string loai_mat_hang, string so_luong, string hinh_anh_1, string gia_goc, string gia_ban, string so_luong_chon, string ngay_dang_ban, string ma_san_pham)
         {
            ID = iD;
            Ten_Nguoi_Dung = ten_nguoi_dung;
            Ten_Mat_Hang = ten_mat_hang;
            Loai_Mat_Hang = loai_mat_hang;
            So_Luong = so_luong;
            Hinh_Anh_1 = hinh_anh_1;
            Gia_Goc = gia_goc;
            Gia_Ban = gia_ban;
            So_Luong_Chon = so_luong_chon; ;
            Ngay_Dang_Ban = ngay_dang_ban;
            Ma_San_Pham = ma_san_pham;
         }
    }
}
