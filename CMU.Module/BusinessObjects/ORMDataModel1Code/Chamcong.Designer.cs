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

    public partial class Chamcong : DevExpress.Persistent.BaseImpl.BaseObject
    {
        Nhanvien fNhanvienID;
        [Association(@"ChamcongReferencesNhanvien")]
        public Nhanvien NhanvienID
        {
            get { return fNhanvienID; }
            set { SetPropertyValue<Nhanvien>(nameof(NhanvienID), ref fNhanvienID, value); }
        }
        double fGiovao;
        public double Giovao
        {
            get { return fGiovao; }
            set { SetPropertyValue<double>(nameof(Giovao), ref fGiovao, value); }
        }
        double fGiora;
        public double Giora
        {
            get { return fGiora; }
            set { SetPropertyValue<double>(nameof(Giora), ref fGiora, value); }
        }
    }

}
