using UnityEngine;
using UnityEngine.InputSystem;

public class KarakterEMD : MonoBehaviour
{
    [SerializeField] private int MünzenZähler = 0; //Counter für Zähler


    [SerializeField] private float speed = 6f; // Geschwindichkeit
    private Vector3 direction = new Vector3(x: 0f, y: 0f, z: 0f); // Start punkt

    [SerializeField] private MünzenManager münzenManager;
    [SerializeField] private UIManager uiManager;

    private bool canMove = true;  //Damit erkennt das man sich bewegen kann

    void Start()
    {
        
    }

    
    void Update()
    {
        if (canMove)
        {
            transform.position += direction.normalized * speed * Time.deltaTime; // Bewegungs-Geschwindichkeit,  += wichtig

            direction = Vector3.zero;   //   Bewegt sich nicht

            if (Keyboard.current.wKey.isPressed) //Oben
            {
                direction.y = 1;
            }

            if (Keyboard.current.sKey.isPressed) //Unten 
            {
                direction.y = -1;
            }

            if (Keyboard.current.aKey.isPressed) // Links
            {
                direction.x = -1;
            }

            if (Keyboard.current.dKey.isPressed) // Rechts
            {
                direction.x = 1;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        Debug.Log(message: "wir sind mit was Kolidiert!");

        if (other.CompareTag("Coin"))
        {
            Debug.Log(message: "Eine Münze: ");
            Destroy(other.gameObject);
            //.AddCoin();
            MünzenManager.AddMünzen();
        }

        else if (other.CompareTag("obstacle"))
        {
            Debug.Log(message: "Es war ein Obstacle");
            // TODO: Show Lostscreen and disable movement
            uiManager.ShowPanelLost();
            canMove = false;
        }
    }

}
