using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Texnicum.Models.Data
{
    public class Specialty
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ИД")]
        public short Id { get; set; }

        [Required(ErrorMessage = "Введите индекс специальности")]
        [Display(Name = "Индекс")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Введите название специальности")]
        [Display(Name = "Специальность")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Форма обучения")]
        public short IdFormOfStudy { get; set; }

        [Display(Name = "Форма обучения")]
        [ForeignKey("IdFormOfStudy")]
        public FormOfStudy FormOfStudy { get; set; }

        public ICollection<Group> Groups { get; set; }
    }
}