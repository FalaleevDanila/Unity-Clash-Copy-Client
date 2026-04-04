using System.Collections.Generic;
using UnityEngine;

public class AvailableDeckUI : MonoBehaviour
{
    #region Editor
    [SerializeField] private Transform _availableCardParrent;
    [SerializeField] private AvailableCardUI _avalableCardUIPrefab;
    [SerializeField] private List<AvailableCardUI> _avalableCardUI = new List<AvailableCardUI>();

    public void SetAllCardsCount(Card[] cards)
    {
        for (int i = 0; i <_avalableCardUI.Count; i++)
        {
            Destroy(_avalableCardUI[i].gameObject);
        }
        for (int i = 1; i < cards.Length; i++)
        {
            AvailableCardUI card = Instantiate(_avalableCardUIPrefab, _availableCardParrent);
            card.Init(cards[i]);
            _avalableCardUI.Add(card);
        }
    }
    #endregion

}
