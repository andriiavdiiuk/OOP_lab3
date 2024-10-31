﻿using Lab3.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.BLL.GameAccounts
{
    public class HalfLossPointsAccount : BaseGameAccount
    {
        public HalfLossPointsAccount(IGameAccountService _service, string username) : base(_service, username)
        {
        }

        public override int CalculateWinRating(int rating)
        {
            if (rating < 0)
            {
                throw new ArgumentException("Rating cannot be negative.", nameof(rating));
            }
            return rating;
        }

        public override int CalculateLoseRating(int rating)
        {
            if (rating < 0)
            {
                throw new ArgumentException("Rating cannot be negative.", nameof(rating));
            }
            return rating / 2;
        }

    }
}