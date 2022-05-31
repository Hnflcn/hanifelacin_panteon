
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RakipInstansiateScript : MonoBehaviour
{
    public GameObject rakip; 
    public Rigidbody rakipRB;
    private float x;

    

    // Start is called before the first frame update
    void Start()
    {
        
        for(int i=0 ; i<10 ; i++){
            x = Random.Range(-3.86f, 4.03f);
            Instantiate(rakip, new Vector3(x , 0 ,rakip.transform.position.z), new Quaternion(0,0,0,1));
        }
    }

}
