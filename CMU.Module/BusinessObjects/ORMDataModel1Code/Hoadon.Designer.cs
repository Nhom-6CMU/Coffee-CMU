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

    public partial class Hoadon : DevExpress.Persistent.BaseImpl.BaseObject
    {
        Khachhang fKhachID;
        [Association(@"HoadonReferencesKhachhang")]
        public Khachhang KhachID
        {
            get { return fKhachID; }
            set { SetPropertyValue<Khachhang>(nameof(KhachID), ref fKhachID, value); }
        }
        Nhanvien fNhanvienID;
        [Association(@"HoadonReferencesNhanvien")]
        public Nhanvien NhanvienID
        {
            get { return fNhanvienID; }
            set { SetPropertyValue<Nhanvien>(nameof(NhanvienID), ref fNhanvienID, value); }
        }
        DateTime fSongay;
        [DevExpress.ExpressApp.Model.ModelDefault("EditMask", "dd/MM/yyyy HH:mm"),
DevExpress.ExpressApp.Model.ModelDefault("DisplayFormat", "{0:dd/MM/yyyy HH:mm}")
]
        public DateTime Songay
        {
            get { return fSongay; }
            set { SetPropertyValue<DateTime>(nameof(Songay), ref fSongay, value); }
        }
        [Association(@"HoadonCTReferencesHoadon"), Aggregated]
        public XPCollection<HoadonCT> HoadonCTs { get { return GetCollection<HoadonCT>(nameof(HoadonCTs)); } }
    }

}
