using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPrefaabGround : MonoBehaviour
{
    [SerializeField] private GameObject CrystalPrefab;
    private GameObject _currentCrystal;
    void Start()
    {
        InvokeRepeating("Creator", Random.Range(1, 100), Random.Range(1, 100));
    }

    private void Creator()
    {
        if(_currentCrystal == null)
        {
            _currentCrystal = Instantiate(CrystalPrefab, transform.position, Quaternion.identity);
        }
    }
}
