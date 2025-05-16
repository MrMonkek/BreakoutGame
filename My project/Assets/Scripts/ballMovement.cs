using UnityEngine;

public class Ball : MonoBehaviour
{// Opretter de componenter som jeg skal bruge til min bolds kode.
    public float speed = 69f;
    private Rigidbody rb;
    private bool started = false;

    void Start()
    {
// Her gør jeg sådan at når spillet starter så henter vi rigidbody.
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
// Her siger jeg at hvis bolden ikke er startet endnu og spilleren trykke på space så skal bolden bevæge sig opad, for at starte spilet.
        if (!started && Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector3(1, 0, 1).normalized * speed;
            started = true;
        }
    }
}
