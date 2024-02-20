using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LeCubeInterieur : MonoBehaviour
{
    [SerializeField] private GameObject _cubeDedans;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Sol"))
        {
            _cubeDedans.SetActive(true);
        }
    }
}
