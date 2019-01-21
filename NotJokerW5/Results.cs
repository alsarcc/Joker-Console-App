using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotJokerW5
{
    class Results
    {
        public List<Player> Players { get; set; } // Create a List to save the players and their contents
        public Lottery Lottery { get; set; } // Create an object of type Lottery to save all its contents
        public Categories Categories { get; set; }
        public Statistics Statistics { get; set; }

        public Results()
        {
            Players = new List<Player>();
            Lottery = new Lottery(0);
            Categories = new Categories();
            Statistics = new Statistics();
        }

        //Method that creates Players and Adds them to the List of Players
        public void AddPlayers(int howMany)
        {
            Random r = new Random();

            for (int i = 0; i < howMany; i++)
            {
                Player player = new Player(r); //create a player
                Players.Add(player); //add him to the list of players
                if (Players.Count > 0)
                {
                    player.ID = i + 1;
                }
                Console.WriteLine("\nNumbers for Player{0} are: ", player.ID); //display results
                foreach (int number in player.DrawList)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine("JOKER: " + player.Joker);
            }
        }

        //Method that Prints the Draw of Each Lottery
        public void PrintLottery()
        {
            Console.WriteLine("\nThe budget now is {0}Euros and the drawn numbers of Lottery{1} are:", Lottery.Budget, Lottery.ID);
            foreach (int num in Lottery.DrawList)
            {
                Console.Write(num + " ");

            }
            Console.WriteLine("JOKER: " + Lottery.Joker);
        }

        //Method that finds the similarities of Players and Lottery
        public void FindResults()
        {
            foreach (Player player in Players)
            {
                int Counter = 0;            // Initialize a counter for the comparison of two lists
                bool compareJokers = false; // Initialize a boolean for the comparison of two Jokers
                foreach (int playerNum in player.DrawList)
                {
                    if (Lottery.DrawList.Contains(playerNum))
                    {
                        Counter++;
                    }
                }
                if (Lottery.Joker == player.Joker)
                {
                    compareJokers = true;
                }

                switch (Counter) // Save the possibilities to the according category
                {
                    case 5:
                        if (compareJokers)
                        {
                            Categories.FiveAndOne.Add(player.ID);
                            if (Categories.FiveAndOne.Count == 1)
                                Lottery.Budget -= Categories.BudgetFiveAndOne;
                        }
                        else
                        {
                            Categories.Five.Add(player.ID);
                            if (Categories.Five.Count == 1)
                                Lottery.Budget -= Categories.BudgetFive;
                        }
                        break;
                    case 4:
                        if (compareJokers)
                        {
                            Categories.FourAndOne.Add(player.ID);
                            if (Categories.FourAndOne.Count == 1)
                                Lottery.Budget -= Categories.BudgetFourAndOne;

                        }
                        else
                        {
                            Categories.Four.Add(player.ID);
                            if (Categories.Four.Count == 1)
                                Lottery.Budget -= Categories.BudgetFour;

                        }
                        break;
                    case 3:
                        if (compareJokers)
                        {
                            Categories.ThreeAndOne.Add(player.ID);
                            if (Categories.ThreeAndOne.Count == 1)
                                Lottery.Budget -= Categories.BudgetThreeAndOne;

                        }
                        else
                        {
                            Categories.Three.Add(player.ID);
                            if (Categories.Three.Count == 1)
                                Lottery.Budget -= Categories.BudgetThree;
                        }
                        break;
                    case 2:
                        if (compareJokers)
                        {
                            Categories.TwoAndOne.Add(player.ID);
                            if (Categories.TwoAndOne.Count == 1)
                                Lottery.Budget -= Categories.BudgetTwoAndOne;
                        }
                        else
                        {
                            Categories.Two.Add(player.ID);
                            if (Categories.Two.Count == 1)
                                Lottery.Budget -= Categories.BudgetTwo;
                        }
                        break;
                    case 1:
                        if (compareJokers)
                        {
                            Categories.OneAndOne.Add(player.ID);
                            if (Categories.OneAndOne.Count == 1)
                                Lottery.Budget -= Categories.BudgetOneAndOne;
                        }
                        else
                            Categories.OneAndZero.Add(player.ID);
                        break;
                    default:
                        Categories.Zero.Add(player.ID);
                        break;
                }

            }
            Lottery.RemainingBudget = Lottery.Budget;
        }

        //Method that prints the Results
        public void PrintResults()
        {
            Console.WriteLine("\n{0} Players got 5 + 1 and this category has now got {1}Euros", Categories.FiveAndOne.Count, Categories.BudgetFiveAndOne);
            foreach (var id in Categories.FiveAndOne)
            {
                Player.MoneyEarned = Categories.BudgetFiveAndOne / Categories.FiveAndOne.Count;
                Console.WriteLine("Player {0} won {1}", id, Player.MoneyEarned);
            }

            Console.WriteLine("{0} Players got 5 and this category has now got {1}Euros", Categories.Five.Count, Categories.BudgetFive);
            foreach (var id in Categories.Five)
            {
                Player.MoneyEarned = Categories.BudgetFive / Categories.Five.Count;
                Console.WriteLine("Player {0} won {1}", id, Player.MoneyEarned);
            }

            Console.WriteLine("{0} Players got 4 + 1 and this category has now got {1}Euros", Categories.FourAndOne.Count, Categories.BudgetFourAndOne);
            foreach (var id in Categories.FourAndOne)
            {
                Player.MoneyEarned = Categories.BudgetFourAndOne / Categories.FourAndOne.Count;
                Console.WriteLine("Player {0} won {1}", id, Player.MoneyEarned);
            }

            Console.WriteLine("{0} Players got 4 and this category has now got {1}Euros", Categories.Four.Count, Categories.BudgetFour);
            foreach (var id in Categories.Four)
            {
                Player.MoneyEarned = Categories.BudgetFour / Categories.Four.Count;
                Console.WriteLine("Player {0} won {1}", id, Player.MoneyEarned);
            }

            Console.WriteLine("{0} Players got 3 + 1 and this category has now got {1}Euros", Categories.ThreeAndOne.Count, Categories.BudgetThreeAndOne);
            foreach (var id in Categories.ThreeAndOne)
            {
                Player.MoneyEarned = Categories.BudgetThreeAndOne / Categories.ThreeAndOne.Count;
                Console.WriteLine("Player {0} won {1}", id, Player.MoneyEarned);
            }

            Console.WriteLine("{0} Players got 3 and this category has now got {1}Euros", Categories.Three.Count, Categories.BudgetThree);
            foreach (var id in Categories.Three)
            {
                Player.MoneyEarned = Categories.BudgetThree / Categories.Three.Count;
                Console.WriteLine("Player {0} won {1}", id, Player.MoneyEarned);
            }

            Console.WriteLine("{0} Players got 2 + 1 and this category has now got {1}Euros", Categories.TwoAndOne.Count, Categories.BudgetTwoAndOne);
            foreach (var id in Categories.TwoAndOne)
            {
                Player.MoneyEarned = Categories.BudgetTwoAndOne / Categories.TwoAndOne.Count;
                Console.WriteLine("Player {0} won {1}", id, Player.MoneyEarned);
            }

            Console.WriteLine("{0} Players got 2 and this category has now got {1}Euros", Categories.Two.Count, Categories.BudgetTwo);
            foreach (var id in Categories.Two)
            {
                Player.MoneyEarned = Categories.BudgetTwo / Categories.Two.Count;
                Console.WriteLine("Player {0} won {1}", id, Player.MoneyEarned);
            }

            Console.WriteLine("{0} Players got 1 + 1 and this category has now got {1}Euros", Categories.OneAndOne.Count, Categories.BudgetOneAndOne);
            foreach (var id in Categories.OneAndOne)
            {
                Player.MoneyEarned = Categories.BudgetOneAndOne / Categories.OneAndOne.Count;
                Console.WriteLine("Player {0} won {1}", id, Player.MoneyEarned);
            }

            Console.WriteLine("{0} Players got 1 + 0 and the Players in this category won nothing", Categories.OneAndZero.Count);
            foreach (var id in Categories.OneAndZero)
            {
                Console.WriteLine("Player " + id);
            }

            Console.WriteLine("{0} Players got 0 and the Players in this category won nothing", Categories.Zero.Count);
            foreach (var id in Categories.Zero)
            {
                Console.WriteLine("Player " + id);
            }

            Console.WriteLine("\nRemaining budget after Lottery{0} is: {1}", Lottery.ID, Lottery.RemainingBudget);
        }

        // THIS IS STAGE 3
        //Method that creates many lotteries
        public void ManyLotteries(int howMany)
        {
            for (int i = 0; i < howMany; i++)
            {
                Lottery = new Lottery(Lottery.RemainingBudget); //adds the remaining budget from the previous lottery
                Lottery.ID = i + 1;
                foreach (int number in Lottery.DrawList)
                {
                    Statistics.AllLotteryNumbers.Add(number); //saves all the numbers from ALL lotteries to a new list
                }
                PrintLottery();
                Categories = new Categories();
                FindResults();
                PrintResults();
            }
        }

    }
}
