using System.Collections.Generic;
using UnityEngine;

public class AvailableDeckUI : MonoBehaviour
{
    [SerializeField] private List<AvailableCardUI> _avalableCardUI = new List<AvailableCardUI>();

    #region Editor
#if UNITY_EDITOR
    [SerializeField] private Transform _availableCardParrent;
    [SerializeField] private AvailableCardUI _avalableCardUIPrefab;
    

    public void SetAllCardsCount(Card[] cards)
    {
        for (int i = 0; i <_avalableCardUI.Count; i++)
        {
            GameObject go = _avalableCardUI[i].gameObject;
            UnityEditor.EditorApplication.delayCall += () => DestroyImmediate(go);
        }
        for (int i = 1; i < cards.Length; i++)
        {
            AvailableCardUI card = Instantiate(_avalableCardUIPrefab, _availableCardParrent);
            card.Init(cards[i]);
            _avalableCardUI.Add(card);
        }

        UnityEditor.EditorUtility.SetDirty(this);
    }
#endif
    #endregion

}
