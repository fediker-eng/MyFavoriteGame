using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxEnemy : MonoBehaviour
{
    public Animator _boxEnemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnterEN2D(Collision2D collision)
    {
        
                
        if (collision.gameObject.CompareTag("Player"))
        {
            _boxEnemy.SetBool("isHitDown", true);
        }

    }
}
