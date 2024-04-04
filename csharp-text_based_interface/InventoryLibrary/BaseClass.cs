using System;

namespace InventoryLibrary
{
    public class BaseClass
    {
        // Properties
        public string Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        // Constructor
        public BaseClass()
        {
            // Set default values for date_created and date_updated
            DateCreated = DateTime.Now;
            DateUpdated = DateTime.Now;
        }
    }
}

