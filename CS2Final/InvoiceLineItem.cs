using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2Final
{
    class InvoiceItem
    {
        public int InvoiceId
        {
            get; set;
        }

        public int LineNumber
        {
            get; set;
        }
        public int InventoryItemId
        {
            get; set;
        }
        public int Quantity
        {
            get;set;
        }

        public InvoiceItem(int invoiceId, int lineNumber, int inventoryItemId, int quantity)
        {
            InvoiceId = invoiceId;
            LineNumber = lineNumber;
            InventoryItemId = inventoryItemId;
            Quantity = quantity;
        }
    }
}
