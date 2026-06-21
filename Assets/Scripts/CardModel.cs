using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CardModel : MonoBehaviour
{
    public int cardId;
    public string name;
    public int cost;
    public Sprite icon;

    public CardModel(int cardId)
    {
        CardEntity cardEntity = Resources.Load<CardEntity>("CardEntityList/Card" + cardId);

        cardId = cardEntity.cardId;
        name = cardEntity.name;
        cost = cardEntity.cost;
        icon = cardEntity.icon;
    }
}

