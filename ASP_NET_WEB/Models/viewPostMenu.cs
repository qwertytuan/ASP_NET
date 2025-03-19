using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_NET_WEB.Models
{
    [Table("viewPostMenu")]
    public class viewPostMenu
    {
        [Key]
        public long PostID { get; set; }
        
        public string? Title { get; set; }
        public string? Abstract { get; set; }
        public string? Contents { get; set; }
        public string? Images { get; set; }
        public string? Link { get; set; }
        public string? Author { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int IsActive { get; set; }
        public int PostOrder { get; set; }
        public int MenuID { get; set; }
        public string? MenuName { get; set; }
        
    }
}