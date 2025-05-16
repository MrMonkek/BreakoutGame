using UnityEngine;

public class Ball : MonoBehaviour
{// Opretter de componenter som jeg skal bruge til min bolds kode.
    public float speed = 69f;
    private Rigidbody rb;
    private bool started = false;

    void Start()
    {
// Her g�r jeg s�dan at n�r spillet starter s� henter vi rigidbody.
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
// Her siger jeg at hvis bolden ikke er startet endnu og spilleren trykke p� space s� skal bolden bev�ge sig opad, for at starte spilet.
        if (!started && Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector3(1, 0, 1).normalized * speed;
            started = true;
        }
    }
}
