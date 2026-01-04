using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponInwentory : MonoBehaviour
{

    public bool hasWeapon = false;
    public Transform pontWeapon;
    public bool isPickUp = false;
    public Animator _attak;
    // Start is called before the first frame update
    void Start()
    {
        BoxCollider2D boxCollider = GetComponent<BoxCollider2D>();
        boxCollider.isTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(hasWeapon = true){
            isPickUp = true;
        }
        BoxCollider2D boxCollider = GetComponent<BoxCollider2D>();
        
        if(isPickUp = true){
            this.transform.position = pontWeapon.position;
            boxCollider.isTrigger = true;
        }
        isPickUp = false;
        if(Input.GetMouseButton(0)){
            _attak.SetBool("isAttak", true);
        }else{
            _attak.SetBool("isAttak", false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Проверяем, если объект, с которым произошло столкновение, имеет тег "Weapon"
        if (collision.gameObject.CompareTag("Player"))
        {
            PickUpWeapon(collision.gameObject);
        }
    }
    void PickUpWeapon(GameObject weaponObject)
    {
        hasWeapon = true; // Игрок взял оружие
        Debug.Log("Взял оружие!");
        this.transform.position = pontWeapon.position;
        isPickUp = true;
    
    }
}
