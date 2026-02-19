public class ChecklistGoal: Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted = 0) 
            : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override void RecordEvent(ref int score)
    {
        if (IsComplete())
        {
            Console.WriteLine("This goal is already fully completed.");
            return;
        }

        _amountCompleted++;
        score += _points;
        Console.WriteLine($"Congratulations! You have earned {_points} points!");

        if (_amountCompleted >= _target)
        {
            score += _bonus;
            Console.WriteLine($"*** BONUS! You reached your target and earned an extra {_bonus} points! ***");
        }
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}