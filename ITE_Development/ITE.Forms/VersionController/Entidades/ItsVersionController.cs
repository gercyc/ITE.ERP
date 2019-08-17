using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Forms.VersionController.Entidades
{
    [Table("ITS_VERSION_CONTROL")]
    public class ItsVersionControl
    {
        public ItsVersionControl()
        {

        }

        public ItsVersionControl(string name, string version, string fullName)
        {
            this.ClassName = name;
            this.Version = version;
            this.FullName = fullName;
        }

        
        
        [Display(Name = "Classe")]
        [StringLength(100, MinimumLength = 0)]
        public string ClassName { get; set; }
        
        [Display(Name = "Versão")]
        [StringLength(20, MinimumLength = 0)]
        public string Version { get; set; }

        [Key]
        [Display(Name = "Nome completo")]
        [StringLength(1000, MinimumLength = 0)]
        public string FullName { get; set; }

    }
}
