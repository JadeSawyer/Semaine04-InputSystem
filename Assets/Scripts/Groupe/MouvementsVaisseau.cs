using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MouvementsVaisseau : MonoBehaviour
{
    private Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Bouger()
    {

    }

    public void OnMove()
    {
        Debug.Log("ok");
    }

    public void OnFaitQQC()
    {
        Debug.Log("oksdfsd");
    }
}
