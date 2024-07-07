using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    [SerializeField] Vector2 _spawnPos;
    [SerializeField] float[] _randomPosY;
    int _randomIndex;
    // Start is called before the first frame update
    void Start()
    {
        _randomPosY[0] = -3.5f;
        _randomPosY[1] = -0.6f;
    }

    // Update is called once per frame
    void Update()
    {
        Spawn();
        Debug.LogWarning(_randomIndex);
    }

    void Spawn()
    {
        _randomIndex = Random.Range(0, _randomPosY.Length);
        _spawnPos.x = transform.position.x;
        _spawnPos.y = _randomPosY[_randomIndex];
    }
}
