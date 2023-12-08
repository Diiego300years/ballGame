using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    private Collider myCollider;
    private bool isGrounded;
    public int score = 0;

    void Start()
    {
        InitializeComponents();
    }

    void Update()
    {
        HandleMovement();
        Jump();
    }


    private void InitializeComponents()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        myCollider = GetComponent<Collider>();

        if (playerRigidbody == null)
            Debug.LogError("Missing Rigidbody component!");
        if (myCollider == null)
            Debug.LogError("Missing Collider component!");
    }


    private void OnCollisionEnter(Collision collision)
    {
        // Sprawdü, czy obiekt dotyka ziemi (lub innej powierzchni)
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true; // Ustaw, øe obiekt dotyka ziemi
                               // Debug.LogError("KANAPKA");
        }
        else
        {
            isGrounded = false;
        }
    }


    void HandleMovement()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * 2f;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * 2f;

        if (isGrounded)
        {
            GetComponent<Rigidbody>().AddForce(2f * Input.GetAxis("Horizontal"), 0f, 2f * Input.GetAxis("Vertical"));
            transform.Rotate(0, x, 0);
            transform.Translate(x, 0, z);
        }
        else
        {
            GetComponent<Rigidbody>().AddForce(0.5f * Input.GetAxis("Horizontal"), 0f, 2f * Input.GetAxis("Vertical"));
            transform.Rotate(0, x, 0);
            transform.Translate(x, 0, z);
        }
    }


    void Jump()
    {

        if (isGrounded)
        {

            if (isGrounded && Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<Rigidbody>().AddForce(new Vector3(0f, 300f, 0f));
                isGrounded = false;
            }

        }
        else
        {
            //Debug.LogError("nw czy na ziemi jestem czy gdzie");
        }
    }
}

        