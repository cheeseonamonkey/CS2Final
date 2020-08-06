using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS2Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //inputs LINQ query, outputs data to left rtb
        void PrintLeft(object o)
        {
            if (o is IEnumerable<Customer>)
            {
                IEnumerable<Customer> custList = o as IEnumerable<Customer>;
                rtbLeft.Clear();
                rtbLeft.AppendText(Customer.GetCustomerLegend());
                foreach (Customer c in custList)
                {
                    rtbLeft.AppendText($"{c.ToString()}\n");
                }
            }
            else if (o is IEnumerable<Inventory>)
            {
                IEnumerable<Inventory> inventoryList = o as IEnumerable<Inventory>;
                rtbLeft.Clear();
                rtbLeft.AppendText(Inventory.GetInventoryLegend());
                foreach (Inventory e in inventoryList)
                {
                    rtbLeft.AppendText($"{e.ToString()}\n");
                }
            }
        }
        
        //customers by name radiobutton
        private void RdbCustByName_CheckedChanged(object sender, EventArgs e)
        {
            var custsByName =
                from c in Program.customers
                orderby c.Last
                select c;

            PrintLeft(custsByName);
        }

        //customers by ID rdb
        private void RdbCustById_CheckedChanged(object sender, EventArgs e)
        {
            var custsById =
                from c in Program.customers
                orderby c.Id
                select c;

            PrintLeft(custsById);
        }

        //inventory by price rdb
        private void RdbInvByPrice_CheckedChanged(object sender, EventArgs e)
        {
            var invByPrice =
                from i in Program.inventory
                orderby i.Price
                select i;

            PrintLeft(invByPrice);
        }

        //inventory by ID rdb
        private void RdbInvById_CheckedChanged(object sender, EventArgs e)
        {
            var invById =
                from i in Program.inventory
                orderby i.Id
                select i;

            PrintLeft(invById);
        }

        //============================================================================

        private async void RdbInvoices_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInvoices.Checked)
            {
                //async write methods for task output, invokes from control
                void Write(string a) => rtbRight.Invoke(new Action(()
                    => rtbRight.AppendText(a)));

                void Clear() => rtbRight.Invoke(new Action(()
                    => rtbRight.Clear()));


                rtbRight.Clear();

                //query
                var invoices =
                    from invoice in Program.invoices
                    join c in Program.customers
                    on invoice.CustomerId equals c.Id
                    join item in Program.invoiceItems
                    on invoice.Id equals item.InvoiceId
                    join inventory in Program.inventory
                    on item.InventoryItemId equals inventory.Id

                    let cost = item.Quantity * inventory.Price

                    group new { item.InventoryItemId, item.LineNumber, item.Quantity, inventory.Name, inventory.Price, Cost = cost } by new { InvoiceId = invoice.Id, invoice.Date, c.Name, CustomerId = c.Id } into g
                    orderby g.Key.InvoiceId
                    select g;

                //task for everything
                rtbRight.Clear();
                rtbRight.AppendText("Fetching information, please wait...");
                await Task.Run(() => DoInvoices());

                void DoInvoices()
                {
                    //expensive method call to simulate processing time
                    FIbonacci.GetFibRecursively(39);
                    //============================

                    Clear();

                    //prints data from queries
                    foreach (var g in invoices)
                    {
                        double invoiceTotal = 0;
                        Write($"Invoice  #{g.Key.InvoiceId,-4}  - {g.Key.Date,18}\n" +
                              $"Customer #{g.Key.CustomerId,-4}  - {g.Key.Name,18}\n" +
                              $"----------------------------------------------------------\n");

                        foreach (var v in g)
                        {
                            Write($" -{v.LineNumber.ToString(),-2} {v.Name,-20} {v.Quantity,3} sold @{v.Price,-6:C} ea.      Cost: {v.Cost,8:C}\n");
                            invoiceTotal += v.Cost;
                        }

                        Write($"Invoice total: {invoiceTotal,8:C}\n");
                        Write("\n\n");
                    }

                }
            }
        }

        private async void RdbInvSold_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInvSold.Checked)
            {
                //async write methods for task output, invokes from control
                void Write(string a) => rtbRight.Invoke(new Action(() 
                    => rtbRight.AppendText(a)));
                void Clear() => rtbRight.Invoke(new Action(() 
                    => rtbRight.Clear()));
                rtbRight.Clear();

                //queries
                var inventory =
                    from i in Program.inventory

                    join sale in Program.invoiceItems
                    on i.Id equals sale.InventoryItemId

                    let cost = sale.Quantity * i.Price

                    group new { sale.InvoiceId, sale.Quantity, Cost = cost } by new { i.Id, i.Name } into g
                    select g;


                //task for everything
                rtbRight.Clear();
                rtbRight.AppendText("Fetching information, please wait...");
                await Task.Run(() => DoInvoices());



                void DoInvoices()
                {
                    //expensive method call to simulate processing time
                    FIbonacci.GetFibRecursively(39);
                    //============================

                    Clear();

                    foreach (var g in inventory)
                    {
                        Write($"Item #{g.Key.Id,5}, {g.Key.Name,-20}\n" +
                            $"--------------------------------\n");
                        double totalCost = 0;
                        int totalSold = 0;
                        foreach (var i in g)
                        {
                            Write($"Invoice #{i.InvoiceId,-3} sold {i.Quantity,-4} - {i.Cost:C}\n");
                            totalCost += i.Cost;
                            totalSold += i.Quantity;
                        }
                        Write($"Total sold: {totalSold}\n");
                        Write($"Total cost: {totalCost:C}\n");
                        Write("\n\n");
                    }
                }
            }
        }

        private async void RdbInvoicesByCust_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbInvoicesByCust.Checked)
            {
                //async write methods for task output, invokes from control
            void Write(string a) => rtbRight.Invoke(new Action(() 
                => rtbRight.AppendText(a)));
            void Clear() => rtbRight.Invoke(new Action(() 
                => rtbRight.Clear()));

            rtbRight.Clear();

            //queries
            var itemCosts =
                from invoice in Program.invoices
                join item in Program.invoiceItems
                on invoice.Id equals item.InvoiceId
                join inventory in Program.inventory
                on item.InventoryItemId equals inventory.Id

                let cost = item.Quantity * inventory.Price

                group new {invoice, item, inventory, Cost=cost } by invoice into g
                select g;

            


            var invoicesByCust =
                from invoice in Program.invoices
                join cust in Program.customers
                on invoice.CustomerId equals cust.Id
                
                orderby cust.Id
                group invoice by cust into g
                select g;

            //task for everything
            rtbRight.Clear();
            rtbRight.AppendText("Fetching information, please wait...");
            await Task.Run(() => DoInvoices());

            void DoInvoices()
                {
                    //expensive method call to simulate processing time
                    FIbonacci.GetFibRecursively(39);
                    //============================

                    Clear();

                    double allSalesTotal = 0;
                    double GetInvoiceCosts(int invoiceId)
                    {
                        double a = 0;
                        foreach (var g in itemCosts)
                            if (g.Key.Id == invoiceId)
                                foreach (var v in g)
                                    a += v.Cost;
                        return a;
                    }
                    foreach (var g in invoicesByCust)
                    {

                        Write($"Customer #{g.Key.Id}:\n------------------\n");
                        double custTotal = 0;
                        foreach (var v in g)
                        {
                            custTotal += GetInvoiceCosts(v.Id);
                            allSalesTotal += GetInvoiceCosts(v.Id);
                            Write($"  -Invoice #{v.Id,-3} {v.Date,10}  -  {GetInvoiceCosts(v.Id),8:C}\n");
                        }
                        Write($"Customer total:             -{custTotal,10:C}\n");
                        Write("\n");
                    }


                    Write($"All sales total: {allSalesTotal:C}\n\n");
                }
            }
        }
    }
}
