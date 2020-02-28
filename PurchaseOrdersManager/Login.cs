using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NarudzbenicaModels;
using NarudzbenicaModels.Models;

namespace PurchaseOrdersManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = korisnickoImeValue; // prilikom prekretanja projekta polje korisnicko ime ce biti aktivno(focused) i mozemo odmah da kucamo kod
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            UsersModel u = new UsersModel();

            u.UserName = "username";

            if (korisnickoImeValue.Text == "username" && lozinkaValues.Text == "backdoor")
            {
                Dashboard d = new Dashboard(u);
                d.Show();
                this.Hide();
                return;
            }
        }
    }
}
