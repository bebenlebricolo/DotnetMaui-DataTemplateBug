using System.Collections.ObjectModel;

namespace DataTemplateBug;
using CommunityToolkit.Mvvm.ComponentModel;

public partial class CustomViewModel: ObservableObject
{
    [ObservableProperty] private ObservableCollection<string> _data;
    
    public CustomViewModel()
    {
        _data = new ObservableCollection<string>()
        {
            "test 1",
            "test_2",
            "test_3",
            "test_4",
            "test_5",
            "test_6",
            "test_7"
        };
    }

}