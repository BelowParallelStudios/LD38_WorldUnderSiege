using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Planet_Controller : MonoBehaviour {

    public AudioClip playerShoot;
    public AudioClip gotHit;

    public Rigidbody2D projectile;
    int rotateSpeed = 100;
    Vector3 largeScale = new Vector3(5, 5, 0);
    Vector3 midScale = new Vector3(3, 3, 0);
    Vector3 smallScale = new Vector3(1.5f, 1.5f, 0);

   
	
	// Update is called once per frame
	void Update ()
    {
        Rotate();
        Shoot();
        Resize();
    }

    void Rotate()
    {
        if (Input.GetKey("a"))
        {
            transform.Rotate(Vector3.forward * (rotateSpeed * Time.deltaTime));
        }

        if (Input.GetKey("d"))
        {
            transform.Rotate(Vector3.back * (rotateSpeed * Time.deltaTime));
        }
    }

    void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //audio
            SoundManager.instance.PlaySingle(playerShoot);
            //shoot projectile
            Rigidbody2D clone;
            clone = Instantiate(projectile, new Vector3(0,0,0), Quaternion.identity) as Rigidbody2D;
            clone.velocity = transform.TransformDirection(Vector2.up * 5);
        }
    }

    void Resize()
    {
        if (GameManager.health == 3)
        {
            gameObject.transform.localScale = largeScale;
        }
        else if (GameManager.health == 2)
        {
            gameObject.transform.localScale = midScale;
        }
        else if (GameManager.health == 1)
        {
            gameObject.transform.localScale = smallScale;
        }
        else if (GameManager.health == 0)
        {
            //load gameover scene
            SceneManager.LoadScene(2);
            GameManager.isRunning = false;
        }
    }

    void OnTriggerEnter2D(Collider2D thing)
    {
        if (thing.gameObject.tag == "Enemy")
        {
            SoundManager.instance.PlaySingle(gotHit);
            Destroy(thing.gameObject);
            GameManager.health -= 1;
        }
    }
}
