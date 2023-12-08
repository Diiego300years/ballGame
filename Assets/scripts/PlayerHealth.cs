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
        // Sprawd�, czy pozycja gracza osi�gn�a lub spad�a poni�ej -15 w osi Y
        if (isAlive && transform.position.y <= -10)
        {
            // Tutaj umie�� kod obs�uguj�cy �mier� gracza, np. odejmowanie punkt�w �ycia lub restart gry
            Debug.LogError("Death");
            health = 0;

            // Zatrzymaj czas gry
            Time.timeScale = 0f;


            // Wy�wietl ekran �mierci
            if (deathUI != null)
            {
                deathUI.ShowDeathScreen();
            }

            else
            {
                Debug.LogError("Referencja do DeathUI nie zosta�a przypisana w Unity Inspector.");
            }

            // Ustaw flag� na false, aby zatrzyma� dalsze wykonywanie kodu
            isAlive = false;
        }
    }

}
