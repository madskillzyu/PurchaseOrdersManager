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
using PurchaseOrdersManager.HelpClasess;

namespace PurchaseOrdersManager
{
    
    public partial class EmailToDeveloper : Form
    {
        UsersModel curentUser;
        public EmailToDeveloper(UsersModel k)
        {
            InitializeComponent();
            curentUser = k;
        }

        private void buttonSendMail_Click(object sender, EventArgs e)
        {
            string subject = textBoxSubject.Text;
            StringBuilder body = new StringBuilder();
            body.Append("<h1>New Message from:</h1>");
            body.Append(comboBoxIme.Text);
            body.AppendLine();
            body.AppendLine();
            body.Append("<strong>Computer UserName is: </strong>");
            body.Append(Environment.UserName);
            body.AppendLine();
            body.AppendLine();
            body.Append("<strong>Message Body:</strong>");
            body.Append(textBoxBody.Text);
            //try
            //{
            //    EmailLogic email = new EmailLogic(this);
            //    email.SendEmail(body.ToString(), subject);
            //    //EmailLogic.SendEmail(body.ToString(), subject);
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("Nesto nije u redu sa mejl serverom, poruka je sledeca: " + ex,"Obavestenj!", MessageBoxButtons.OK,MessageBoxIcon.Information);
            //}

            if (textBoxSubject.Text != "" || comboBoxIme.Text != "" || textBoxBody.Text != "")
            {
                EmailLogic email = new EmailLogic(this);
                email.SendEmail(body.ToString(), subject);
            }
            else
            {
                MessageBox.Show("Mortate popuniti sva polja. ", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //MessageBox.Show("Mejl je uspesno prosledjen developeru. ","Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.Close();
        }

        public void ChangeLabel(string a)
        {
            lblStatus.Text = a;
        }

        public void ChangeProgressBarValue(int t)
        {
            progressBar1.Value = t;
        }
        public void CloseThisForm()
        {
            MessageBox.Show("Mejl je uspesno prosledjen developeru. ", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void EmailToDeveloper_Load(object sender, EventArgs e)
        {
            //DateTime today = DateTime.Now;
            //int lastYear = Convert.ToInt32(today.ToString("yyyy"));
            List<UsersModel> korisnici = GlobalConfig.Connection.GetAllUsers();
            comboBoxIme.Items.Clear();
            foreach (UsersModel korisnik in korisnici)
            {
                comboBoxIme.Items.Add(korisnik.UserName);
            }

            comboBoxIme.Text = curentUser.UserName;
        }
    }

    
}
