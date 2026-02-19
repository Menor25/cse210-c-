/* * 
    * To show creativity, I added a Gamification Rank system inside the 
    * GoalManager.DisplayPlayerInfo() method. As the user's score increases, 
    * their title dynamically changes from "Novice" to "Senior".
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}