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

    public partial class Dinhluong : DevExpress.Persistent.BaseImpl.BaseObject
    {
        SanPham fSanphamID;
        [Association(@"DinhluongReferencesSanPham")]
        public SanPham SanphamID
        {
            get { return fSanphamID; }
            set { SetPropertyValue<SanPham>(nameof(SanphamID), ref fSanphamID, value); }
        }
        SanPham fThanhphanID;
        [Association(@"DinhluongReferencesSanPham1")]
        public SanPham ThanhphanID
        {
            get { return fThanhphanID; }
            set { SetPropertyValue<SanPham>(nameof(ThanhphanID), ref fThanhphanID, value); }
        }
        double fSoluong;
        public double Soluong
        {
            get { return fSoluong; }
            set { SetPropertyValue<double>(nameof(Soluong), ref fSoluong, value); }
        }
    }

}
