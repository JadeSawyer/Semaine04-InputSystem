using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Vaisseau : MonoBehaviour
{
    private float _valeurX;
    private float _valeurY;
    
    private Vector2 _mouvementHorizontal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Bouge();
    }

    public void RecevoirInfo(InputAction.CallbackContext context)
    {
        Debug.Log(context.ReadValue<Vector2>()); // (1,0) (-1,0) (0,0)
    }

    void Bouge()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
