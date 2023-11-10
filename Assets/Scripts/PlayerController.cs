using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Transform _transform;

    private void Awake()
    {
        if (!TryGetComponent(out _transform))
        {
            Debug.Log($"Transform Not Found on {this.name}.");
        }
        else
        {
            Debug.Log($"Transform Component found on {this.name}.");
        }
    }

    private void Start()
    {
        
    }

    
    private void Update()
    {
        
    }
}
