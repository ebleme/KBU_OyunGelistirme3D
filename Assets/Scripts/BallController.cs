using UnityEngine;
using UnityEngine.InputSystem;

public class BallController : MonoBehaviour
{

    void Start()
    {
        
    }

   
    /*
     * Transform set ederek
     * -- Translate
     * FixedUpdate içinde
     * Rigidbody
     * -- AddForce
     * -- AddTorque
     * -- MovePosition
     * CharacterController
     * NavmeshAgent
     */
    
    void Update()
    {
       float x = Input.GetAxis("Horizontal"); // Yatay -1,0,1
       float z = Input.GetAxis("Vertical");   // Dikey -1,0,1


       Debug.Log("X: " + x + " Z: " + z);
    }
}
