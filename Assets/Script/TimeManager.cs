using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField] Text _timerText;
    float _timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    void Timer()
    {
        _timer += Time.deltaTime;
        _timerText.text = $"Œo‰ßŽžŠÔ:{_timer.ToString("00.00")}•b";
    }
}
