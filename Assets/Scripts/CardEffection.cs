using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardEffection : MonoBehaviour
{

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
                // PlayerStatus.Instance.Attack += 1;
                break;

            case 2:
                Debug.Log("防御力上昇I 発動");
                // PlayerStatus.Instance.Defense += 1;
                break;

            default:
                Debug.Log("その他のカード効果");
                break;
        }
    }

}
