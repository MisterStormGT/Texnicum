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

        [Required(ErrorMessage = "Введите индекс профессионального модуля")]
        [Display(Name = "Индекс профессионального модуля")]
        public string IndexProfModule { get; set; }

        [Required(ErrorMessage = "Введите название профессионального модуля")]
        [Display(Name = "Название профессионального модуль")]
        public string ProfModule { get; set; }

        [Display(Name = "Индекс")]
        public string Index { get; set; }

        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Display(Name = "Краткое имя")]
        public string ShortName { get; set; }

        // так как у каждого пользователя (преподавателя) свой список форм обучения, то нужно указывать внешний ключ
        [Required]
        public string IdUser { get; set; }

        // Навигационные свойства
        // свойство нужно для более правильного отображения данных в представлениях
        [ForeignKey("IdUser")]
        public User User { get; set; }
    }
}