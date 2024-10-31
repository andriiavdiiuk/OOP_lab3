using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.DAL.Models;

namespace Lab3.DAL.Repositories
{
    public interface IGameAccountRepository
    {
        int Create(GameAccountModel account);
        IEnumerable<GameAccountModel> GetAll();
        GameAccountModel Read(int id);
        void Update(GameAccountModel account);
        void Delete(int id);
    }
}
