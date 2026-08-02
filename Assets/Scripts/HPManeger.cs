using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HPManeger : MonoBehaviour
{

    private int MyHPMax = 100;
    public int currentMyHP;
    public Slider MyHpBer;

    private int EnemyHPMax = 1000;
    public int currentEnemyHP;
    public Slider EnemyHPBer;


    void Start()
    {
        currentMyHP = MyHPMax;
        MyHpBer.maxValue = MyHPMax;
        MyHpBer.value = currentMyHP;

        currentEnemyHP = EnemyHPMax;
        EnemyHPBer.maxValue = EnemyHPMax;
        EnemyHPBer.value = currentEnemyHP;
    }

    public void TakeDamage(int damage)
    {
        currentMyHP -= damage;

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

    public void AttackDamage(int Attack)
    {
        currentEnemyHP -= Attack;

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