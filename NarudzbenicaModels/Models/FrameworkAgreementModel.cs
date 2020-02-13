using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarudzbenicaModels.Models
{
    class FrameworkAgreementModel
    {
        public String City { get; set; }
        public String NumberOfFrameworkAgreement { get; set; }

        public FrameworkAgreementModel()
        {

        }

        public FrameworkAgreementModel(String city, String numberOfFrameworkAgreement)
        {
            this.City = city;
            this.NumberOfFrameworkAgreement = numberOfFrameworkAgreement;
        }

        /// <summary>
        /// Property for returnig new string which consist og City name and the number of fremework agreement
        /// </summary>
        public String NAmeOfFrameworkAgreement
        {
            get
            {
                return $"{City} - {NumberOfFrameworkAgreement}";
            }
        }
    }
}
