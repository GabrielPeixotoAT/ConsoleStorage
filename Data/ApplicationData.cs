using Newtonsoft.Json;
using ConsoleStorage.Models.Movement;
using ConsoleStorage.Models.Product;
using ConsoleStorage.Models.Purchase;
using ConsoleStorage.Models.PurchaseOrder;
using ConsoleStorage.Models.Sale;
using ConsoleStorage.Models.Store;
using ConsoleStorage.Models.Supplier;

namespace ConsoleStorage.Data
{
    public class ApplicationData
    {
        #region Movement
            public List<MovementType> MovementTypes { get; set; }
            public List<Movement> Movements { get; set; }
        #endregion

        #region Product
            public List<Product> Products { get; set; }
        #endregion

        #region Purchase
            public List<Purchase> Purchases { get; set; }
            public List<PurchaseItem> PurchaseItems { get; set; }
        #endregion

        #region PurchaseOrder
            public List<PurchaseOrder> PurchaseOrders { get; set; }
            public List<PurchaseOrderItem> PurchaseOrderItems { get; set; }
            public List<PurchaseOrderStatus> PurchaseOrderStatus { get; set; }
        #endregion

        #region Sale
            public List<Sale> Sales { get; set; }
            public List<SaleItems> SaleItems { get; set; }
            public List<Devolution> Devolutions { get; set; }
        #endregion

        #region Store
            public List<Store> Stores { get; set; }
            public List<StoreAddress> StoreAddresses { get; set; }
            public List<StorePhone> StorePhones { get; set; }
        #endregion

        #region Supplier
            public List<Supplier> Suppliers { get; set; }
            public List<SupplierAddress> SupplierAddresses { get; set; }
            public List<SupplierPhone> SupplierPhones { get; set; }
        #endregion

        public void SaveChanges()
        {
            string jsonText = JsonConvert.SerializeObject(this);

            using (StreamWriter sw = File.CreateText("Data/.data/data.json"))
            {
                sw.WriteLine(jsonText);
            }
        }
    }
}