using UnityEngine;

public class InheritanceEnemy : Enemy // INHERITANCE
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         // moveSpeed = 20.0f;
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

}
