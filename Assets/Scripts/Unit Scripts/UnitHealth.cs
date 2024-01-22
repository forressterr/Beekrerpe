using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitHealth : MonoBehaviour
{
    [SerializeField] public int MaxHealth = 20;
    [SerializeField] private int CurrentHealth = 999;
    [SerializeField] public int Damage = 5;
// Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
