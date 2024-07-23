using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class DistanceManager : MonoBehaviour
{
    GameObject _goalObject;
    GameObject _playerObject;
    float _distance;
    static float _dis;
    [SerializeField] Text _distanceText;
    [SerializeField] string _sceneName;
    [SerializeField] float _invokeTime = 1;
    // Start is called before the first frame update
    void Start()
    {
        _playerObject = GameObject.Find("Player");
        _goalObject = GameObject.Find("END");
    }

    // Update is called once per frame
    void Update()
    {
        Distance();
    }
    void Distance()
    {
        if (_playerObject)
        {
            _distance = Vector2.Distance(_playerObject.transform.position, _goalObject.transform.position);
            _dis = _distance;
            _distanceText.text = $"ÉSÅ[ÉãÇ‹Ç≈Ç†Ç∆:{_dis.ToString("000.0")}m";
        }
        if (!_playerObject)
        {
            StartCoroutine(GetScene());
        }
    }
    IEnumerator GetScene()
    {
        yield return new WaitForSeconds(_invokeTime);
        SceneChangeManager.SceneChange(_sceneName);
    }
}
