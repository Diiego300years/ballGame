using UnityEngine;
using UnityEngine.UI;

public class CollectibleObject : MonoBehaviour
{
    public Text endGameText;
    public int collectedCount = 0; // Licznik zebranych przedmiot�w
    public int targetCount = 10;


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject); // Zniszcz obiekt po kontakcie

            collectedCount++; // Zwi�ksz licznik zebranych przedmiot�w

            if (collectedCount >= targetCount)
            {
                EndGame();
            }
        }


        void EndGame()
        {
            // Wy�wietl okno "Koniec Gry"
            endGameText.gameObject.SetActive(true);
            endGameText.text = "Koniec Gry! Zebrano wszystkie obiekty.";

            // Mo�esz doda� dodatkow� logik� lub funkcje ko�cowe gry tutaj
        }
    }
}
