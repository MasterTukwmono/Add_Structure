using System.Collections;
using System.Collections.Generic;
using UnityEditor.Scripting;
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

    public bool Helmet = false;
    public bool chest = false;
    public bool leg = false;
    public bool boots = false;
    public bool rightHand = false;
    public bool leftHand = false;

    public static CardEffection Instance;
    private void Awake()
    {
        Instance = this;
        Mana = MaxMana;
    }

    public bool ActivateEffect(int id, int cost)
    {
        // マナが足りない
        if (Mana < cost)
        {
            Debug.Log("マナが足りません");
            return false;
        }

        // カード効果
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

            case 3:
                Debug.Log("攻撃力上昇Ⅱ 発動");
                MyAttack *= 3.0;
                break;

            case 4:
                Debug.Log("防御力上昇Ⅱ 発動");
                MyDefend *= 3.0;
                break;

            case 5:
                Debug.Log("装備:カリバーン");
                rightHand = true;
                break;

            default:
                Debug.Log("存在しないカードID");
                return false;
        }

        // 効果発動に成功したらマナを消費
        Mana -= cost;

        Debug.Log("消費マナ：" + cost);
        Debug.Log("残りマナ：" + Mana);

        return true;
    }

    void Update()
    {
        maxmana.text = MaxMana.ToString();
        mana.text = Mana.ToString();

        if (Mana <= 0)
        {
            Mana = 0;
        }
    }
}
