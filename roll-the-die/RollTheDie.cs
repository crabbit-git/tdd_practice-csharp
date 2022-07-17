using System;

public class Player
{
    private Random _RNG = new Random();

    public int RollDie() => _RNG.Next(1, 18);

    public double GenerateSpellStrength() => _RNG.NextDouble() * RollDie();
}
