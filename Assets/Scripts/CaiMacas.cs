using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaiMacas : MonoBehaviour
{
    private Rigidbody rb;
    public float tempoParaCair = 2f; 

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        Invoke("DerrubarMaca", tempoParaCair);
    }

    void DerrubarMaca()
    {
        rb.isKinematic = false;
    }
}