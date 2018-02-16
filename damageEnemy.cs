using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageEnemy : MonoBehaviour {
    public int damageToGive;
    public GameObject bloodSplatter;
    public Transform hitPoint;
    public GameObject damageNumber;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            //Destroy(other.gameObject);
            other.gameObject.GetComponent<enemyHealth>().HurtEnemy(damageToGive);

            Instantiate(bloodSplatter, hitPoint.position, hitPoint.rotation);

           var clone = Instantiate(damageNumber, hitPoint.position, Quaternion.Euler(Vector3.zero)) as GameObject;

            clone.GetComponent<DamageNumbers>().damageNumber = damageToGive;
        }
    }

}
