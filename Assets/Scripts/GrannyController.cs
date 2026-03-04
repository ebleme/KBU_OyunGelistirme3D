using UnityEngine;

public class GrannyController : MonoBehaviour
{
    [SerializeField] float speed = 10f;

    [SerializeField] private Animator animator;

    Rigidbody rb;
    private Vector3 moveVector;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // Yatay -1,0,1
        float z = Input.GetAxis("Vertical"); // Dikey -1,0,1

        if (x == 0 && z == 0)
        {
            moveVector = new Vector3(0f, 0f, 0f);

            animator.SetBool("IsMoving", false);

            return;
        }

        animator.SetBool("IsMoving", true);

        moveVector = new Vector3(x, 0, z);
        Vector3 move = moveVector * Time.deltaTime * speed;
        rb.MovePosition(transform.position + move);
        transform.LookAt(transform.position + moveVector);
    }
}