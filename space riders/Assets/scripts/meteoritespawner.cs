using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteoritespawner : MonoBehaviour
{
    public float Timer = 0;
    public float MaxTimer = 1;

    public GameObject prefab;
    void Start()
    {
        
    }
    
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            Timer = MaxTimer;
            Instantiate(prefab, new Vector3(Random.Range(-15f,15f),Random.Range(56f,55f),0),Quaternion.identity);
            
        }

    }
}
