using UnityEngine;

public class ZachowanieKamery : MonoBehaviour
{
    private Rigidbody playerRigidbody;

    void Update()
    {
        GameObject playerObbbbject = GameObject.FindWithTag("Player");
        Debug.Log("Metoda Start wywo≥ana.");


        // Sprawdü, czy obiekt zosta≥ znaleziony
        if (playerObbbbject != null)
        {
            // Uzyskaj dostÍp do komponentu Rigidbody obiektu gracza
            playerRigidbody = playerObbbbject.GetComponent<Rigidbody>();
            transform.position = playerObbbbject.transform.position + new Vector3(0, 5, -15);



            // Sprawdü, czy komponent Rigidbody zosta≥ znaleziony
            if (playerRigidbody == null)
            {
                Debug.LogError("Nie znaleziono komponentu Rigidbody na obiekcie gracza.");
            }
        }
        else
        {
            Debug.LogError("Nie znaleziono obiektu gracza z tagiem 'player'.");
        }
    }
}
