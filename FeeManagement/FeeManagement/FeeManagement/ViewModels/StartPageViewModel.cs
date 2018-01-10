using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using FeeManagement.Infrastructure;
using FeeManagement.Models;
using FeeManagement.Views;
using Xamarin.Forms;

namespace FeeManagement.ViewModels
{
    public class StartPageViewModel : ViewModelBase
    {

        private ObservableCollection<MenuModel> menuList;
        public ObservableCollection<MenuModel> MenuList
        {
            get
            {
                return menuList;
            }
            set
            {
                SetProperty(ref menuList, value, "MenuList");
            }
        }



        private MenuModel selectedMenuItem;
        public MenuModel SelectedMenuItem
        {
            get
            {
                return selectedMenuItem;
            }
            set
            {
                SetProperty(ref selectedMenuItem, value, "SelectedMenuItem");
            }
        }

        public ICommand MenuTappedCommand { get; set; }


        private bool isBusy;
        public bool IsBusy
        {
            get
            {
                return isBusy;
            }
            set
            {
                isBusy = value;
                SetProperty(ref isBusy, value,"IsBusy");
            }
        }

        public StartPageViewModel()
        {
            IsBusy = false;
            AddMenu();
            MenuTappedCommand = new Command(() => MenuSelectedAsync());
        }

        public void AddMenu()
        {
            if (MenuList != null)
            {
                MenuList.Clear();
                MenuList = null;
            }
            MenuList = new ObservableCollection<MenuModel>();

            MenuModel model = new MenuModel();
            model.Name = "Fee Management";
            model.Icon = ImageSource.FromFile("rupee.png");


            MenuList.Add(model);


        }

        private void MenuSelectedAsync()
        {
            App.Current.MainPage = new SelectPage();
        }
    }
}
