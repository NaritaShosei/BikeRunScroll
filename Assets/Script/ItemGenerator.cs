using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    [SerializeField] Vector2 _spawnPos;
    [SerializeField] float[] _randomPosY;
    [SerializeField] GameObject[] _randomItem;
    [SerializeField] float _randomIntervalPlayerTransform;
    [SerializeField] float _intervalTime;
    [SerializeField] float _endPos;
    float _timer;
    int _randomSpawnIndex;
    int _randomItemIndex;
    Transform _playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        _playerTransform = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Spawn();
    }

    void Spawn()
    {
        _timer += Time.deltaTime;
        if (_playerTransform != null)
        {
            if (_randomIntervalPlayerTransform <= _playerTransform.position.x && _timer >= _intervalTime && transform.position.x <= _endPos)
            {
                _randomSpawnIndex = Random.Range(0, _randomPosY.Length);
                _spawnPos.x = transform.position.x;
                _spawnPos.y = _randomPosY[_randomSpawnIndex];
                _randomItemIndex = Random.Range(0, _randomItem.Length);
                Instantiate(_randomItem[_randomItemIndex], _spawnPos, Quaternion.identity);
                _randomIntervalPlayerTransform += 5;
                _timer = 0;
            }
        }
    }
}
