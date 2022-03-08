using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    private GameObject _target;
    private bool _isOnEdge = false;
    private Transform _edgeChecker;
    //private LayerMask _backgroundMask;
    private float _checkRadius;

    void Start()
    {
        _target = GameObject.FindWithTag("Player");
        _edgeChecker = transform.Find("EdgeLeft");
        _checkRadius = 0.5f;
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
