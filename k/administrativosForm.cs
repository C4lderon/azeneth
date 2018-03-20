using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k
{
    public partial class administrativosForm : Form
    {
        public administrativosForm()
        {
            InitializeComponent();
        }

        private void administrativosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.administrativosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basedatoskDataSet);

        }

        private void administrativosForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basedatoskDataSet.administrativos' Puede moverla o quitarla según sea necesario.
            this.administrativosTableAdapter.Fill(this.basedatoskDataSet.administrativos);

        }
    }
}
