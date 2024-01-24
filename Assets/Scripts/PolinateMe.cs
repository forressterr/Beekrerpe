using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolinateMe : MonoBehaviour
{
    BoxCollider2D box;
    [SerializeField] bool Carrying;
    private GameObject bee;
    [SerializeField] public GameObject sfx;

    // Start is called before the first frame update
    void Start()
    {
        box = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bee)
            if (Carrying && bee.gameObject.GetComponent<UnitHealth>().CurrentHealth > 0)
            {
                transform.position = new Vector3(bee.transform.position.x, bee.transform.position.y + 0.5f, bee.transform.position.z);
            }
            else if (bee.gameObject.GetComponent<UnitHealth>().CurrentHealth <= 0)
            {
                Carrying = false;
            } 

         
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Character")
            if (collision.gameObject.GetComponent<UnitHealth>().CurrentHealth > 0)
            {
                bee = collision.gameObject;
                Carrying = true;
                sfx.GetComponent<SfxSguffle>().PlayPop();
                
            }
        if (collision.tag == "Town")
        {
            collision.GetComponent<Hive>().LevelUp();
            Carrying = false;
            Invoke("sfx.GetComponent<SfxSguffle>().PlayPop()", 1.5f);            
            Object.Destroy(gameObject, 2);
        }
    }
}
