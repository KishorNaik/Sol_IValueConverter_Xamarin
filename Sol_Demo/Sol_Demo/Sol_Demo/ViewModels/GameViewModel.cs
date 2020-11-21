using MvvmHelpers;
using Sol_Demo.Data;
using Sol_Demo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Linq;

namespace Sol_Demo.ViewModels
{
    public class GameViewModel : BaseViewModel
    {
        private readonly IGameData gameData = null;

        public GameViewModel()
        {
            gameData = DependencyService.Get<IGameData>();

            GameAction = new Action(async () =>
            {
                var gameListObj = await gameData?.GetGamesData();

                GameList = new ObservableCollection<GameModel>(gameListObj);
            });
            GameAction();

            //GameList = new ObservableCollection<GameModel>((gameData.GetGamesData().Result).ToList());
        }

        private ObservableCollection<GameModel> gameList;

        public ObservableCollection<GameModel> GameList
        {
            get => gameList;
            set => base.SetProperty(ref gameList, value);
        }

        private Action GameAction { get; set; }
    }
}