using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonEnemy : MonoBehaviour
{
    private Vector3 initialPosition;
    public float randomTime;
    private float timer;
    public GameObject Zid;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        transform.position = initialPosition;
        randomTime = Random.Range(1, 5);
        timer = randomTime;
    }

    // Update is called once per frame
    void Update()
    {
        Fire();

        

    }
    void Fire(){
        transform.Translate(Vector3.left * 0.05f);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        
                

        transform.position = initialPosition;

    }

}
