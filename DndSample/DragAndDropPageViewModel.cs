using System.Collections.ObjectModel;

namespace DndSample;

public class DragAndDropPageViewModel : IViewModel
{
    
    public DragAndDropPageViewModel()
    {
        ListItems = new() { "test1", "test2", "test3", "test4", "test5"};
    }
    public ObservableCollection<string> ListItems { get; set; }
}