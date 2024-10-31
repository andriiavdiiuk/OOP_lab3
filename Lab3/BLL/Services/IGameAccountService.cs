using Lab3.BLL.GameAccounts;
using Lab3.BLL.Games;
using Lab3.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.BLL.Services
{
    public interface IGameAccountService
    {
        int Create(BaseGameAccount game);
        BaseGameAccount Get(int id);
        IEnumerable<BaseGameAccount> GetAll();
        void Update(BaseGameAccount game);
        void Delete(int id);
        IEnumerable<GameResult> GetHistory(int Id);
    }
}
