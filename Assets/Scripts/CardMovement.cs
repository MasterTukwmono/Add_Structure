using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardMovement : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public Transform cardParent;

    // ドラッグ開始時の手札
    private Transform originalParent;

    public void OnBeginDrag(PointerEventData eventData)
    {
        // 元の手札を記憶
        originalParent = transform.parent;
        cardParent = originalParent;

        // ドラッグ中は手札のレイアウトから外す
        transform.SetParent(cardParent.parent, false);

        // 他のUIがドラッグ中のカードを検出できるようにする
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // Raycastを戻す
        GetComponent<CanvasGroup>().blocksRaycasts = true;

        // DropPlaceにドロップされていなかった場合
        // 元の手札に戻す
        if (cardParent == originalParent)
        {
            transform.SetParent(originalParent, false);
            return;
        }

        // My_Monsterにドロップした場合
        if (cardParent.name == "My_Monster")
        {
            CardContoroller controller = GetComponent<CardContoroller>();

            if (controller != null)
            {
                int id = controller.GetCardID();
                int cost = controller.GetCardCost();

                // 効果を発動して、成功したか確認
                bool success = CardEffection.Instance.ActivateEffect(id, cost);

                if (success)
                {
                    // 効果発動成功 → カードを削除
                    transform.SetParent(cardParent, false);
                    Destroy(gameObject);
                }
                else
                {
                    // マナ不足などで失敗 → 手札に戻す
                    transform.SetParent(originalParent, false);
                }
            }
            else
            {
                // Controllerがなかった場合も手札に戻す
                transform.SetParent(originalParent, false);
            }
        }
        else
        {
            // My_Monster以外 → 手札に戻す
            transform.SetParent(originalParent, false);
        }
    }
}