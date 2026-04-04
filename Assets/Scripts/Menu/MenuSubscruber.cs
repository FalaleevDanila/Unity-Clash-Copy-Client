using UnityEngine;

public class MenuSubscruber : MonoBehaviour
{
    [SerializeField] private DeckManager _deckManager;
    [SerializeField] private SelectedDeckUI _selectedDeckUI;
    
    private void Start()
    {
        _deckManager.UpdateSelected += _selectedDeckUI.UpdateCardsList;
    }

    private void OnDestroy()
    {
        _deckManager.UpdateSelected -= _selectedDeckUI.UpdateCardsList;
    }
}
