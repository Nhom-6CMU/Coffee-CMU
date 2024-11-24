﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace CMU.Module.BusinessObjects.ORMDataModel1
{

    [DefaultProperty("TenSP")]
    public partial class SanPham : DevExpress.Persistent.BaseImpl.BaseObject
    {
        string fTenSP;
        [Size(30)]
        [DevExpress.Xpo.DisplayName(@"Tên sản phẩm")]
        public string TenSP
        {
            get { return fTenSP; }
            set { SetPropertyValue<string>(nameof(TenSP), ref fTenSP, value); }
        }
        string fDVT;
        [Size(10)]
        [DevExpress.Xpo.DisplayName(@"ĐVT")]
        public string DVT
        {
            get { return fDVT; }
            set { SetPropertyValue<string>(nameof(DVT), ref fDVT, value); }
        }
        decimal fGiaBan;
        [DevExpress.Xpo.DisplayName(@"Giá bán")]
        [DevExpress.ExpressApp.Model.ModelDefault("DisplayFormat", "### ### ### ###"),]
        public decimal GiaBan
        {
            get { return fGiaBan; }
            set { SetPropertyValue<decimal>(nameof(GiaBan), ref fGiaBan, value); }
        }
        NhomSP fNhomID;
        [Association(@"SanPhamReferencesNhomSP")]
        public NhomSP NhomID
        {
            get { return fNhomID; }
            set { SetPropertyValue<NhomSP>(nameof(NhomID), ref fNhomID, value); }
        }
        [Association(@"HoadonCTReferencesSanPham"), Aggregated]
        public XPCollection<HoadonCT> HoadonCTs { get { return GetCollection<HoadonCT>(nameof(HoadonCTs)); } }
        [Association(@"DinhluongReferencesSanPham"), Aggregated]
        public XPCollection<Dinhluong> Dinhluongs { get { return GetCollection<Dinhluong>(nameof(Dinhluongs)); } }
        [Association(@"DinhluongReferencesSanPham1"), Aggregated]
        public XPCollection<Dinhluong> Dinhluongs1 { get { return GetCollection<Dinhluong>(nameof(Dinhluongs1)); } }
        [Association(@"TieuhaoReferencesSanPham"), Aggregated]
        public XPCollection<Tieuhao> Tieuhaos { get { return GetCollection<Tieuhao>(nameof(Tieuhaos)); } }
        [Association(@"DonnhapReferencesSanPham"), Aggregated]
        public XPCollection<Donnhap> Donnhaps { get { return GetCollection<Donnhap>(nameof(Donnhaps)); } }
    }

}
