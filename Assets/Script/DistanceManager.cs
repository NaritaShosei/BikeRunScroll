using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class DistanceManager : MonoBehaviour
{
    [SerializeField] GameObject _goalObject;
    [SerializeField] GameObject _playerObject;
    float _distance;
    [SerializeField] Text _distanceText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distance();
    }
    void Distance()
    {
        if (_playerObject != null)
        {
        _distance = Vector2.Distance(_playerObject.transform.position, _goalObject.transform.position);
        _distanceText.text = $"{ _distance.ToString("F1")}m";
        }
    }
}
