using UnityEngine;

public class Brick : MonoBehaviour
{
    // Opretter de componenter som jeg skal bruge til at f� lavet effects og lyd.
    // Public g�r at de er tilg�ngelige udefra, s� den er tilg�ngelig i unity editor.
    public GameObject ExplosionEffect;
    public AudioClip hitSound;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "ball")
        {
    // Her g�r jeg s�dan at den spiler lyden uafh�ngigt af objektet, hvilket gjorde at der var mindre lag.
            if (hitSound != null)
             {
    // Her g�r jeg s�dan at lyder spiller det sted hvor de collidere. Jeg bruger PlayClipAtPoint, da det g�r at det ikke kr�ves at der er et lydkomponent p� v�r breakout block, hvilket kan reducere lag og forbedre gamefeel.
                AudioSource.PlayClipAtPoint(hitSound, transform.position);
             }

    // Her g�r jeg s�dan at den explodere, uafh�ngigt af objektet hvilket gjorde at der var mindre lag. sikrer, at der kun fors�ges at lave en effekt.
        if (ExplosionEffect != null)
            {
    // Her har jeg valgt at bruge instantiate, hvilket g�r at jeg skaber en kopi af (EksplosionsEffect), pr�cis der hvor objectet er(transform.position). Quternion.identity g�r at effekten ikke skal roteres hvilket kan reducere lag. 
                Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
            }

    // Fjerner breakout blocks med det samme.
            Destroy(gameObject);
        }
    }
}