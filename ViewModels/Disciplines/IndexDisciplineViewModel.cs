using Texnicum.Models.Data;
using System.Collections.Generic;

namespace Texnicum.ViewModels.Disciplines
{
    public class IndexDisciplineViewModel
    {
        public IEnumerable<Discipline> Disciplines { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public FilterDisciplineViewModel FilterDisciplineViewModel { get; set; }
        public SortDisciplineViewModel SortDisciplineViewModel { get; set; }
    }
}