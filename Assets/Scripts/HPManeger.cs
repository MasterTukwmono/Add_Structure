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

    int EnemyHP = 1000;

    void Start()
    {
        currentMyHP = MyHPMax;
        MyHpBer.maxValue = MyHPMax;
        MyHpBer.value = currentMyHP;
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

}