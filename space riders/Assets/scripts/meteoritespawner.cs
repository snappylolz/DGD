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
            Instantiate(prefab, new Vector3(Random.Range(-62f,64f),Random.Range(84f,82f),0),Quaternion.identity);
            
        }

    }
}
