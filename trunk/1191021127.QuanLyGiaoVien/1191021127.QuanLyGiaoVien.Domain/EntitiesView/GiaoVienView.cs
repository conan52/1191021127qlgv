using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1191021127.QuanLyGiaoVien.Domain.Entities
{
    public class GiaoVienView
    {
        private long mId;

        public long Id
        {
            get { return mId; }
            set { mId = value; }
        }
        private string mHoTen;

        public string HoTen
        {
            get { return mHoTen; }
            set { mHoTen = value; }
        }
        private string mGioiTinh;

        public string GioiTinh
        {
            get { return mGioiTinh; }
            set { mGioiTinh = value; }
        }
        private string mNgaySinh;

        public string NgaySinh
        {
            get { return mNgaySinh; }
            set { mNgaySinh = value; }
        }
        private string mEmail;

        public string Email
        {
            get { return mEmail; }
            set { mEmail = value; }
        }
        private long mSoDT;

        public long SoDienThoai
        {
            get { return mSoDT; }
            set { mSoDT = value; }
        }
        private float mLuongCoBan;

        public float LuongCoBan
        {
            get { return mLuongCoBan; }
            set { mLuongCoBan = value; }
        }


        private BoMon mBoMon;

        public BoMon BoMon
        {
            get { return mBoMon; }
            set { mBoMon = value; }
        }
        private ChucDanh mChucDanh;

        public ChucDanh ChucDanh
        {
            get { return mChucDanh; }
            set { mChucDanh = value; }
        }
        private ChucVu mChucVu;

        public ChucVu MChucVu
        {
            get { return mChucVu; }
            set { mChucVu = value; }
        }
    }
}
