using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class CategoryModel
    {
        public string Name { get; set; }
        public List<CategoryModel> Children = new List<CategoryModel>();
        public static CategoryModel SelectedCat = null;
        public static List<CategoryModel> Categories = new List<CategoryModel>();

        public CategoryModel()
        {
            Categories.Add(this);
        }
    }


}
