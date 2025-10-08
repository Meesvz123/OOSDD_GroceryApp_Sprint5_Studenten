using CommunityToolkit.Mvvm.ComponentModel;

namespace Grocery.App.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        string title = "";

        public virtual void Load(int id) { }
        public virtual void OnAppearing() { }
        public virtual void OnDisappearing() { }
    }
}
