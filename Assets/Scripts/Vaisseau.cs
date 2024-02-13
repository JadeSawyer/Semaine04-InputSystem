using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Vaisseau : MonoBehaviour
{

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

    }
}
