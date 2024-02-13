using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apparait : MonoBehaviour
{
    [SerializeField] private GameObject _leSol;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Apparaitre()
    {
        _leSol.SetActive(true);
    }
}
