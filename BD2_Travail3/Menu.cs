﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD2_Travail3
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void rechercherModificationEmployeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RechercherMoficationEmploye rechercherMoficationEmploye = new RechercherMoficationEmploye();
            rechercherMoficationEmploye.ShowDialog();
        }

        private void ajouterUneImputationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterImputation ajouterImputation = new AjouterImputation();
            ajouterImputation.ShowDialog();
        }

        private void informationSurLesImputationsDunePieceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformationImputationsDUnePiece informationImputationsDUnePiece = new InformationImputationsDUnePiece();
            informationImputationsDUnePiece.ShowDialog();
        }
    }
}
