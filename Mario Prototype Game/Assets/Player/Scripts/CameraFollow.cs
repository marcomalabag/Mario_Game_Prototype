using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject Camera;

    [SerializeField]
    private Vector3 OffSet;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FollowObject();
    }

    public void FollowObject()
    {
        Vector3 cameraPosition = transform.position + OffSet;
        Camera.transform.position = cameraPosition;

    }
}
