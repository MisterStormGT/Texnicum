using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Texnicum.Models.Data
{
    public class TypesOfTotals
    {
        // Key - поле первичный ключ
        // DatabaseGenerated(DatabaseGeneratedOption.Identity) - поле автоинкреметное
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ИД")]
        public short Id { get; set; }

        [Required(ErrorMessage = "Введите название аттестации")]
        [Display(Name = "Название аттестации")]
        public string CertificateName { get; set; }

        [Required]
        public string IdUser { get; set; }

        [ForeignKey("IdUser")]
        [Display(Name = "Пользователь")]
        public User User { get; set; }
    }
}