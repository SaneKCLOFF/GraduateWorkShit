using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesServicesSoftwareModule.Models.Entities
{
    internal class Product
    {
        public int ProductId { get; set; }
        public int ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Image { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Cost { get; set; }
        public int CountInStock { get; set; }
        public int Discount { get; set; }
        public DateTime DateOfAdd { get; set; }
        

        #region Custom Fields
        private string _correctImagePath = null!;
        public string CorrectImagePath 
        { 
            get => (_correctImagePath==null || _correctImagePath==String.Empty) 
                ? @"\Resources\DatabasePictures\EmptyImage.jpg" : @$"\Resoruces\DatabasePictures\{Image}";
        }
        #endregion
    }
}
