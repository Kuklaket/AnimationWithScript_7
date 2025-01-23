using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;

    private void Update()
    {      
        transform.Rotate(Vector3.up, _rotateSpeed * Time.deltaTime);
    }
}
