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
        CardContoroller card = Instantiate(cardPrefab, playerHand);
        card.Init(1);
        card.Init(2);
    }


}
