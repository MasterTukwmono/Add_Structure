using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    [SerializeField] CardContoroller cardPrefab;
    [SerializeField] Transform playerHand;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        CreateCard(1, playerHand);
        CreateCard(2, playerHand);
    }

    void CreateCard(int cardID, Transform place)
    {
        CardContoroller card = Instantiate(cardPrefab, place);
        card.Init(cardID);
    }


}
