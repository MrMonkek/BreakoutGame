using UnityEngine;

public class PaddleSound : MonoBehaviour
{
// Laver variable som holder den lydfil jeg vil bruge til padlen.
    public AudioClip paddleHitSound;
    void OnCollisionEnter(Collision col)
    {
// Har g�r jeg s�dan at hvis den collidere med et object som har taget "ball" s� skal det sker i { } ske.
        if (col.gameObject.tag == "ball")
        {
// Her g�r jeg s�dan at den spiler lyden uafh�ngigt af objektet, hvilket gjorde at der var mindre lag.
            if (paddleHitSound != null)
            {
// Her g�r jeg s�dan at lyder spiller det sted hvor de collidere. Jeg bruger PlayClipAtPoint, da det g�r at det ikke kr�ves at der er et lydkomponent p� v�r breakout block, hvilket kan reducere lag og forbedre gamefeel.
                AudioSource.PlayClipAtPoint(paddleHitSound, transform.position);
            }
        }
    }
}