using Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.DataBaseModels
{
    [Table("Equipment")]
    public class Equipment : BaseEntity
    {
        public string Name { get; set; }
    }
}
