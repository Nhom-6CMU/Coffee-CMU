﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace CMU.Module.BusinessObjects.ORMDataModel1
{

    public partial class Tieuhao
    {
        public Tieuhao(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
