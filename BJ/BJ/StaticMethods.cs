﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ
{
    class StaticMethods
    {/// <summary>
    /// Changes returns a type depended on int y
    /// </summary>
    /// <param name="y"></param>
    /// <returns></returns>
        public static string ReturnType(int y)
        {
            string Ytype = "";

            if (y == 0) { Ytype = "Heart"; }
            if (y == 1) { Ytype = "Dimond"; }
            if (y == 2) { Ytype = "Spade"; }
            if (y == 3) { Ytype = "Clobe"; }

            return Ytype;
        }
        /// <summary>
        /// Counts all cards value and return total value
        /// </summary>
        /// <param name="CardList"></param>
        /// <returns></returns>
        public static int CountValue(List<Card> CardList)
        {
            int totalValue = 0;
            foreach (var item in CardList)
            {
                
                totalValue += item._Value;
                //if ( item.Type == "Ace") { item._AceValue = 10 + totalValue; }
           
            }
            return totalValue;
        }
        /// <summary>
        /// Counts all cards value and return total Acevalue
        /// </summary>
        /// <param name="CardList"></param>
        /// <returns></returns>
        public static int CountAceValue(List<Card> CardList)
        {
            int totalValue = 0;
            foreach (var item in CardList)
            {

                totalValue += item._AceValue;
                //if ( item.Type == "Ace") { item._AceValue = 10 + totalValue; }

            }
            return totalValue;
        }
        /// <summary>
        /// Changes returns a type depended on int x
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static string GetType(int x)
        {
            string type = "";
            if (x == 0) { type = "Ace"; }
            if (x == 1) { type = "Two"; }
            if (x == 2) { type = "Three"; }
            if (x == 3) { type = "Four"; }
            if (x == 4) { type = "Five"; }
            if (x == 5) { type = "Six"; }
            if (x == 6) { type = "Seven"; }
            if (x == 7) { type = "Eight"; }
            if (x == 8) { type = "Nine"; }
            if (x == 9) { type = "Ten"; }
            if (x == 10) { type = "Knight"; }
            if (x == 11) { type = "Queen"; }
            if (x == 12) { type = "King"; }
            return type;
        }
        
    }
}
