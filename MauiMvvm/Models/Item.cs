using MauiMvvm.ViewModels;

namespace MauiMvvm.Models;

public class Item : ViewModelBase
{
    private int _count;
    public int Count
    {
        get => _count;
        set => SetProperty(ref _count, value);
    }
}
