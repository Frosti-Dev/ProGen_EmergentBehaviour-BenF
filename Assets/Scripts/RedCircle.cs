using UnityEngine;

public class RedCircle : MonoBehaviour
{
    public float attractForce = 10f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag("Red");
        foreach (GameObject obj in targets)
        {
            if (rb != null)
            {
                Vector2 direction = (Vector2)transform.position - rb.position;
                rb.linearVelocity = direction.normalized * attractForce;
            }
        }
    }
}
