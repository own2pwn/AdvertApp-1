using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class BaseEntity
    {
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