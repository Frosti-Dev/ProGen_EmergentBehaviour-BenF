using UnityEngine;

public class RedCircle : MonoBehaviour
{
    public float attractForce = 10f;
    public float repelForce = 15f;
    public float range = 5f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        GameObject[] attractTargets = GameObject.FindGameObjectsWithTag("Blue");
        GameObject[] repelTargets = GameObject.FindGameObjectsWithTag("Red");

        foreach (GameObject obj in repelTargets)
        {
            if (rb != null)
            {
                Vector2 direction = obj.transform.position - transform.position;
                float distance = direction.magnitude;

                if (distance < range && distance > 0.1f)
                {
                    Vector2 normalizedDir = direction.normalized;

                    rb.AddForce(-normalizedDir * (repelForce / distance));
                }
            }
        }

        foreach (GameObject obj in attractTargets)
        {
            if (rb != null)
            {
                Vector2 direction = obj.transform.position - transform.position;
                float distance = direction.magnitude;

                if (distance < range && distance > 0.1f)
                {
                    Vector2 normalizedDir = direction.normalized;

                    rb.AddForce(normalizedDir * (attractForce / distance));
                }
            }
        }
    }
}
