using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03._Number_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstCards = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] secondCards = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Queue firstQueue = new Queue();
            foreach (var card in firstCards)
            {
                firstQueue.Enqueue(card);
            }

            Queue secondQueue = new Queue();
            foreach (var card in secondCards)
            {
                secondQueue.Enqueue(card);
            }

            int turns = 0;

            var alphabet = "abcdefghijklmnopqrstuvwxyz";
            int alphabetCounter = 1;
            Dictionary<string, int> alphabetDict = new Dictionary<string, int>();

            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabetDict.Add(alphabet[i].ToString(), alphabetCounter);
                alphabetCounter++;
            }


            while (turns < 1_000_000 && firstQueue.Count > 0 && secondQueue.Count > 0)
            {

                var firstPlayerCard = firstQueue.Dequeue();
                int firstPlayerCardNum = int.Parse(firstPlayerCard.ToString().Substring(0, firstPlayerCard.ToString().Length - 1));
                string firstCardAlhabet = firstPlayerCard.ToString().Substring(firstPlayerCard.ToString().Length - 1);

                var secondPlayerCard = secondQueue.Dequeue();
                int secondPlayerCardNum = int.Parse(secondPlayerCard.ToString().Substring(0, secondPlayerCard.ToString().Length - 1));
                string secondardAlhabet = secondPlayerCard.ToString().Substring(secondPlayerCard.ToString().Length - 1);

                if (firstPlayerCardNum != secondPlayerCardNum)
                {
                    if (firstPlayerCardNum > secondPlayerCardNum)
                    {
                        firstQueue.Enqueue(firstPlayerCard);
                        firstQueue.Enqueue(secondPlayerCard);
                    }
                    else if (secondPlayerCardNum > firstPlayerCardNum)
                    {
                        secondQueue.Enqueue(secondPlayerCard);
                        secondQueue.Enqueue(firstPlayerCard);
                    }
                }
                else if (firstPlayerCardNum == secondPlayerCardNum || firstQueue.Count >= 3 || secondQueue.Count >= 3)
                {
                    int firstSum = 0;
                    List<string> firstCardsOnWar = new List<string>();

                    for (int card = 0; card < 3; card++)
                    {
                        var character = firstQueue.Dequeue();
                        firstSum += alphabetDict[character.ToString().Substring(character.ToString().Length - 1)];
                        firstCardsOnWar.Add(character.ToString());

                    }
                    int secondSum = 0;
                    List<string> secondCardsOnWar = new List<string>();

                    for (int card = 0; card < 3; card++)
                    {
                        var character = secondQueue.Dequeue();
                        secondSum += alphabetDict[character.ToString().Substring(character.ToString().Length - 1)];
                        secondCardsOnWar.Add(character.ToString());
                    }
                    while (firstSum == secondSum && firstQueue.Count >= 3 && secondQueue.Count >= 3)
                    {
                        firstSum = 0;
                        for (int card = 0; card < 3; card++)
                        {
                            var character = firstQueue.Dequeue();
                            firstSum += alphabetDict[character.ToString().Substring(character.ToString().Length - 1)];
                            firstCardsOnWar.Add(character.ToString());

                        }

                        secondSum = 0;
                        for (int card = 0; card < 3; card++)
                        {
                            var character = secondQueue.Dequeue();
                            secondSum += alphabetDict[character.ToString().Substring(character.ToString().Length - 1)];
                            secondCardsOnWar.Add(character.ToString());
                        }
                    }
                    if (firstSum > secondSum)
                    {
                        for (int i = 0; i < secondCardsOnWar.Count; i++)
                        {
                            firstQueue.Enqueue(secondCardsOnWar[i]);
                        }
                        for (int i = 0; i < firstCardsOnWar.Count; i++)
                        {
                            firstQueue.Enqueue(firstCardsOnWar[i]);
                        }

                    }
                    else if (secondSum > firstSum)
                    {
                        for (int i = 0; i < firstCardsOnWar.Count; i++)
                        {
                            secondQueue.Enqueue(firstCardsOnWar[i]);
                        }
                        for (int i = 0; i < secondCardsOnWar.Count; i++)
                        {
                            secondQueue.Enqueue(secondCardsOnWar[i]);
                        }

                    }
                }

                turns++;
            }

            if (firstQueue.Count > secondQueue.Count)
            {
                Console.WriteLine($"First player wins after {turns} turns");
            }
            else if (secondQueue.Count > firstQueue.Count)
            {
                Console.WriteLine($"Second player wins after {turns} turns");
            }
            else if (firstQueue.Count == secondQueue.Count)
            {
                Console.WriteLine($"Draw after {turns} turns");
            }


        }
    }
}
