using Texnicum.Models.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Texnicum.ViewModels.Disciplines
{
    public class FilterDisciplineViewModel
    {
        public string SelectedIndexProfModule { get; private set; }    // введенный индекс
        public string SelectedProfModule { get; private set; }    // введенный проф модуль
        public string SelectedIndex { get; private set; }    // введенный индекс
        public string SelectedName { get; private set; }    // введенное имя
        public string SelectedShortName { get; private set; }    // введенное короткое имя

        public FilterDisciplineViewModel(string IndexProfModule, string ProfModule, string Index, string name, string ShortName)
        {
            SelectedIndexProfModule = IndexProfModule;
            SelectedProfModule = ProfModule;
            SelectedIndex = Index;
            SelectedName = name;
            SelectedShortName = ShortName;
        }
    }
}