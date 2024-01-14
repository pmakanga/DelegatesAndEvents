using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    internal class Player
    {
        public int Points { get; private set; }

        public delegate void AchievementUnlockedHandler(int points);

      //  public event Action? AchievementUnlocked;
        public event AchievementUnlockedHandler? AchievementUnlocked;

        public async Task AddPoints(int points)
        {
            Points += points;
            Console.WriteLine($"Player earned {points}. Total points: {Points}");
            await Task.Delay( 1000 );
            if( Points > 100 ) 
            {
                AchievementUnlocked?.Invoke(Points);
            }
        }
    }
}
