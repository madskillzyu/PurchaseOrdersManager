using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarudzbenicaModels.Models
{
    public class PurchaseOrderModel
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

        /// <summary>
        /// Constructor without id field
        /// </summary>
        public PurchaseOrderModel(String numberOfPurchaseOrder, DateTime dateOfPurchaseOrder, DateTime expirationDateOfPurchaseOrder, String frameworkAgreement,
            String branch, String nameOfSubstation, DateTime invoiceDate, String invoiceNumber, String amountExcludingVAT, DateTime dateOfAdmissionEPS,
            String reportNumber, String note, int reportIsSent, String purchaseOrderPdf, String servicePerformanceRecord, String invoicePDF, String handoverForm, String user, DateTime date )
        {
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

        }
        /// <summary>
        /// Constructor
        /// </summary>
        public PurchaseOrderModel()
        {

        }
        /// <summary>
        /// Construktor with ID field
        /// </summary>
        /// <param name="numberOfPurchaseOrder"></param>
        /// <param name="dateOfPurchaseOrder"></param>
        /// <param name="expirationDateOfPurchaseOrder"></param>
        /// <param name="frameworkAgreement"></param>
        /// <param name="branch"></param>
        /// <param name="nameOfSubstation"></param>
        /// <param name="invoiceDate"></param>
        /// <param name="invoiceNumber"></param>
        /// <param name="amountExcludingVAT"></param>
        /// <param name="dateOfAdmissionEPS"></param>
        /// <param name="reportNumber"></param>
        /// <param name="note"></param>
        /// <param name="reportIsSent"></param>
        /// <param name="purchaseOrderPdf"></param>
        /// <param name="servicePerformanceRecord"></param>
        /// <param name="invoicePDF"></param>
        /// <param name="handoverForm"></param>
        /// <param name="user"></param>
        /// <param name="date"></param>
        public PurchaseOrderModel(int id, String numberOfPurchaseOrder, DateTime dateOfPurchaseOrder, DateTime expirationDateOfPurchaseOrder, String frameworkAgreement,
            String branch, String nameOfSubstation, DateTime invoiceDate, String invoiceNumber, String amountExcludingVAT, DateTime dateOfAdmissionEPS,
            String reportNumber, String note, int reportIsSent, String purchaseOrderPdf, String servicePerformanceRecord, String invoicePDF, String handoverForm, String user, DateTime date)
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

        }
    }
}
