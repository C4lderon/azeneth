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
    public partial class administrativoForm : Form
    {
        private basedatoskDataSet basedatoskDataSet;
        private BindingSource administrativosBindingSource;
        private IContainer components;
        private basedatoskDataSetTableAdapters.administrativosTableAdapter administrativosTableAdapter;
        private basedatoskDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BindingNavigator administrativosBindingNavigator;
        private ToolStripButton bindingNavigatorAddNewItem;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorDeleteItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private TextBox nombreTextBox;
        private TextBox claveTextBox;
        private ToolStripButton administrativosBindingNavigatorSaveItem;

        public administrativoForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(administrativoForm));
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label claveLabel;
            this.basedatoskDataSet = new k.basedatoskDataSet();
            this.administrativosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.administrativosTableAdapter = new k.basedatoskDataSetTableAdapters.administrativosTableAdapter();
            this.tableAdapterManager = new k.basedatoskDataSetTableAdapters.TableAdapterManager();
            this.administrativosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.administrativosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            nombreLabel = new System.Windows.Forms.Label();
            claveLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.basedatoskDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrativosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrativosBindingNavigator)).BeginInit();
            this.administrativosBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // basedatoskDataSet
            // 
            this.basedatoskDataSet.DataSetName = "basedatoskDataSet";
            this.basedatoskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // administrativosBindingSource
            // 
            this.administrativosBindingSource.DataMember = "administrativos";
            this.administrativosBindingSource.DataSource = this.basedatoskDataSet;
            // 
            // administrativosTableAdapter
            // 
            this.administrativosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.administrativosTableAdapter = this.administrativosTableAdapter;
            this.tableAdapterManager.alumnosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.directorTableAdapter = null;
            this.tableAdapterManager.maestrosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = k.basedatoskDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // administrativosBindingNavigator
            // 
            this.administrativosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.administrativosBindingNavigator.BindingSource = this.administrativosBindingSource;
            this.administrativosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.administrativosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.administrativosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.administrativosBindingNavigatorSaveItem});
            this.administrativosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.administrativosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.administrativosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.administrativosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.administrativosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.administrativosBindingNavigator.Name = "administrativosBindingNavigator";
            this.administrativosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.administrativosBindingNavigator.Size = new System.Drawing.Size(284, 25);
            this.administrativosBindingNavigator.TabIndex = 0;
            this.administrativosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // administrativosBindingNavigatorSaveItem
            // 
            this.administrativosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.administrativosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("administrativosBindingNavigatorSaveItem.Image")));
            this.administrativosBindingNavigatorSaveItem.Name = "administrativosBindingNavigatorSaveItem";
            this.administrativosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.administrativosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.administrativosBindingNavigatorSaveItem.Click += new System.EventHandler(this.administrativosBindingNavigatorSaveItem_Click);
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(73, 67);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(45, 13);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.administrativosBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(124, 64);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 2;
            // 
            // claveLabel
            // 
            claveLabel.AutoSize = true;
            claveLabel.Location = new System.Drawing.Point(73, 93);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new System.Drawing.Size(36, 13);
            claveLabel.TabIndex = 3;
            claveLabel.Text = "clave:";
            // 
            // claveTextBox
            // 
            this.claveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.administrativosBindingSource, "clave", true));
            this.claveTextBox.Location = new System.Drawing.Point(124, 90);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.Size = new System.Drawing.Size(100, 20);
            this.claveTextBox.TabIndex = 4;
            // 
            // administrativoForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(claveLabel);
            this.Controls.Add(this.claveTextBox);
            this.Controls.Add(this.administrativosBindingNavigator);
            this.Name = "administrativoForm";
            this.Load += new System.EventHandler(this.administrativoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.basedatoskDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrativosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrativosBindingNavigator)).EndInit();
            this.administrativosBindingNavigator.ResumeLayout(false);
            this.administrativosBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void administrativosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.administrativosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basedatoskDataSet);

        }

        private void administrativoForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basedatoskDataSet.administrativos' Puede moverla o quitarla según sea necesario.
            this.administrativosTableAdapter.Fill(this.basedatoskDataSet.administrativos);

        }
    }
}
