using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelecter : MonoBehaviour
{
    [Tooltip("Selected unit")]
    GameObject selectedUnit;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FindNearestUnit();
        } 
    }

    void FindNearestUnit()
    {
        GameObject[] units = GameObject.FindGameObjectsWithTag("Character");
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 pos = new Vector3(999,999,999);
        foreach (GameObject unit in units)
        {
            unit.GetComponent<UnitScript>().Selected = false;
            if(Mathf.Abs(unit.transform.position.x - mousePos.x) < Mathf.Abs(pos.x - mousePos.x))
            {
                if (Mathf.Abs(unit.transform.position.y - mousePos.y) < Mathf.Abs(pos.y - mousePos.y))
                {
                    pos = unit.transform.position;
                    selectedUnit = unit;
                }
            }

        }
        selectedUnit.GetComponent<UnitScript>().Selected = true;
        selectedUnit.GetComponentInChildren<SpriteRenderer>().color = new Color(200,0,0);
    }
}
