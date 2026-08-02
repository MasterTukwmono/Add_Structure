using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HPManeger : MonoBehaviour
{
    public GameObject me;
    private CardEffection CardEffections;

    private int MyHPMax = 100;
    public int currentMyHP;
    public Slider MyHpBer;

    private int EnemyHPMax = 1000;
    public int currentEnemyHP;
    public Slider EnemyHPBer;

    public int AttackPoint;
    public int DefencePoint;


    void Awake()
    {
        CardEffections = me.GetComponent<CardEffection>();

        currentMyHP = MyHPMax;
        MyHpBer.maxValue = MyHPMax;
        MyHpBer.value = currentMyHP;

        currentEnemyHP = EnemyHPMax + 10;
        EnemyHPBer.maxValue = EnemyHPMax;
        EnemyHPBer.value = currentEnemyHP;
    }

    public void TakeDamage(int Damage)
    {
        DefencePoint = (int)CardEffections.MyDefend;
        if (DefencePoint < Damage)
        {
            currentMyHP = currentMyHP - Damage + DefencePoint;
        }

        if (currentMyHP < 0)
        {
            currentMyHP = 0;
        }

        MyHpBer.value = currentMyHP;

        if (currentMyHP == 0)
        {
            Debug.Log("Gameover");
        }
    }

    public void AttackDamage()
    {
        AttackPoint = (int)CardEffections.MyAttack;
        currentEnemyHP -= AttackPoint;

        if (currentEnemyHP < 0)
        {
            currentEnemyHP = 0;
        }

        EnemyHPBer.value = currentEnemyHP;

        if (currentEnemyHP == 0)
        {
            Debug.Log("GameClear");
        }
    }

}