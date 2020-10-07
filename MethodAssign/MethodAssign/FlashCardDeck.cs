using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssign
{
    public class MethodOne
    {
        public MethodOne()
        {
            FlashCards = new List<FlashCard>();
            List<int> ValuesOne = new List<int>() 
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> ValuesTwo = new List<int>()
            { 1, 2, 3, 4, 5, 6, 7, 8, 9} ;
        
            foreach (int valueone in ValuesOne)
            {
                foreach (int valuetwo in ValuesTwo)
                {
                    FlashCard flashcard = new FlashCard();
                    flashcard.ValueOne = valueone;
                    flashcard.ValueTwo = valuetwo;
                    FlashCards.Add(flashcard);
                }
            }
        }
        public List<FlashCard> FlashCards { get; set; }
    }
}
