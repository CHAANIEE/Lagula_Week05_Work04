using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonControls
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBarcode.Clear();
            txtName.Clear();
            txtDescription.Clear();

            cmbCategory.SelectedIndex = -1;

            rdoLocal.Checked = false;
            rdoAbroad.Checked = false;

            chkActive.Checked = false;

            txtCost.Clear();
            txtPrice.Clear();
            txtMarkup.Clear();

            txtBarcode.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBarcode.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(cmbCategory.Text))
            {
                MessageBox.Show("Please complete all required fields.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!rdoLocal.Checked && !rdoAbroad.Checked)
            {
                MessageBox.Show("Please select product origin.");
                return;
            }

            decimal cost, price, markup;

            if (!decimal.TryParse(txtCost.Text, out cost) ||
                !decimal.TryParse(txtPrice.Text, out price) ||
                !decimal.TryParse(txtMarkup.Text, out markup))
            {
                MessageBox.Show("Please enter valid numbers for Cost, Price, and Markup.");
                return;
            }

            string barcode = txtBarcode.Text.Trim();
            string name = txtName.Text.Trim();
            string description = txtDescription.Text.Trim();
            string category = cmbCategory.Text;
            string origin = rdoLocal.Checked ? "Local" : "Abroad";
            bool status = chkActive.Checked;

            MessageBox.Show(
                "Product information saved successfully!\n\n" +
                "Barcode: " + barcode +
                "\nName: " + name +
                "\nDescription: " + description +
                "\nCategory: " + category +
                "\nOrigin: " + origin +
                "\nActive: " + status +
                "\nCost: " + cost +
                "\nPrice: " + price +
                "\nMarkup: " + markup + "%",
                "Product Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}

