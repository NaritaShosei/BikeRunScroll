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
                    _gameOverText.text = "�Q�[���I�[�o�[";
                    Destroy(_lifeText);
                    Destroy(_speedText);
                }
                else
                {
                    _speedText.text = $"�X�s�[�h{PlayerManager._staticSpeed.ToString("00.00")}km�ŃN���A";
                    _lifeText.text = $"�c��HP{PlayerManager._staticLife.ToString()}�ŃN���A";
                    Destroy(_gameOverText);
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
            _speedText.text = $"���݂̃X�s�[�h:{PlayerManager._staticSpeed.ToString("00.00")}km";
            _lifeText.text = $"�c��HP:{PlayerManager._staticLife.ToString()}";
        }
    }
}
