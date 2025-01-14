﻿using Lab3.BLL.Games;
using Lab3.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.BLL.Services
{
    public interface IGameService
    {
        void Create(GameResult game);
        GameResult Get(int id);
        IEnumerable<GameResult> GetAll();
        void Update(GameResult game);
        void Delete(int id);
    }
}
