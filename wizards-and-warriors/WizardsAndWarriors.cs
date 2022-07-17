using System;

abstract class Character
{
    private string characterType;
    public bool isVulnerable = false;

    protected Character(string characterType)
    {
        this.characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => this.isVulnerable;

    public override string ToString() => $"Character is a {this.characterType}";
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target) =>
        target.isVulnerable ? 10 : 6;
}

class Wizard : Character
{
    public bool hasPreparedSpell = false;
    
    public Wizard() : base("Wizard")
    {
        isVulnerable = true;
    }

    public override int DamagePoints(Character target) =>
        hasPreparedSpell ? 12 : 3;

    public void PrepareSpell()
    {
        this.isVulnerable = false;
        this.hasPreparedSpell = true;
    }
}
