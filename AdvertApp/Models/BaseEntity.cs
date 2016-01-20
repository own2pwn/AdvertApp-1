using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvertApp.Models
{
    public class BaseEntity
    {
        const string regex = "";
        #region Property ID
        [DataType(DataType.EmailAddress)]
        public int ID { get; set; }
        #endregion

        #region Property IsNew
        [NotMapped]
        public bool IsNew
        {
            get
            {
                if (ID >= 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        #endregion
    }
}