using DelegatesAndEvents;

Player player = new Player();
var party = new Party();

player.AchievementUnlocked += OnAchievementUnlock;
player.AchievementUnlocked += party.Cheering;

await player.AddPoints(30);
await player.AddPoints(40);
await player.AddPoints(35);

static void OnAchievementUnlock(int points)
{
    Console.WriteLine($"Congratulations from program.cs! Achievement unlocked for earning {points} points!");
}
