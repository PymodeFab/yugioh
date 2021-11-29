using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Card/Monster/Ritual Monster")]
public class RitualMonster : Monster,ILevel
{

    [Header("Monster LVL")]
    [SerializeField] [Range(1, 12)] private int _lvl;

    public int Lvl { set => _lvl = value; }

    public int GetLevel()
    {
        return _lvl;
    }
}
