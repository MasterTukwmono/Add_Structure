using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardContoroller : MonoBehaviour
{
    public CardView view; // カードの見た目の処理
    private CardModel model; // カードのデータを処理

    private void Awake()
    {
        //view = GetComponent<CardView>();
    }

    public void Init(int cardID) // カードを生成した時に呼ばれる関数
    {
        model = new CardModel(cardID); // カードデータを生成
        view.Show(model); // 表示
    }

    public int GetCardID()
    {
        return model.cardId;
    }
}
