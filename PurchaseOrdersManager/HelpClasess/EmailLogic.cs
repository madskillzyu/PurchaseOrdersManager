using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Mail;
using System.ComponentModel;
using System.Windows.Forms;
using PurchaseOrdersManager;

namespace PurchaseOrdersManager.HelpClasess
{
    public class EmailLogic
    {
        private string bodyM = "";
        private string subjectM = "";
        private BackgroundWorker m_oWorker;
        EmailToDeveloper formaZaSlanje;
        public EmailLogic(EmailToDeveloper p)
        {
            formaZaSlanje = p;
        }
        //Label b = new Label();
        public void SendEmail(string body, string subject)
        {
            bodyM = body;
            subjectM = subject;

            m_oWorker = new BackgroundWorker();
            m_oWorker.DoWork += new DoWorkEventHandler(m_oWorker_DoWork);
            m_oWorker.ProgressChanged += new ProgressChangedEventHandler(m_oWorker_ProgressChanged);
            m_oWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(m_oWorker_RunWorkerCompleted);
            m_oWorker.WorkerReportsProgress = true;
            m_oWorker.WorkerSupportsCancellation = true;
            setMail();
        }

        private void setMail()
        {
            m_oWorker.RunWorkerAsync();
        }



        //**************************************************************************************************************
        private void m_oWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //If it was cancelled midway
            if (e.Cancelled)
            {
                formaZaSlanje.ChangeLabel("Task Cancelled.");

            }
            else if (e.Error != null)
            {
                formaZaSlanje.ChangeLabel("Error while performing background operation.");
            }
            else
            {
                formaZaSlanje.ChangeLabel("Mail is sent...");
                formaZaSlanje.CloseThisForm();
            }
        }

        /// <summary>
        /// Notification is performed here to the progress bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_oWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Here you play with the main UI thread
            formaZaSlanje.ChangeProgressBarValue(e.ProgressPercentage);
            formaZaSlanje.ChangeLabel("Sending email......" + e.ProgressPercentage.ToString() + "%");
        }

        /// <summary>
        /// Time consuming operations go here </br>
        /// i.e. Database operations,Reporting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_oWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //NOTE : Never play with the UI thread here...

            MailAddress fromMailAdress = new MailAddress("lidacdocuments@gmail.com", "LidacApp No1");
            MailMessage mail = new MailMessage();
            mail.To.Add("lidacdocuments@gmail.com");
            mail.From = fromMailAdress;
            mail.Subject = subjectM;
            mail.Body = bodyM;
            mail.IsBodyHtml = true;

            SmtpClient client = new SmtpClient();

            client.Send(mail);

            //Report 100% completion on operation completed
            m_oWorker.ReportProgress(100);
        }




    }
}
