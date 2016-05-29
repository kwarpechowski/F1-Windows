using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace App1
{
    class OrderModel
    {
        public string SystemId { get; set; }
        public CategoryModel Category { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime Created_at { get; set; }
        public Status Status { get; set; }
        public static OrderModel SelectedOrder;
        

        public static List<OrderModel> GetOrders()
        {
            return JsonConvert.DeserializeObject<List<OrderModel>>(File.ReadAllText(@"Assets/orders.json"));
          
        }
    }
}
