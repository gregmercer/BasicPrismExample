using System;
using System.Collections.Generic;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace GSBgo.Views
{
    public partial class HomePage : TabbedPage, INavigatingAware
    {
        IContainer _container { get; }

        public HomePage(IContainer container)
        {
            InitializeComponent();
            _container = container;
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
			AddChild("RoomsPage", parameters);
        }

		private void AddChild(string name, NavigationParameters parameters)
		{
			var page = _container.Resolve<object>(name) as Page;
			if (ViewModelLocator.GetAutowireViewModel(page) == null)
				ViewModelLocator.SetAutowireViewModel(page, true);

			(page as INavigatingAware)?.OnNavigatingTo(parameters);
			(page?.BindingContext as INavigatingAware)?.OnNavigatingTo(parameters);

			Children.Add(page);
		}
    }
}
