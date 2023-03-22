﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD2_Travail3 {
    public partial class AjouterImputation : Form
    {
        ManagerImputation managerImputation;
        ManagerInventaire managerInventaire;
        public AjouterImputation()
        {
            InitializeComponent();
            managerInventaire = new ManagerInventaire();
        }

        private void btnRechercher_Click(object sender, EventArgs e) {
            try
            {
                
                dgvAfficherPiece.DataSource = managerInventaire.listerInventaire(txtRechercheNumeroPiece.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
