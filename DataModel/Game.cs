﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Game
    {
        public List<Deck> Decks { get; set; }
        public User Winner { get; set; }
        //public List<User> Players { get; set; }
        public bool IsStop { get; set; }

        public Game()
        {
            for (int i = 0; i < 6; i++)
            {
                Deck deck = new Deck();
                deck.CreateDeck();
                this.Decks.Add(deck);
                foreach (Deck d in Decks)
                {
                    d.ShuffleList();
                }
                this.Decks[2].AddCutCard(); // add cut card between 50% and 80% of game Cards
            }

            //foreach(User p in players)
            //{
            //    this.Players.Add(p);
            //}

            this.IsStop = false;
        }
    } 
}
