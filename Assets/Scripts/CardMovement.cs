using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardMovement : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public Transform cardParent;

    public void OnBeginDrag(PointerEventData eventData) // ドラッグを始めるときに行う処理
    {
        cardParent = transform.parent;
        transform.SetParent(cardParent.parent, false);
        GetComponent<CanvasGroup>().blocksRaycasts = false; // blocksRaycastsをオフにする
    }

    public void OnDrag(PointerEventData eventData) // ドラッグした時に起こす処理
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData) // カードを離したときに行う処理
    {
        // 親を設定
        transform.SetParent(cardParent, false);

        // Raycast を戻す
        GetComponent<CanvasGroup>().blocksRaycasts = true;

        // 親オブジェクトが存在するかチェック
        Transform parent = transform.parent;
        if (parent == null) return;

        // ① 効果発動したい場所かどうか判定
        if (parent.name == "My_Monster")
        {
            // ② CardController を取得
            CardContoroller controller = GetComponent<CardContoroller>();
            if (controller != null)
            {
                int id = controller.GetCardID();

                // ③ 効果発動スクリプトに渡す
                CardEffection.Instance.ActivateEffect(id);
            }
        }

        // ④ 最後にカードを廃棄（IDに関係なく）
        Destroy(gameObject);
    }
}

