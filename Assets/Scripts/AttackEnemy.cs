using UnityEngine;
using System.Collections;

public class AttackEnemy : Enemy
{
    public float dashDistance = 2f;
    public float dashTime = 0.1f;
    public float returnTime = 0.15f;

    Vector3 startPos;
    bool isDashing = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
        // startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        if (Input.GetMouseButtonDown(0) && !isDashing)
        {
            StartCoroutine(Dash());
            Attack();
        }
    }

    public override void Attack()
    {
        Debug.Log("Attacked !!");
    }

    IEnumerator Dash()
    {
        isDashing = true;
        startPos = transform.position;
        Vector3 target = startPos + Vector3.right * dashDistance;

        float t = 0;
        while (t < dashTime)
        {
            t += Time.deltaTime;
            transform.position = Vector3.Lerp(startPos, target, t / dashTime);
            yield return null;
        }

        t = 0;
        while (t < returnTime)
        {
            t += Time.deltaTime;
            transform.position = Vector3.Lerp(target, startPos, t / returnTime);
            yield return null;
        }

        isDashing = false;
    }

}
