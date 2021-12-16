using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    private GameObject _target;

    void Start()
    {
        _target = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        transform.position = new Vector3(_target.transform.position.x, _target.transform.position.y, transform.position.z);
    }
}
