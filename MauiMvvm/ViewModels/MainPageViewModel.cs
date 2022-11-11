using MauiMvvm.Models;
using System.Windows.Input;

namespace MauiMvvm.ViewModels;

public class MainPageViewModel : ViewModelBase
{
    private Item? _item;
    public Item? Item
    {
        get => _item;
        set => SetProperty(ref _item, value);
    }

    public ICommand IncrementCommand { get; private set; }
    public ICommand ShowMessageCommand { get; private set; }


    public MainPageViewModel(Item item)
    {
        Item = item;

        IncrementCommand = new Command(() =>
        {
            if (Item != null)
            {
                Item.Count++;
            }
        });

        ShowMessageCommand = new Command(async () =>
        {
            if (Application.Current?.MainPage != null)
            {
                await Application.Current.MainPage.DisplayAlert("Count", Item?.Count.ToString(), "OK");
            }
        });
    }
}
