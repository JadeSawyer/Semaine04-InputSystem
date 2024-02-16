using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouvementsVaisseau : MonoBehaviour
{
    private Rigidbody _rb;

    private Vector2 _valeurRecue;

    // Valeur de contrôle vertical provenant du joueur
    private float _mouvementVertical;
    // Valeur de contrôle horizontal provenant du joueur
    private float _mouvementHorizontal;

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

    void Bouger()
    {
        _rb.velocity = new Vector2(_mouvementHorizontal, _mouvementVertical);
    }

    public void OnMove(InputValue value)
    {
        //Debug.Log(value.Get<Vector2>());

        _valeurRecue = value.Get<Vector2>();

        _mouvementHorizontal = _valeurRecue.x;
        _mouvementVertical = _valeurRecue.y;
    }
}
