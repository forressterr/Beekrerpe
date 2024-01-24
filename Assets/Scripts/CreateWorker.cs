using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateWorker : MonoBehaviour
{
    [SerializeField] public GameObject worker;
    [SerializeField] public GameObject hive;
    [SerializeField] public GameObject sfx;
    [SerializeField] public int food = 3;
    [SerializeField] public int currentFood;
    private bool timer = false;
    // Start is called before the first frame update
    void Start()
    {
        hive = GameObject.FindGameObjectWithTag("Town");
        currentFood = food;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpwanWorker()
    {
        if(hive != null)
        {
            if (currentFood > 0 && timer == false)
            { 
                StartCoroutine(Spawn());
                currentFood--;  
            }
                
        }
    }

    IEnumerator Spawn()
    {
        Color save = gameObject.GetComponent<Image>().color;
        timer = true;
        gameObject.GetComponent<Image>().color = Color.black;
        sfx.GetComponent<SfxSguffle>().PlayPop();
        Instantiate(worker, new Vector3(hive.transform.position.x - 1, hive.transform.position.y - 1, hive.transform.position.z), Quaternion.identity);
        yield return new WaitForSeconds(5);
        timer = false;
        gameObject.GetComponent<Image>().color = save;
    }
}
