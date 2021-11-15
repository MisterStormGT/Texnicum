using System.ComponentModel.DataAnnotations;

namespace Texnicum.ViewModels.TypesOfTotals
{
    public class CreateTypeOfTotalViewModel
    {
        [Required(ErrorMessage = "Введите название аттестации")]
        [Display(Name = "Название аттестации")]
        public string CertificateName { get; set; }

    }
}