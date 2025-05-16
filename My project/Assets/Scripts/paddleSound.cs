using UnityEngine;

public class PaddleSound : MonoBehaviour
{
// Laver variable som holder den lydfil jeg vil bruge til padlen.
    public AudioClip paddleHitSound;
    void OnCollisionEnter(Collision col)
    {
// Har gør jeg sådan at hvis den collidere med et object som har taget "ball" så skal det sker i { } ske.
        if (col.gameObject.tag == "ball")
        {
// Her gør jeg sådan at den spiler lyden uafhængigt af objektet, hvilket gjorde at der var mindre lag.
            if (paddleHitSound != null)
            {
// Her gør jeg sådan at lyder spiller det sted hvor de collidere. Jeg bruger PlayClipAtPoint, da det gør at det ikke kræves at der er et lydkomponent på vær breakout block, hvilket kan reducere lag og forbedre gamefeel.
                AudioSource.PlayClipAtPoint(paddleHitSound, transform.position);
            }
        }
    }
}