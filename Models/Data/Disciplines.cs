using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Texnicum.Models.Data
{
    public class Disciplines
    {
        // Key - поле первичный ключ
        // DatabaseGenerated(DatabaseGeneratedOption.Identity) - поле автоинкреметное
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ИД")]
        public short Id { get; set; }

        [Display(Name = "Индекс проф модуля")]
        public string IndexProfModule { get; set; }

        [Display(Name = "Название")]
        public string ProfModule { get; set; }

        [Display(Name = "Индекс")]
        public string Index { get; set; }

        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Display(Name = "Краткое имя")]
        public string ShortName { get; set; }

        [Required]
        [Display(Name = "ИД пользователя")]
        public string IdUser { get; set; }

        [ForeignKey("IdUser")]
        [Display(Name = "Пользователь")]
        public User User { get; set; }
    }
}