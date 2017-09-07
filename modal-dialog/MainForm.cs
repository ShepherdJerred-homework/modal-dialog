using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modal_dialog
{
    public partial class MainForm : Form
    {
        public MainForm(ModalBus modalBus) {
            this.modalBus = modalBus;
            InitializeComponent();
            UpdateFromBus();
        }

        private void UpdateFromBus() { 
            GroupBox options = (GroupBox) Controls["Options"];
            ((CheckBox) options.Controls["Outline"]).Checked = modalBus.HasOutline;
            ((CheckBox) options.Controls["Shadow"]).Checked = modalBus.HasShadow;
            ((CheckBox) options.Controls["Gradient"]).Checked = modalBus.HasGradient;
            ((ComboBox) Controls["Color"]).SelectedItem = modalBus.Color;
            ((TextBox) Controls["ShapeName"]).Text = modalBus.Name;
        }

        private void Open_Click(object sender, EventArgs e) {
            ModalForm modal = new ModalForm(modalBus);
            modal.ShowDialog(this);
            UpdateFromBus();
        }
    }
}
