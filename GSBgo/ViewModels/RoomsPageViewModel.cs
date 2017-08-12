using Prism.Mvvm;
using Prism.Navigation;

using GSBgo.Business;
using GSBgo.Services;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace GSBgo.ViewModels
{
	public class RoomsPageViewModel : ViewModelBase
	{
		INavigationService _navigationService { get; }

		public RoomsPageViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;
		}

        private ObservableCollection<Room> _roomsList;
		public ObservableCollection<Room> RoomsList
		{
			get { return _roomsList; }
			set { SetProperty(ref _roomsList, value); }
		}

		public override async void OnNavigatedTo(NavigationParameters parameters)
		{
            if (RoomsList == null)
            {
                ObservableCollection<Room> rooms = new ObservableCollection<Room>();

                rooms.Add(new Room { Name = "N203" });
                rooms.Add(new Room { Name = "N205" });
                rooms.Add(new Room { Name = "N215" });

                RoomsList = rooms;
			}
		}
	}
}
