using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card : ScriptableObject
{
    [Header("Card description")]
    [SerializeField] private string _name;
    [SerializeField] [TextArea] private string _description;
    [Header("Card details")]
    [SerializeField]  private double id;
    [SerializeField] private Sprite _sprite;
    [Header("Card effect")]
    [SerializeField] private CardEffect _effect;

    public string Name { get => _name; }
    public string Description { get => _description; }
    public double Id { get => id; }
    public Sprite Sprite { get => _sprite;}
    public CardEffect Effect { get => _effect;}
}
