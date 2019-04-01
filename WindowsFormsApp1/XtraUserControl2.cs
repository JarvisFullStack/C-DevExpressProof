using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WindowsFormsApp1.inventario;

namespace WindowsFormsApp1
{
    public partial class XtraUserControl2 : DevExpress.XtraEditors.XtraUserControl
    {
        public XtraUserControl2()
        {
            InitializeComponent();
            DevExpress.Xpo.XPCollection < categorias > coleccion = new DevExpress.Xpo.XPCollection<categorias>();
            coleccion.Load();
            this.gridControl1.DataSource = coleccion;
            
        }
    }
}
