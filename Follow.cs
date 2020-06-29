using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform PlayerTransform;
    private Vector3 _camerafollow;
    [Range(0.01f, 1.0f)]
    public float Smothfactor = 0.5f;

    void Start()
    {
        _camerafollow = transform.position - PlayerTransform.position;
        
    }
    private void LateUpdate()
    {
        Vector3 newPos = PlayerTransform.position + _camerafollow;
        transform.position = Vector3.Slerp(transform.position, newPos, Smothfactor);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
