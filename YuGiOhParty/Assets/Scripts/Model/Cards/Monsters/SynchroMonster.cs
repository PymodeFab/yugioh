using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Card/Monster/Synchro Monster")]
public class SynchroMonster : Monster,ILevel
{

    [Header("Monster LVL")]
    [SerializeField] [Range(2,12)] private int _lvl;

    public int Lvl { set => _lvl = value; }

    public int GetLevel()
    {
        return _lvl;
    }
}
