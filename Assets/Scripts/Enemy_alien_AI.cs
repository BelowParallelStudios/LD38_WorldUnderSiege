using UnityEngine;
using System.Collections;

public class Enemy_alien_AI : MonoBehaviour {

    public AudioClip shoot;

    public Rigidbody2D enemyProjectile;
    private Vector3 position;
    private bool isRunning = true;
	
    void Awake()
    {
        position = gameObject.transform.position;
        StartCoroutine(Shoot(5));
    }

    IEnumerator Shoot(float time)
    {
        while (isRunning)
        {
            yield return new WaitForSeconds(time);

            SoundManager.instance.PlaySingle(shoot);

            Vector3 direction = Vector3.zero - position;
            Rigidbody2D clone;
            clone = Instantiate(enemyProjectile, position, Quaternion.identity) as Rigidbody2D;
            clone.velocity = transform.TransformDirection(direction * .75f);
        }

    }
}
