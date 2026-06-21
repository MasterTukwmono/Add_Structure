using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    [SerializeField] GameObject carPrehad;
    [SerializeField] Transform PlayerHand;

    void Start()
    {
        for (int i = 0; i < 5; i++)
            Instantiate(carPrehad, PlayerHand);
    }


}
