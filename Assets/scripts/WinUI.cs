using UnityEngine;
using UnityEngine.UI;

public class WinUI : MonoBehaviour
{
    public Text winText;

    void Start()
    {
        // Ukryj tekst œmierci na pocz¹tku gry
        HideDeathScreen();
    }

    public void ShowDeathScreen()
    {
        // Wyœwietl tekst œmierci
        winText.gameObject.SetActive(true);
    }

    public void HideDeathScreen()
    {
        // Ukryj tekst œmierci
        winText.gameObject.SetActive(false);
    }


}
