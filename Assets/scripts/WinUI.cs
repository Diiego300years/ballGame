using UnityEngine;
using UnityEngine.UI;

public class WinUI : MonoBehaviour
{
    public Text winText;

    void Start()
    {
        // Ukryj tekst �mierci na pocz�tku gry
        HideDeathScreen();
    }

    public void ShowDeathScreen()
    {
        // Wy�wietl tekst �mierci
        winText.gameObject.SetActive(true);
    }

    public void HideDeathScreen()
    {
        // Ukryj tekst �mierci
        winText.gameObject.SetActive(false);
    }


}
