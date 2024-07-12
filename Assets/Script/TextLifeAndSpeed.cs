using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextLifeAndSpeed : MonoBehaviour
{
    PlayerManager _player;
    [SerializeField] Text _lifeText;
    [SerializeField] Text _speedText;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<PlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Text();
    }
    void Text()
    {
        _lifeText.text = $"{_player._HP.ToString()}";
        _speedText.text = $"{_player._speed.ToString("F2")}";
    }
}
