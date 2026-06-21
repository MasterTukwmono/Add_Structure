using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    [SerializeField] CardContoroll cardPrefab;
    [SerializeField] Transform PlayerHand;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        CardContoroll card = Instantiate(cardPrefab, PlayerHand);
        card.Init(1);
    }


}
