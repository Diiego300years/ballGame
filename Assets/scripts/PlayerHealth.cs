using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    private Rigidbody playerRigidbody;
    public DeathUI deathUI;
    private bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        InitializeComponents();
    }

    // Update is called once per frame
    void Update()
    {
        HandleDeath();
    }


    private void InitializeComponents()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        if (playerRigidbody == null)
            Debug.LogError("Missing Rigidbody component!");
    }


    private void HandleDeath()
    {
        // SprawdŸ, czy pozycja gracza osi¹gnê³a lub spad³a poni¿ej -15 w osi Y
        if (isAlive && transform.position.y <= -10)
        {
            // Tutaj umieœæ kod obs³uguj¹cy œmieræ gracza, np. odejmowanie punktów ¿ycia lub restart gry
            Debug.LogError("Death");
            health = 0;

            // Zatrzymaj czas gry
            Time.timeScale = 0f;


            // Wyœwietl ekran œmierci
            if (deathUI != null)
            {
                deathUI.ShowDeathScreen();
            }

            else
            {
                Debug.LogError("Referencja do DeathUI nie zosta³a przypisana w Unity Inspector.");
            }

            // Ustaw flagê na false, aby zatrzymaæ dalsze wykonywanie kodu
            isAlive = false;
        }
    }

}
