using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RakipPlayer : MonoBehaviour
{
    public Rigidbody rakipRB;
    private float hiz;
    private float x;
    private string name;
    [HideInInspector]public bool rakipIsAlive = true;

    private RakipInstansiateScript rakipObjScript;
    public GameObject rakipObj; 
    // Start is called before the first frame update
    void Start()
    {
        rakipRB = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        hiz = Random.Range(19f, 21f);

        
        transform.position += Vector3.forward * 10*Time.deltaTime;

        gameObject.transform.rotation = new Quaternion(0,0,0,1);

        float x = transform.position.x;
        float z = transform.position.z;

        gameObject.transform.position = new Vector3(x,0,z);
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Player" && other.gameObject.tag != "kenar" && other.gameObject.tag != "Rakip"){
            x = Random.Range(-3.86f, 4.03f);
            gameObject.transform.position = new Vector3(x , 0 , -31200.25f);
        }
    }
}
