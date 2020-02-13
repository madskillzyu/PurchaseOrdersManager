using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarudzbenicaModels.Models
{
    class PositionModel
    {
        public int PositionID { get; set; }
        public int PurchaseOrder_ID { get; set; }
        public String PositionName { get; set; }

        public PositionModel()
        {

        }

        public PositionModel(string positionName)
        {
            this.PositionName = positionName;
        }
    }
}
