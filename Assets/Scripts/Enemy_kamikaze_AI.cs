using UnityEngine;
using System.Collections;

public class Enemy_kamikaze_AI : MonoBehaviour {

    private Rigidbody2D rbody;
    private Vector3 position;
    private bool isRunning = true;

    void Awake()
    {
        rbody = gameObject.GetComponent<Rigidbody2D>();
        position = gameObject.transform.position; 
    }

    void Update()
    {
        Charge();
    }

    void Charge()
    {
        Vector3 direction = Vector3.zero - position;
        rbody.velocity = transform.TransformDirection(direction * .25f);
    }
}
