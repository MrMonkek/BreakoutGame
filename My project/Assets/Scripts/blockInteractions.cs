using UnityEngine;

public class Brick : MonoBehaviour
{
    // Opretter de componenter som jeg skal bruge til at få lavet effects og lyd.
    // Public gør at de er tilgængelige udefra, så den er tilgængelig i unity editor.
    public GameObject ExplosionEffect;
    public AudioClip hitSound;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "ball")
        {
    // Her gør jeg sådan at den spiler lyden uafhængigt af objektet, hvilket gjorde at der var mindre lag.
            if (hitSound != null)
             {
    // Her gør jeg sådan at lyder spiller det sted hvor de collidere. Jeg bruger PlayClipAtPoint, da det gør at det ikke kræves at der er et lydkomponent på vær breakout block, hvilket kan reducere lag og forbedre gamefeel.
                AudioSource.PlayClipAtPoint(hitSound, transform.position);
             }

    // Her gør jeg sådan at den explodere, uafhængigt af objektet hvilket gjorde at der var mindre lag. sikrer, at der kun forsøges at lave en effekt.
        if (ExplosionEffect != null)
            {
    // Her har jeg valgt at bruge instantiate, hvilket gør at jeg skaber en kopi af (EksplosionsEffect), præcis der hvor objectet er(transform.position). Quternion.identity gør at effekten ikke skal roteres hvilket kan reducere lag. 
                Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
            }

    // Fjerner breakout blocks med det samme.
            Destroy(gameObject);
        }
    }
}