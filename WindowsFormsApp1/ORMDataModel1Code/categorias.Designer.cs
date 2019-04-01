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
namespace WindowsFormsApp1.inventario
{

    public partial class categorias : XPLiteObject
    {
        uint fidCategoria;
        [Key]
        public uint idCategoria
        {
            get { return fidCategoria; }
            set { SetPropertyValue<uint>(nameof(idCategoria), ref fidCategoria, value); }
        }
        string fnombre;
        [Indexed(Name = @"nombre", Unique = true)]
        [Size(50)]
        public string nombre
        {
            get { return fnombre; }
            set { SetPropertyValue<string>(nameof(nombre), ref fnombre, value); }
        }
        string fdescripcion;
        [Size(50)]
        public string descripcion
        {
            get { return fdescripcion; }
            set { SetPropertyValue<string>(nameof(descripcion), ref fdescripcion, value); }
        }
        [Association(@"productosReferencescategorias")]
        public XPCollection<productos> productosCollection { get { return GetCollection<productos>(nameof(productosCollection)); } }
    }

}