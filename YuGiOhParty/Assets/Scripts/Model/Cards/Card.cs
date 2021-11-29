using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card : ScriptableObject
{
    [Header("Card description")]
    [SerializeField] private string _name;
    [SerializeField] [TextArea] private string _description;
    [Header("Card details")]
    [SerializeField] private int _speed;
    [SerializeField] private double id;
    [SerializeField] private Sprite _sprite;
    [Header("Card effect")]
    [SerializeField] private CardEffect _effect;

    public string Name { get => _name; set => _name = value; }
    public string Description { get => _description; set => _description = value; }
    public int Speed { get => _speed; set => _speed = value; }
    public double Id { get => id; set => id = value; }
    public Sprite Sprite { get => _sprite; set => _sprite = value; }
    public CardEffect Effect { get => _effect; set => _effect = value; }
}
