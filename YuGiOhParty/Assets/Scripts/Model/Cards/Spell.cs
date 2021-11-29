using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Card/Spell",fileName ="New Spell")]
public class Spell : Card
{
    [Header("Spell details")]
    [SerializeField] private SpellType _spellType;
    public SpellType SpellType { get => _spellType; set => _spellType = value; }
}
