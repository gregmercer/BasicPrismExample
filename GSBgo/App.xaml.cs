using Xamarin.Forms;

using Microsoft.Practices.Unity;
using Prism.Unity;

using GSBgo.Views;
using GSBgo.Services;

namespace GSBgo
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer = null) : base(initializer) { }

		protected override void OnInitialized()
		{
			InitializeComponent();
            NavigationService.NavigateAsync("NavigationPage/RoomsPage");
		}

		protected override void RegisterTypes()
		{
			Container.RegisterType<IRecipeService, RecipeService>(new ContainerControlledLifetimeManager());

			Container.RegisterTypeForNavigation<NavigationPage>();
			Container.RegisterTypeForNavigation<MainPage>();
			Container.RegisterTypeForNavigation<RoomsPage>();
		}
	}
}
