using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class OrderModel
    {
        public string SystemId { get; set; }
        public CategoryModel Category { get; set; }
        public float Lat { get; set; }
        public float Lng { get; set; }
        public DateTime Created_at { get; set; }
        public Status Status { get; set; }
        public static OrderModel SelectedOrder;
        

        public static List<OrderModel> GetOrders()
        {
            return JsonConvert.DeserializeObject<List<OrderModel>>(File.ReadAllText(@"Assets/orders.json"));
          
        }
    }
}
