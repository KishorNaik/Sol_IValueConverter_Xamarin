using Sol_Demo.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Sol_Demo.Data
{
    public interface IGameData
    {
        Task<IReadOnlyList<GameModel>> GetGamesData();
    }

    public class GameData : IGameData
    {
        Task<IReadOnlyList<GameModel>> IGameData.GetGamesData()
        {
            return Task.Run<IReadOnlyList<GameModel>>(() =>
            {
                var gameListModel = new List<GameModel>();
                gameListModel.Add(new GameModel() { Name = "Mario", Platform = "Sony" });
                gameListModel.Add(new GameModel() { Name = "Pubg", Platform = "Android" });
                gameListModel.Add(new GameModel() { Name = "Master Chiefs", Platform = "XBox" });

                return gameListModel.AsReadOnly();
            }
            );
        }
    }
}