using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Card/Monster/XYZ Monster",fileName ="New XYZ Monster")]
public class XYZMonster : Monster
{
    [Header("XYZ Rank")] 
    [SerializeField] private int _rank;

    public int Rank { get => _rank;  }
}
