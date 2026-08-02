using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardEffection : MonoBehaviour
{

    int MyHP = 100;
    double MyAttack = 10;
    double MyDefend = 10;

    public static CardEffection Instance;
    private void Awake()
    {
        Instance = this;
    }

    public void ActivateEffect(int id)
    {
        switch (id)
        {
            case 1:
                Debug.Log("攻撃力上昇I 発動");
                MyAttack *= 1.5;
                break;

            case 2:
                Debug.Log("防御力上昇I 発動");
                MyDefend *= 1.5;
                break;

            default:
                Debug.Log("その他のカード効果");
                break;
        }
    }

}
