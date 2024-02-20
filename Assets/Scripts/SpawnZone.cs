using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZone : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefab;
    [SerializeField] Vector3 _zoneSize;

    private float _valeurHasardAppelerMethode;
    private float _valeurHasardRepeterApresTemps;

    // Start is called before the first frame update
    void Start()
    {
        _valeurHasardAppelerMethode = Random.Range(1, 3);
        _valeurHasardRepeterApresTemps = Random.Range(2, 4);

        InvokeRepeating("AddGameObject", _valeurHasardAppelerMethode, 5);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

// ------------------------------------------------------------------------------------------------------------
    void AddGameObject()
    {
        GameObject instantied = Instantiate(_cubePrefab);
        instantied.transform.position = new Vector3(
            Random.Range(transform.position.x - _zoneSize.x / 2, transform.position.x + _zoneSize.x / 2),
            Random.Range(transform.position.y - _zoneSize.y / 2, transform.position.y + _zoneSize.y / 2),
            Random.Range(transform.position.z - _zoneSize.z / 2, transform.position.z + _zoneSize.z / 2)
        );
    }

// ------------------------------------------------------------------------------------------------------------
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, _zoneSize);
    }
}
