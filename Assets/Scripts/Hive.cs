using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hive : MonoBehaviour
{
    private int level = 0;
    [SerializeField] GameObject lvl1;
    [SerializeField] GameObject lvl2;
    [SerializeField] GameObject lvl3;
    [SerializeField] Sprite full;

    private void Start()
    {

    }

    public void LevelUp()
    {
        if (level < 3)
        {
            level++;
            switch (level)
            {
                case 0: break;
                case 1: lvl1.GetComponent<Image>().sprite = full; break;
                case 2: lvl2.GetComponent<Image>().sprite = full; break;
                case 3: lvl3.GetComponent<Image>().sprite = full; break;

                default:
                    break;
            }
        }
    }
}
