using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Vaisseau : MonoBehaviour
{
    private float _valeurX;
    private float _valeurY;
    
    private Vector2 _mouvementHorizontal;

    private Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Bouge();
    }

    public void RecevoirInfo(InputAction.CallbackContext context)
    {
        //Debug.Log(context.ReadValue<Vector2>()); // (1,0) (-1,0) (0,0)
        _mouvementHorizontal = context.ReadValue<Vector2>();

        _valeurX = _mouvementHorizontal.x;
        _valeurY = _mouvementHorizontal.y;
    }

    public void Bouge()
    {
        Vector2 _mouvement = new Vector2(_valeurX, _valeurY);

        _rb.AddForce(_mouvement * 40, ForceMode.Force);

        //_rb.AddForce(_mouvementHorizontal, ForceMode.Force);
    }
}
