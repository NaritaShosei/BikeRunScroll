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
    [SerializeField] float _waitTime;
    // Start is called before the first frame update
    void Start()
    {
        _playerTransform = GameObject.Find("Player").transform;
        _spawnInterval = _defaultSpawnInterval;
        StartCoroutine(StartSpawn(0));
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Spawn()
    {
        if (_playerTransform && transform.position.x <= 650)
        {
            _randomSpawnIndex = Random.Range(0, _randomPosY.Length);
            _spawnPos.x = transform.position.x;
            _spawnPos.y = _randomPosY[_randomSpawnIndex];
            _randomItemIndex = Random.Range(0, _randomItem.Length);
            Instantiate(_randomItem[_randomItemIndex], _spawnPos, Quaternion.identity);
        }
    }
    public IEnumerator StartSpawn(float pos)
    {
        var time = pos;
        var waitTime = _waitTime + time;
        yield return new WaitForSeconds(waitTime);
        Spawn();
        StartCoroutine(StartSpawn(0));
    }
}
