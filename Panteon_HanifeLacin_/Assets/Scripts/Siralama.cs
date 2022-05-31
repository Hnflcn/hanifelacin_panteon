using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Siralama : MonoBehaviour
{

    public GameObject[] runners;
    public float[] distanceRunners;
    string[] names;

   // int deger;
   string sir;
    
    void Start()
    {
        
    }

    void Update()
    {
        for(int i=0 ; i<runners.Length ; i++){
            distanceRunners[i] = Vector3.Distance(runners[i].transform.position, transform.position);
            names[i] = runners[i].name;
        }

         

    }


}
