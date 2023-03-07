using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Pack
    {
        List<Card> pack;

        public Pack()
        {
            //Initialise the card pack here
            pack = new List<Card>();
        }
        public static bool ShuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            return true;
        }

        public static List<Card> GetPack()
        {
            return pack;
        }

        public static Card Deal(List<Card> pack)
        {
            //Deals one card
            if (pack.Count > 0)
            {
                Card card = pack[0];
                pack.RemoveAt(0);
                return card;
            }
            return null;
        }
        public static List<Card> DealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            List<Card> cards = new List<Card>();
            for (int i = 0; i < amount; i++)
            {
                if (pack.Count > 0)
                {
                    Card card = pack[0];
                    pack.RemoveAt(0);
                    cards.Add
