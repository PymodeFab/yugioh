using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Card/Trap",fileName ="New Trap")]
public class Trap : Card
{
    [Header("Trap details")]
    [SerializeField] private TrapType _trapType;

    public TrapType TrapType { get => _trapType;  }
}
