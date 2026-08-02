using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardEffection : MonoBehaviour
{

    public double MyAttack = 10;
    public double MyDefend = 10;
    public int MaxMana = 3;
    public int Mana = 0;
    public Text maxmana;
    public Text mana;

    public static CardEffection Instance;
    private void Awake()
    {
        Instance = this;
        Mana = MaxMana;
    }

    public void ActivateEffect(int id)
    {
        if (Mana > 0)
        {
            switch (id)
            {
                case 1:
                    Debug.Log("攻撃力上昇I 発動");
                    MyAttack *= 1.5;
                    Mana -= 1;
                    break;

                case 2:
                    Debug.Log("防御力上昇I 発動");
                    MyDefend *= 1.5;
                    Mana -= 1;
                    break;

                default:
                    Debug.Log("その他のカード効果");
                    break;
            }
        }
    }

    void Update()
    {
        maxmana.text = MaxMana.ToString();
        mana.text = Mana.ToString();
    }

}
