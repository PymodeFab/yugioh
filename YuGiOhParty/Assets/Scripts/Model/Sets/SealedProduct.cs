using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SealedProduct : MonoBehaviour
{
    [Header("Sealed Product Details")]
    [SerializeField] private string _name;
    [SerializeField] private string _description;

    [Header("Cards available")]
    [SerializeField] private List<Card> _cardsInProduct;

    public string Name { get => _name; set => _name = value; }
    public string Description { get => _description; set => _description = value; }
    public List<Card> CardsInProduct { get => _cardsInProduct; set => _cardsInProduct = value; }
}
