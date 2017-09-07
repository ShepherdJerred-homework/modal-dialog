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
    public partial class ModalForm : Form
    {
        public ModalForm(ModalBus modalBus) {
            this.modalBus = modalBus;
            InitializeComponent();
            UpdateFromBus();
        }

        private void UpdateFromBus() {
            GroupBox options = (GroupBox)Controls["Options"];
            ((CheckBox)options.Controls["Outline"]).Checked = modalBus.HasOutline;
            ((CheckBox)options.Controls["Shadow"]).Checked = modalBus.HasShadow;
            ((CheckBox)options.Controls["Gradient"]).Checked = modalBus.HasGradient;
            ((ComboBox)Controls["Color"]).SelectedItem = modalBus.Color;
            ((TextBox)Controls["ShapeName"]).Text = modalBus.Name;
        }

        private void Cancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void Save_Click(object sender, EventArgs e) {
            GroupBox options = (GroupBox)Controls["Options"];
            modalBus.HasShadow = ((CheckBox)options.Controls["Outline"]).Checked;
            modalBus.HasShadow = ((CheckBox)options.Controls["Shadow"]).Checked;
            modalBus.HasGradient = ((CheckBox)options.Controls["Gradient"]).Checked;
            modalBus.Color= (Color) ((ComboBox)Controls["Color"]).SelectedItem;
            modalBus.Name = ((TextBox)Controls["ShapeName"]).Text;
            Close();
        }

        private void Modal_Load(object sender, EventArgs e) {

        }
    }

}
