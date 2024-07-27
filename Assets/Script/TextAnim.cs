using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextAnim : MonoBehaviour
{
    [SerializeField] Animator _anim;
    [SerializeField] float[] _waitTime;
    [SerializeField] string _animName;
    int _randomIndex;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartText());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator StartText()
    {
        _randomIndex = Random.Range(0, _waitTime.Length);
        yield return new WaitForSeconds(_waitTime[_randomIndex]);
        _anim.Play(_animName);
        StartCoroutine(StartText());
    }
}
