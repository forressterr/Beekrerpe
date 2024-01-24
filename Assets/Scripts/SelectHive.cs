using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectHive : MonoBehaviour
{
    [SerializeField] bool selected = false;
    [SerializeField] Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        if(cam == null)
            cam = FindFirstObjectByType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            selected = true;
            cam.transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y - 0.5f, cam.transform.position.z );
        }
    }
}
