using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointAnimator : MonoBehaviour
{
    private Vector2 _positionStart;

    [SerializeField]
    private float _moveSpeed = 1.0f;
    private Vector2 _positionChange;
    
    // Start is called before the first frame update
    void Start()
    {
        _positionStart = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        _positionChange = transform.position;
        _positionChange.y = _positionStart.y + (_moveSpeed * Mathf.Sin(Time.time));
        transform.position = _positionChange;
        
    }
}
