﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 25/9/2017 6:05:09 PM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;

namespace outGoModel
{
    public partial class Pagos {

        public Pagos()
        {
            OnCreated();
        }

        public virtual int Id
        {
            get;
            set;
        }

        public virtual int IdFactura
        {
            get;
            set;
        }

        public virtual System.Nullable<int> IdPersona
        {
            get;
            set;
        }

        public virtual double MontoPagado
        {
            get;
            set;
        }

        public virtual Facturas Facturas
        {
            get;
            set;
        }

        public virtual Personas Personas
        {
            get;
            set;
        }
    
        #region Extensibility Method Definitions

        partial void OnCreated();
        
        #endregion
    }

}
