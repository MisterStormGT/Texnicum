namespace Texnicum.ViewModels.Disciplines
{
    public class SortDisciplineViewModel
    {
        public DisciplineSortState IndexProfModuleSort { get; private set; }
        public DisciplineSortState ProfModuleSort { get; private set; }
        public DisciplineSortState IndexSort { get; private set; }
        public DisciplineSortState NameSort { get; private set; }
        public DisciplineSortState ShortNameSort { get; private set; }
        public DisciplineSortState Current { get; private set; }     // текущее значение сортировки

        public SortDisciplineViewModel(DisciplineSortState sortOrder)
        {
            IndexProfModuleSort = sortOrder == DisciplineSortState.IndexProfModuleAsc ?
                DisciplineSortState.IndexProfModuleDesc : DisciplineSortState.IndexProfModuleAsc;

            ProfModuleSort = sortOrder == DisciplineSortState.ProfModuleAsc ?
                DisciplineSortState.ProfModuleDesc : DisciplineSortState.ProfModuleAsc;

            IndexSort = sortOrder == DisciplineSortState.IndexAsc ?
                DisciplineSortState.IndexDesc : DisciplineSortState.IndexAsc;

            NameSort = sortOrder == DisciplineSortState.NameAsc ?
                DisciplineSortState.NameDesc : DisciplineSortState.NameAsc;

            ShortNameSort = sortOrder == DisciplineSortState.ShortNameAsc ?
                DisciplineSortState.ShortNameDesc : DisciplineSortState.ShortNameAsc;

            Current = sortOrder;
        }
    }
}