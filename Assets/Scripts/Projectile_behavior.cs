using UnityEngine;
using System.Collections;

public class Projectile_behavior : MonoBehaviour {

    public AudioClip enemyHit;

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("collision");
        if (col.gameObject.tag == "Border")
        {
            Destroy(gameObject);
        }    

        /*if (col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);
        }*/
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            SoundManager.instance.PlaySingle(enemyHit);

            Destroy(col.gameObject);
            GameManager.killCount++;
        }

        if (col.gameObject.tag == "Border")
        {
            Destroy(gameObject);
        }
    }
}
