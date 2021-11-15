using System.ComponentModel.DataAnnotations;

namespace Texnicum.ViewModels.TypesOfTotals
{
    public class EditTypeOfTotalViewModel
    {
        public short Id { get; set; }

        [Required(ErrorMessage = "Введите название аттестации")]
        [Display(Name = "Название аттестации")]
        public string CertificateName { get; set; }

        public string IdUser { get; set; }
    }
}