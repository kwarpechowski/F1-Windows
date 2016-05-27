using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public static ObservableCollection<OrderModel> Orders = new ObservableCollection<OrderModel>();

        public OrderModel()
        {
            Orders.Add(this);
        }
    }
}
