using Common;
using Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.DataBaseModels
{
    [Table("Advert")]
    public class Advert : BaseEntity
    {
        public string Description { get; set; }
        public string Address { get; set; }
        public string Square { get; set; }
        public string Floor { get; set; }
        public EstateTypes EstateType { get; set; }
        public AdvertTypes Edvert { get; set; }
        public int RoomsNumber { get; set; }
        public int Price { get; set; }
        public int UserID { get; set; }
    }
}