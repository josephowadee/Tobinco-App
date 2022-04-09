using System;
namespace Tobinco.Model
{
    public class MedialSuppliesModel
    {
        public int ItemId { get; set; }
        public string ItemTitle { get; set; }
        public string ItemDiscription { get; set; }
        public string ItemImage { get; set; }
        public Double ItemDiscount { get; set; }
        public Double ItemPrice { get; set; }
        public Double ItemQuantity { get; set; }
        public DateTime DateStamp { get; set; }
    }
}
