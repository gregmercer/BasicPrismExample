using System;
using System.Collections.ObjectModel;

using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

using GSBgo.Business;
using GSBgo.Services;
using System.Threading.Tasks;

namespace GSBgo.ViewModels
{
public class MainPageViewModel : ViewModelBase
	{
		INavigationService _navigationService { get; }
		IRecipeService _recipeService;

		public MainPageViewModel(INavigationService navigationService, IRecipeService recipeService)
		{
			_navigationService = navigationService;
			_recipeService = recipeService;
		}

		private string _title;
		public string Title
		{
			get { return _title; }
			set { SetProperty(ref _title, value); }
		}

		private ObservableCollection<RecipeGroup> _recipeGroups;
		public ObservableCollection<RecipeGroup> RecipeGroups
		{
			get { return _recipeGroups; }
			set { SetProperty(ref _recipeGroups, value); }
		}

		public override async void OnNavigatedTo(NavigationParameters parameters)
		{
			if (RecipeGroups == null)
			{
				RecipeGroups = new ObservableCollection<RecipeGroup>(await _recipeService.GetRecipeGroups());
			}
		}
    }
}
