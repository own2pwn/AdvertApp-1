using System.ComponentModel.DataAnnotations.Schema;

namespace AdvertApp.Models
{
    public class BaseEntity
    {
        #region Property ID
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