using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
    private Text nameText;
    private Text costText;
    [SerializeField] GameObject names, cost;
    [SerializeField] Image iconImage;

    void Awake()
    {
        nameText = names.GetComponent<Text>();
        costText = cost.GetComponent<Text>();
    }

    public void Show(CardModel cardModel) // cardModelのデータ取得と反映
    {
        nameText.text = cardModel.name;
        costText.text = cardModel.cost.ToString();
        iconImage.sprite = cardModel.icon;
    }
}
