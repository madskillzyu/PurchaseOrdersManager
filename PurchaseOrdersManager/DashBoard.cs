﻿using NarudzbenicaModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PurchaseOrdersManager
{
    public partial class Dashboard : Form
    {
        public Dashboard(UsersModel u)
        {
            InitializeComponent();
        }

        private void buttonRemowePozicija_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {

        }

        private void buttonSacuvaj_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonPrimopredajniObrazac_Click(object sender, EventArgs e)
        {

        }

        private void buttonZapisnik_Click(object sender, EventArgs e)
        {

        }

        private void buttonFaktura_Click(object sender, EventArgs e)
        {

        }

        private void buttonNarudzbenica_Click(object sender, EventArgs e)
        {

        }

        private void kontrolaNalogaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewUser n = new AddNewUser();
            n.ShowDialog();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void izmeniPutanjuDoBazeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void istorijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History h = new History();
            h.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.ShowDialog();
        }

        private void bugReportFeatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmailToDeveloper d = new EmailToDeveloper(user);
            d.ShowDialog();
        }
    }
}
