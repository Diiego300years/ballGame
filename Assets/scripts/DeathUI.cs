using UnityEngine;
using UnityEngine.UI;

public class DeathUI : MonoBehaviour
{
    public Text deathText;
    //public CanvasGroup deathCanvasGroup;


    void Start()
    {
        // Ukryj tekst �mierci na pocz�tku gry
        HideDeathScreen();


    }

    public void ShowDeathScreen()
    {
        // Wy�wietl tekst �mierci
        deathText.gameObject.SetActive(true);
        // Poka� tekst i przycisk
        //deathCanvasGroup.alpha = 1;
        //deathCanvasGroup.interactable = true;
        //deathCanvasGroup.blocksRaycasts = true;
    }

    public void HideDeathScreen()
    {
        // Ukryj tekst �mierci
        deathText.gameObject.SetActive(false);
        //deathCanvasGroup.alpha = 0;
        //deathCanvasGroup.interactable = false;
        //deathCanvasGroup.blocksRaycasts = false;
    }
}
