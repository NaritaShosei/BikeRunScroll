using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextLifeAndSpeed : MonoBehaviour
{
    [SerializeField] Text _lifeText;
    [SerializeField] Text _speedText;
    [SerializeField] Text _gameOverText;
    [SerializeField] GameMode _gameMode;
    enum GameMode
    {
        ingame,
        result
    }

    // Start is called before the first frame update
    void Start()
    {
        switch (_gameMode)
        {
            case GameMode.ingame:

                break;
            case GameMode.result:
                if (PlayerManager._gameOver)
                {
                    _gameOverText.text = "ゲームオーバー";
                }
                else
                {
                    _speedText.text = $"スピード{PlayerManager._staticSpeed.ToString("F2")}kmでクリア";
                    _lifeText.text = $"残りHP{PlayerManager._staticLife.ToString()}でクリア";
                }
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        Text();
    }
    void Text()
    {
        if (_gameMode == GameMode.ingame)
        {
            _speedText.text = $"現在のスピード:{PlayerManager._staticSpeed.ToString("F2")}km";
            _lifeText.text = $"残りHP:{PlayerManager._staticLife.ToString()}";
        }
    }
}
