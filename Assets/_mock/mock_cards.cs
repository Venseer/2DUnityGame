using System;
public static class MockCards
{
    
    public static Card Dash = new Card {Name="Dash", Power = 0, hasPower = false, MaxRange = 0, hasRange = false, Speed = 9,
    Abilities = "<b>After Activating:</b> Free Move up to 3 spaces in one direction. If you moved past your opponent, he can not hit you this round."};
    public static Card Drive = new Card {Name="Drive", Power = 3, MaxRange = 1, Speed = 4,
    Abilities = "<b>Before Activating:</b> Dash forward one or two spaces"};
    public static Card Grasp = new Card {Name="Grasp", Power = 2, MaxRange = 1, Speed = 5,
    Abilities = "<b>On Hit:</b> Move your opponent one space."};
    public static Card Strike = new Card {Name="Strike", Power = 4, MaxRange = 1, Speed = 3,
    Abilities = "<b>Stun Resistence 5</b>"};
    public static Card Shot = new Card {Name="Shot", Power = 3, MaxRange = 4, MinRange = 1, hasMinMaxRange = true, Speed = 2,
    Abilities = "<b>Stun Resistence 2</b>"};
    public static Card Burst = new Card {Name="Burst", Power = 3, MaxRange = 3, MinRange = 2, hasMinMaxRange = true, Speed = 1,
    Abilities = "<b>Start of Round:</b> Dash Backwards one or two spaces"};

    public static Card[] Cards = {Dash, Drive, Grasp, Strike, Shot, Burst};

}

public class Card
{
    public string Name;
    public int Power;
    public bool hasPower = true;
    public int MaxRange;
    public int MinRange;
    public bool hasRange = true;
    public bool hasMinMaxRange;
    public int Speed;
    public bool hasSpeed = true;
    public string Abilities;

}