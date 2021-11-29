using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CardSet : ScriptableObject
{
    [Header("Set details")]
    [SerializeField] private string _name;
    [SerializeField] private Sprite _boosterSprite;

    [Header("Set Cards & Rarity")]
    [SerializeField] private List<List<Card>> _cardPool;

    public List<List<Card>> CardPool { get => _cardPool;  }
    public string Name { get => _name; set => _name = value; }
    public Sprite BoosterSprite { get => _boosterSprite;}
}
