using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Card/Monster/Link Monster")]
public class LinkMonster : Monster
{
    [Header("Link LVL")]
    [SerializeField] private int _linkLVL;

    public int LinkLVL { get => _linkLVL; set => _linkLVL = value; }
}
