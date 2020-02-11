using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarudzbenicaModels.Models
{
    class PurchaseOrderModel
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
        public int ReportIsSent { get; set; }
        public String PurchaseOrderPDF { get; set; }
        public String ServicePerformanceRecord { get; set; }
        public String InvoicePDF { get; set; }
        public String HandoverForm { get; set; }
        public String User { get; set; }
        public DateTime Date { get; set; }
    }
}
