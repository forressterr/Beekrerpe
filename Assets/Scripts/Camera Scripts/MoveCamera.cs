using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            MoveMapLeft();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            MoveMapRight();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            MoveMapUp();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            MoveMapDown();
        }

    }

    void MoveMapLeft()
    {
        gameObject.GetComponent<Transform>().position += new Vector3(-1, 0, 0);
    }
    void MoveMapRight()
    {
        gameObject.GetComponent<Transform>().position += new Vector3(1, 0, 0);
    }
    void MoveMapUp()
    {
        gameObject.GetComponent<Transform>().position += new Vector3(0, 1, 0);
    }
    void MoveMapDown()
    {
        gameObject.GetComponent<Transform>().position += new Vector3(0, -1, 0);
    }
}
