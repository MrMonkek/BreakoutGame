using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
// Her s�tter jeg hastighed ved hj�lp af float til 20.
    public float speed = 20f;
    void Update()
    {
// Her hentes input fra spilleren. Den returnerer en v�rdi mellem -1 og 1 afh�ngigt af om spilleren trykker venstre eller h�jre.
        float move = Input.GetAxis("Horizontal");
// Denne linje g�r at bev�ger paddlen horisontalt baseret p� spilleren input.
        transform.Translate(move * speed * Time.deltaTime, 0, 0);
    }
}
