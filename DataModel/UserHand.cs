﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class UserHand
    {
        public ObservableCollection<Card> Cards { get; set; }
        public int Value { get; set; }
        public Double Bet { get; set; }
        public bool IsFinish { get; set; }

        public UserHand()
        {
            this.Cards = new ObservableCollection<Card>();
            this.Bet = 0;
            this.Value = 0;
            this.IsFinish = false;
        }
        public UserHand(Card card,Double bet)
        {
            this.Cards = new ObservableCollection<Card>();
            this.Cards.Add(card);
            this.Bet = bet;
            this.Value = 0;
            this.IsFinish = false;
        }
    }
}
