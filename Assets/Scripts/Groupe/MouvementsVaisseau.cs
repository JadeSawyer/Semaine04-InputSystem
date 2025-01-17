using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouvementsVaisseau : MonoBehaviour
{ 
    // Valeur de contrôle horizontal provenant du joueur
    private float _valeurX;
    // Valeur de contrôle vertical provenant du joueur
    private float _valeurY;

    private int _points = 0;

    private Rigidbody _rb;

    private Vector2 _valeurRecue;

   
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Bouger();
    }

// -------------------------------------------------------------------------------------------------------
    void Bouger()
    {
        //_rb.velocity = new Vector2(-1, 0);
        _valeurX = _valeurRecue.x;
        _valeurY = _valeurRecue.y;

        _rb.velocity = new Vector3(_valeurX * 10, _valeurY * 10, 0);
    }

// -------------------------------------------------------------------------------------------------------
    public void OnMove(InputValue value)
    {
        //Debug.Log(value.Get<Vector2>());

        _valeurRecue = value.Get<Vector2>();
    }

// -------------------------------------------------------------------------------------------------------
    private void OnCollisionEnter(Collision other)
    {
        // Debug.Log(other.gameObject.tag);

        if(other.gameObject.CompareTag("CubePoints"))
        {
            Destroy(other.gameObject);
            _points++;
            Debug.Log(_points);
        }

        if(other.gameObject.CompareTag("DetruirePlayer"))
        {
            Destroy(gameObject);
        }
    }
}
