using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Monster : Card
{
    [Header("Monster details")]
    [SerializeField] private MonsterType _monsterType;
    [SerializeField] private MonsterAttribute _monsterAttribute;
    [SerializeField] private SecondaryAttribute _secondaryAttribute;
    [SerializeField] private SecondaryAttribute _thirdAttribute;
    [Header("Monster stats")]
    [SerializeField] [Range(0, 8000)] private double _atk;

    [SerializeField] [Range(0, 8000)] private double _def;


    public MonsterAttribute MonsterAttribute { get => _monsterAttribute; set => _monsterAttribute = value; }
    public MonsterType MonsterType { get => _monsterType; set => _monsterType = value; }
    public SecondaryAttribute SecondaryAttribute { get => _secondaryAttribute; set => _secondaryAttribute = value; }
    public SecondaryAttribute ThirdAttribute { get => _thirdAttribute; set => _thirdAttribute = value; }
    public double Atk { get => _atk; set => _atk = value; }
    public double Def { get => _def; set => _def = value; }
}
