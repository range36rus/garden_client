﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cursovoy_var17.DataBaseForm
{
    public partial class WateringForm : Form
    {
        public WateringForm()
        {
            InitializeComponent();
        }

        private void wateringBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.wateringBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.parkDataSet);

        }

        private void WateringForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parkDataSet.watering' table. You can move, or remove it, as needed.
            this.wateringTableAdapter.Fill(this.parkDataSet.watering);

        }
    }
}
