using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace App1
{
    class OrderModel
    {
        private static string FilePath = @"Assets/orders.json";

        public string Name { get; set; }
        public CategoryModel Category { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime Created_at { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Status Status { get; set; }

        public static OrderModel SelectedOrder;


    }
}
