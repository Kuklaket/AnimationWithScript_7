using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    private Vector3 _endTarget = new Vector3(2f, 2f, 2f);
    private Vector3 _startTarget = new Vector3(1f, 1f, 1f);
    private float _speedScale = 0.5f;
    private bool _isScaled; 

    void Update()
    {        
        if (_isScaled)
        {
            transform.localScale = Vector3.MoveTowards(transform.localScale, _endTarget, _speedScale * Time.deltaTime);

            if (transform.localScale == _endTarget)
                _isScaled = false;
        }

        if (!_isScaled)
        {
            transform.localScale = Vector3.MoveTowards(transform.localScale, _startTarget, _speedScale * Time.deltaTime);

            if (transform.localScale == _startTarget)
                _isScaled = true;
        }
    }
}
