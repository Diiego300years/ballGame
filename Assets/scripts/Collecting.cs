using UnityEngine;
using UnityEngine.UI;

public class CollectibleObject : MonoBehaviour
{
    public Text endGameText;
    public int collectedCount = 0; // Licznik zebranych przedmiotów
    public int targetCount = 10;


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject); // Zniszcz obiekt po kontakcie

            collectedCount++; // Zwiêksz licznik zebranych przedmiotów

            if (collectedCount >= targetCount)
            {
                EndGame();
            }
        }


        void EndGame()
        {
            // Wyœwietl okno "Koniec Gry"
            endGameText.gameObject.SetActive(true);
            endGameText.text = "Koniec Gry! Zebrano wszystkie obiekty.";

            // Mo¿esz dodaæ dodatkow¹ logikê lub funkcje koñcowe gry tutaj
        }
    }
}
