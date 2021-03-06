﻿using System;

namespace Kona.Model {
    public class InventoryRecord {

        public int ID { get; set; }
        public int ProductID { get; set; }
        public DateTime DateEntered { get; set; }
        public int Increment { get; set; }
        public string Notes { get; set; }


        public InventoryRecord(int productID, int increment, string notes) {
            ProductID = productID;
            Increment = increment;
            Notes = notes;
            DateEntered = DateTime.Now;
        }

        public InventoryRecord() { }
    }

    

}
