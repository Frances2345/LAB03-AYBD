using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;

public class ActionNode
{
    public List<Color> Colors = new List<Color>() 
    {Color.cyan, Color.red, Color.yellow, Color.blue, Color.orange, Color.green};

    public enum Actions
    {
        Atacar,
        Defender,
        Rebelarse,
        Engañar,
        mover
    }

    public int Quantity = 5;
}


