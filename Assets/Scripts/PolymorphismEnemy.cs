using UnityEngine;

public class PolymorphismEnemy : Enemy
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    public override void Move() // POLYMORPHISM
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(h, 0f, v) * 2;
        transform.Translate(move * moveSpeed * Time.deltaTime);
    }

    public override void Jump() // POLYMORPHISM
    {
        if (Rb != null)
        {
            Rb.AddForce(Vector3.up * jumpForce * 2, ForceMode.Impulse);
        }
    }
}
