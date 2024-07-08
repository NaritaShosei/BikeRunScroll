using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    [SerializeField] Vector2 _spawnPos;
    [SerializeField] float[] _randomPosY;
    [SerializeField] GameObject[] _randomItem; 
    int _randomSpawnIndex;
    int _randomItemIndex;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) { 
        Spawn();
        Debug.LogWarning(_randomSpawnIndex);
        }
    }

    void Spawn()
    {
        _randomSpawnIndex = Random.Range(0, _randomPosY.Length);
        _spawnPos.x = transform.position.x;
        _spawnPos.y = _randomPosY[_randomSpawnIndex];
        _randomItemIndex = Random.Range(0,_randomItem.Length);
        Instantiate(_randomItem[_randomItemIndex],_spawnPos,Quaternion.identity);
    }
}
