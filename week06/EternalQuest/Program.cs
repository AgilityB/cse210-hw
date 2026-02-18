// EXCEEDING REQUIREMENTS:
// Added Leveling System based on total score.
// Added ProgressGoal for large measurable goals.
// Added NegativeGoal for tracking bad habits with point penalties.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}