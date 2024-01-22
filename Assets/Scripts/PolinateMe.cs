using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolinateMe : MonoBehaviour
{
    BoxCollider2D box;
    [SerializeField] bool Carrying;
    private GameObject bee;
    // Start is called before the first frame update
    void Start()
    {
        box = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Character")
        {
            Debug.Log("collided");
        }
    }
}
