using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarudzbenicaModels.Models
{
    public class PurchaseOrederPositionModel
    {

        public int ID { get; set; }


        public String NumberOfPurchaseOrder { get; set; }
        public DateTime DateOfPurchaseOrder { get; set; }
        public DateTime ExpirationDateOfPurchaseOrder { get; set; }
        public String FrameworkAgreement { get; set; }
        public String Branch { get; set; }
        public String NameOfSubstation { get; set; }
        public DateTime InvoiceDate { get; set; }
        public String InvoiceNumber { get; set; }
        public String AmountExcludingVAT { get; set; }
        public DateTime DateOfAdmissionEPS { get; set; }
        public String ReportNumber { get; set; }
        public String Note { get; set; }
        public int ReportIsSent { get; set; } // should be boolean
        public String PurchaseOrderPDF { get; set; }
        public String ServicePerformanceRecord { get; set; }
        public String InvoicePDF { get; set; }
        public String HandoverForm { get; set; }
        public String User { get; set; }
        public DateTime Date { get; set; }

        public List<PositionModel> Positions = new List<PositionModel>();

        public PurchaseOrederPositionModel()
        {

        }

        public PurchaseOrederPositionModel(int id, String numberOfPurchaseOrder, DateTime dateOfPurchaseOrder, DateTime expirationDateOfPurchaseOrder, String frameworkAgreement,
            String branch, String nameOfSubstation, DateTime invoiceDate, String invoiceNumber, String amountExcludingVAT, DateTime dateOfAdmissionEPS,
            String reportNumber, String note, int reportIsSent, String purchaseOrderPdf, String servicePerformanceRecord, String invoicePDF, String handoverForm, 
            String user, DateTime date, List<PositionModel> listapozicija)
        {
            this.ID = id;
            this.NumberOfPurchaseOrder = numberOfPurchaseOrder;
            this.DateOfPurchaseOrder = dateOfPurchaseOrder;
            this.ExpirationDateOfPurchaseOrder = expirationDateOfPurchaseOrder;
            this.FrameworkAgreement = frameworkAgreement;
            this.Branch = branch;
            this.NameOfSubstation = nameOfSubstation;
            this.InvoiceDate = invoiceDate;
            this.InvoiceNumber = invoiceNumber;
            this.AmountExcludingVAT = amountExcludingVAT;
            this.DateOfAdmissionEPS = dateOfAdmissionEPS;
            this.ReportNumber = reportNumber;
            this.Note = note;
            this.ReportIsSent = reportIsSent;
            this.PurchaseOrderPDF = purchaseOrderPdf;
            this.ServicePerformanceRecord = servicePerformanceRecord;
            this.InvoicePDF = invoicePDF;
            this.HandoverForm = handoverForm;
            this.User = user;
            this.Date = date;
            this.Positions = listapozicija;

        }


    }
}
