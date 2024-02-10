using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Cards")]
public class CardScriptableObject : ScriptableObject 
{
    public string cardName;
    public string cardAttribute;
    public string cardType;
    public string cardDescription;

    public Sprite artwork;

    public int attack;
    public int defense;
}
  