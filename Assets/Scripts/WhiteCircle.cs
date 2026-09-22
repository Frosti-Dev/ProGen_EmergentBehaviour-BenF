using UnityEngine;

public class WhiteCircle : MonoBehaviour
{
    public float attractForce = 10f;
    public float attractRange = 5f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        GameObject[] targets1 = GameObject.FindGameObjectsWithTag("Blue");
        GameObject[] targets2 = GameObject.FindGameObjectsWithTag("Red");
        

        foreach (GameObject obj in targets1)
        {
            if (rb != null)
            {
                Vector2 direction = obj.transform.position - transform.position;
                float distance = direction.magnitude;

                if (distance < attractRange && distance > 0.1f)
                {
                    Vector2 normalizedDir = direction.normalized;

                    rb.AddForce(normalizedDir * (attractForce / distance));
                }
            }
        }

        foreach (GameObject obj in targets2)
        {
            if (rb != null)
            {
                Vector2 direction = obj.transform.position - transform.position;
                float distance = direction.magnitude;

                if (distance < attractRange && distance > 0.1f)
                {
                    Vector2 normalizedDir = direction.normalized;

                    rb.AddForce(normalizedDir * (attractForce / distance));
                }
            }
        }
    }
}
