using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

    public GameObject enemyAlien;
    public GameObject enemyKamikaze;

    public static bool isRunning = true;
    public Text scoreText;
    public static int killCount = 0;
    public static int health = 3;

    float xSpawn;
    float ySpawn;
    Vector3 spawnLocation;
    float xSpawn2;
    float ySpawn2;
    Vector3 spawnLocation2;
    float xSpawn3;
    float ySpawn3;
    Vector3 spawnLocation3;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        StartCoroutine(SpawnEnemy(3));
    }

	// Update is called once per frame
	void Update ()
    {
        scoreText.text = "Score: " + killCount;
	}

    //spawn enemy every 3 seconds INTERVAL STARTS HIGH AND LESSENS THE MORE ENEMIES YOU KILL, SO KEEP TRACK OF KILLCOUNT
    IEnumerator SpawnEnemy(float time)
    {
        
        while (isRunning)
        {
            //wait time seconds
                yield return new WaitForSeconds(time);

            if (killCount <= 12)
            {
                //randomize spawn location
                int rando = Random.Range(0, 5);
                //spawn left
                if (rando == 0)
                {
                    xSpawn = Random.Range(-5f, -2f);
                    ySpawn = Random.Range(-5f, 5f);
                }
                //spawn top
                else if (rando == 1)
                {
                    xSpawn = Random.Range(-5f, 5f);
                    ySpawn = Random.Range(2.5f, 5f);
                }
                //spawn right
                else if (rando == 2)
                {
                    xSpawn = Random.Range(2f, 5f);
                    ySpawn = Random.Range(-5f, 5f);
                }
                //spawn bottom
                else if (rando == 3)
                {
                    xSpawn = Random.Range(-5f, 5f);
                    ySpawn = Random.Range(-5f, -2.5f);
                }

                spawnLocation = new Vector3(xSpawn, ySpawn, 0);

                Rigidbody2D clone;
                clone = Instantiate(enemyAlien, spawnLocation, Quaternion.identity) as Rigidbody2D;
            }

            else if (killCount > 12 && killCount <= 45)
            { 
                //First alien spawn info
                //randomize spawn location
                int rando = Random.Range(0, 5);
                //spawn left
                if (rando == 0)
                {
                    xSpawn = Random.Range(-5f, -2f);
                    ySpawn = Random.Range(-5f, 5f);
                }
                //spawn top
                else if (rando == 1)
                {
                    xSpawn = Random.Range(-5f, 5f);
                    ySpawn = Random.Range(2.5f, 5f);
                }
                //spawn right
                else if (rando == 2)
                {
                    xSpawn = Random.Range(2f, 5f);
                    ySpawn = Random.Range(-5f, 5f);
                }
                //spawn bottom
                else if (rando == 3)
                {
                    xSpawn = Random.Range(-5f, 5f);
                    ySpawn = Random.Range(-5f, -2.5f);
                }

                //Second alien spawn info
                //randomize spawn location
                int rando2 = Random.Range(0, 5);
                //spawn left
                if (rando2 == 0)
                {
                    xSpawn2 = Random.Range(-5f, -2f);
                    ySpawn2 = Random.Range(-5f, 5f);
                }
                //spawn top
                else if (rando2 == 1)
                {
                    xSpawn2 = Random.Range(-5f, 5f);
                    ySpawn2 = Random.Range(2.5f, 5f);
                }
                //spawn right
                else if (rando2 == 2)
                {
                    xSpawn2 = Random.Range(2f, 5f);
                    ySpawn2 = Random.Range(-5f, 5f);
                }
                //spawn bottom
                else if (rando2 == 3)
                {
                    xSpawn2 = Random.Range(-5f, 5f);
                    ySpawn2 = Random.Range(-5f, -2.5f);
                }

                spawnLocation = new Vector3(xSpawn, ySpawn, 0);
                spawnLocation2 = new Vector3(xSpawn2, ySpawn2, 0);

                Rigidbody2D clone;
                clone = Instantiate(enemyAlien, spawnLocation, Quaternion.identity) as Rigidbody2D;
                //clone.velocity = transform.TransformDirection(Vector3.down * 2);

                Rigidbody2D clone2;
                clone2 = Instantiate(enemyKamikaze, spawnLocation2, Quaternion.identity) as Rigidbody2D;

            }
            else if (killCount > 45)
            {
                //First alien spawn info
                //randomize spawn location
                int rando = Random.Range(0, 5);
                //spawn left
                if (rando == 0)
                {
                    xSpawn = Random.Range(-5f, -2f);
                    ySpawn = Random.Range(-5f, 5f);
                }
                //spawn top
                else if (rando == 1)
                {
                    xSpawn = Random.Range(-5f, 5f);
                    ySpawn = Random.Range(2.5f, 5f);
                }
                //spawn right
                else if (rando == 2)
                {
                    xSpawn = Random.Range(2f, 5f);
                    ySpawn = Random.Range(-5f, 5f);
                }
                //spawn bottom
                else if (rando == 3)
                {
                    xSpawn = Random.Range(-5f, 5f);
                    ySpawn = Random.Range(-5f, -2.5f);
                }

                //Second alien spawn info
                //randomize spawn location
                int rando2 = Random.Range(0, 5);
                //spawn left
                if (rando2 == 0)
                {
                    xSpawn2 = Random.Range(-5f, -2f);
                    ySpawn2 = Random.Range(-5f, 5f);
                }
                //spawn top
                else if (rando2 == 1)
                {
                    xSpawn2 = Random.Range(-5f, 5f);
                    ySpawn2 = Random.Range(2.5f, 5f);
                }
                //spawn right
                else if (rando2 == 2)
                {
                    xSpawn2 = Random.Range(2f, 5f);
                    ySpawn2 = Random.Range(-5f, 5f);
                }
                //spawn bottom
                else if (rando2 == 3)
                {
                    xSpawn2 = Random.Range(-5f, 5f);
                    ySpawn2 = Random.Range(-5f, -2.5f);
                }

                //Third alien spawn info
                //randomize spawn location
                int rando3 = Random.Range(0, 5);
                //spawn left
                if (rando3 == 0)
                {
                    xSpawn3 = Random.Range(-5f, -2f);
                    ySpawn3 = Random.Range(-5f, 5f);
                }
                //spawn top
                else if (rando3 == 1)
                {
                    xSpawn3 = Random.Range(-5f, 5f);
                    ySpawn3 = Random.Range(2.5f, 5f);
                }
                //spawn right
                else if (rando3 == 2)
                {
                    xSpawn3 = Random.Range(2f, 5f);
                    ySpawn3 = Random.Range(-5f, 5f);
                }
                //spawn bottom
                else if (rando3 == 3)
                {
                    xSpawn3 = Random.Range(-5f, 5f);
                    ySpawn3 = Random.Range(-5f, -2.5f);
                }

                spawnLocation = new Vector3(xSpawn, ySpawn, 0);
                spawnLocation2 = new Vector3(xSpawn2, ySpawn2, 0);
                spawnLocation3 = new Vector3(xSpawn3, ySpawn3, 0);

                Rigidbody2D clone;
                clone = Instantiate(enemyAlien, spawnLocation, Quaternion.identity) as Rigidbody2D;
                //clone.velocity = transform.TransformDirection(Vector3.down * 2);

                Rigidbody2D clone2;
                clone2 = Instantiate(enemyKamikaze, spawnLocation2, Quaternion.identity) as Rigidbody2D;

                Rigidbody2D clone3;
                clone3 = Instantiate(enemyAlien, spawnLocation3, Quaternion.identity) as Rigidbody2D;

            }
        }
    }
 }

