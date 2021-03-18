using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Cards")]
public class Card : ScriptableObject
{

    public new string name;
    public string description;
    
    public Sprite artwork;

    public Elements elementType;
}
