using System.ComponentModel.DataAnnotations; 

namespace Babywendy.models
{
    public class Wendy
    {
public int ID { get; set; }
        public string Title { get; set; } = string.Empty;
        [DataType(DataType.Time)]
        public DateTime PurchaseDate{ get; set; }
        public string Pokemon { get; set; } = string.Empty;
        public decimal Evolution { get; set; }
        
    }
}
