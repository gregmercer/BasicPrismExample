using System;

using Prism.Mvvm;
using Prism.Navigation;

namespace GSBgo.ViewModels
{
	public class ViewModelBase : BindableBase, INavigationAware
	{
		public ViewModelBase()
		{

		}

		public virtual void OnNavigatedFrom(NavigationParameters parameters)
		{

		}

		public virtual void OnNavigatedTo(NavigationParameters parameters)
		{

		}

		public virtual void OnNavigatingTo(NavigationParameters parameters)
		{

		}
	}
}
