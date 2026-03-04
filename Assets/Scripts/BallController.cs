using System;
using UnityEngine;

public class BallController : MonoBehaviour
{
        [SerializeField] float speed = 10f;


    private Vector3 moveVector;
    
    Rigidbody rb;
    CharacterController controller;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }


    void Start()
    {
    }


    /*
     * Transform set ederek  ++
     * -- Translate
     * FixedUpdate içinde ++
     * Rigidbody
     * -- AddForce ++
     * -- AddTorque ++
     * -- MovePosition ++
     * CharacterController
     * NavmeshAgent
     */

    void Update() // Bilgisayar ne kadar hızlıysa o kadar hızlı çalışır
    {
        //Time.deltaTime; // Önceki frame ile bu frame arasında geçen saniye
        // Hızlı PC de zaman küçük
        // Yavaş PC de zaman büyük olur

        float x = Input.GetAxis("Horizontal"); // Yatay -1,0,1
        float z = Input.GetAxis("Vertical"); // Dikey -1,0,1

        if (x == 0 && z == 0)
        {
            moveVector = new Vector3(0f, 0f, 0f);
            return;
        }

        moveVector = new Vector3(x, 0, z);
    }

    private void FixedUpdate() // Update e göre daha yavaş çalışır
    {
        Vector3 move = moveVector * Time.fixedDeltaTime * speed;
        
        // transform.position += move;
        // rb.MovePosition(transform.position + move);
        
        // rb.AddForce(move, ForceMode.Force); // Cismin kütlesi önemli
        // rb.AddTorque(move); // Cismin kütlesi önemli
        
        controller.Move(move);
        
    }
}