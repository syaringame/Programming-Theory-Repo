using UnityEngine;

public class Enemy : AbstractEnemy
{
    [SerializeField]
    protected float moveSpeed = 20.0f;
    [SerializeField]
    protected float jumpForce = 5.0f;

    protected Rigidbody Rb;


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

    public virtual void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(h, 0f, v);
        transform.Translate(move * moveSpeed * Time.deltaTime);
    }

    public virtual void Jump()
    {
        if(Rb != null)
        {
            Rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

    }

     public override void Attack()
    {

    }
        

}
