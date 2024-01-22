using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollCamera : MonoBehaviour
{
    int max = 13;
    int min = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Scroll();
    }

    void Scroll()
    {
        //Debug.Log();
        if (Input.GetKeyDown(KeyCode.Q) && gameObject.GetComponent<Camera>().orthographicSize < max)
        {
            gameObject.GetComponent<Camera>().orthographicSize += 1;

        } else if (Input.GetKeyDown(KeyCode.E) && gameObject.GetComponent<Camera>().orthographicSize > min)
        {
            gameObject.GetComponent<Camera>().orthographicSize -= 1;
        }

    }
}
