using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewTurn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndTurn()
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Character");
        foreach (GameObject unit in gameObjects)
        {
           unit.GetComponent<UnitScript>().Refresh();

        }
    }
}
