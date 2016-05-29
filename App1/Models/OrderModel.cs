using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace App1
{
    class OrderModel
    {
        private static string FilePath = @"Assets/orders.json";

        public string SystemId { get; set; }
        public CategoryModel Category { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime Created_at { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Status Status { get; set; }

        public static OrderModel SelectedOrder;
        

        public static IEnumerable<OrderModel> GetOrders()
        {
            StreamReader reader = File.OpenText(FilePath);
            var j = (JObject)JToken.ReadFrom(new JsonTextReader(reader));
            var array = (JArray)j.SelectToken("orders");
            return array.ToObject<IEnumerable<OrderModel>>();

        }
    }
}
