using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private DeckLoader _deckLoader;
    void Start()
    {
        _deckLoader.Init();
    }


}
