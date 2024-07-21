using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    [SerializeField] Vector2 _spawnPos;
    [SerializeField] float[] _randomPosY;
    [SerializeField] GameObject[] _randomItem;
    [SerializeField] float _defaultSpawnInterval = 5;
    float _spawnInterval;
    [SerializeField] float _endPos;
    float _spawnIntervalChange;
    int _randomSpawnIndex;
    int _randomItemIndex;
    Transform _playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        _playerTransform = GameObject.Find("Player").transform;
        _spawnInterval = _defaultSpawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        Spawn(0);
    }

    public void Spawn(float pos)
    {
        _spawnIntervalChange += pos;
        if (_playerTransform != null)
        {
            if (_spawnInterval <= _playerTransform.position.x && transform.position.x <= _endPos)
            {
                _randomSpawnIndex = Random.Range(0, _randomPosY.Length);
                _spawnPos.x = transform.position.x;
                _spawnPos.y = _randomPosY[_randomSpawnIndex];
                _randomItemIndex = Random.Range(0, _randomItem.Length);
                Instantiate(_randomItem[_randomItemIndex], _spawnPos, Quaternion.identity);
                _spawnInterval += 5 + _spawnIntervalChange;
                if (_spawnInterval <= _defaultSpawnInterval)
                {
                    _spawnInterval = _defaultSpawnInterval;
                }
            }
        }
    }
}
