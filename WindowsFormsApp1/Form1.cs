using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Persona.lista.Add(new Persona("Luis Felipe", "Munoz Flores"));
            Persona.lista.Add(new Persona("Jose", "Maria"));

            
            
        }
        public void  ActualizarFuente() {
            gridControl1.BeginUpdate();

            try

            {

                gridView1.Columns.Clear();

                gridControl1.DataSource = null;

                gridControl1.DataSource = Persona.lista;

            }

            finally

            {

                gridControl1.EndUpdate();

            }
        }

        

            private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            DevExpress.XtraTab.XtraTabPage tabPage = new DevExpress.XtraTab.XtraTabPage();
            tabPage.Text = "Nuevo Prestamo";
            tabPage.Name = "nuevoPrestamo";
            /*Control control = new Control();
            control.Text = "Hola";
            control.Dock = DockStyle.Fill;
            control.BackColor = Color.Black;*/
            
            tabPage.Controls.Add(new XtraUserControl1());
            
            


            this.tabcontrol.TabPages.Add(tabPage);
            this.tabcontrol.TabPages[tabcontrol.TabPages.Count() - 1].Show();



        }

        private void tabcontrol_CloseButtonClick(object sender, EventArgs e)
        {
            DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs arg = e as DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs;
            (arg.Page as DevExpress.XtraTab.XtraTabPage).PageVisible = false;
        }

       

        private void tabcontrol_Selected(object sender, DevExpress.XtraTab.TabPageEventArgs e)
        {
            this.ActualizarFuente();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraTab.XtraTabPage tabPage = new DevExpress.XtraTab.XtraTabPage();
            tabPage.Text = "Nuevo Cliente";
            tabPage.Name = "nuevoCliente";
            /*Control control = new Control();
            control.Text = "Hola";
            control.Dock = DockStyle.Fill;
            control.BackColor = Color.Black;*/

            tabPage.Controls.Add(new XtraUserControl2());




            this.tabcontrol.TabPages.Add(tabPage);
            this.tabcontrol.TabPages[tabcontrol.TabPages.Count() - 1].Show();
        }
    }
}
