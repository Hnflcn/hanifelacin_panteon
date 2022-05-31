using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    private Vector3 camera;

    void Start()
    {
        camera = transform.position - playerTransform.position;
    }

    void Update()
    {
        Vector3 pos = new Vector3(camera.x + playerTransform.position.x, transform.position.y, camera.z + playerTransform.position.z);
        transform.position = Vector3.Lerp(transform.position, pos, 20*Time.deltaTime);
    }
}
