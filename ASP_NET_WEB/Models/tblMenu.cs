using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_NET_WEB.Models
{
    [Table("tblMenu")]
    public class tblMenu
    {
        [Key]
        public int MenuID { get; set; }
        
        public string? MenuName { get; set; }
        public string? IsActive { get; set; }
        public string? ControllerName { get; set; }
        public string? ActionName { get; set; }
        public int Levels { get; set; }
        public int ParentID { get; set; }
        public string? Link { get; set; }
        public int MenuOrder { get; set; }
        public int Position { get; set; }
    }
}