using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
// Her sætter jeg hastighed ved hjælp af float til 20.
    public float speed = 20f;
    void Update()
    {
// Her hentes input fra spilleren. Den returnerer en værdi mellem -1 og 1 afhængigt af om spilleren trykker venstre eller højre.
        float move = Input.GetAxis("Horizontal");
// Denne linje gør at bevæger paddlen horisontalt baseret på spilleren input.
        transform.Translate(move * speed * Time.deltaTime, 0, 0);
    }
}
