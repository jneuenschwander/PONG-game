using System;
using UnityEngine;
using TMPro;


public class ScoreCount : MonoBehaviour
{
    
    private int _Pad1Score = 10;
    private int _Pad2Score = 0;

    public int Pad1Score
    {
        get => _Pad1Score;
        set => _Pad1Score = value;
    }

    public int Pad2Score
    {
        get => _Pad2Score;
        set => _Pad2Score = value;
    }

    public GameObject Ball
    {
        get => _ball;
        set => _ball = value;
    }

    private TextMeshProUGUI _uiText;
    private GameObject _ball;
    private void Awake()
    {
        // Referencia al componente instalado
        _uiText = GetComponent<TextMeshProUGUI>();
        _uiText.text = "0   0";
        _ball = GameObject.Find("Ball");
    }

    private void Update()
    {
        if (_Pad1Score < 10 && _Pad2Score < 10)
        {
            if (_ball.transform.position.x >= 6.25)
            {
                _Pad1Score++;
                _uiText.text = _Pad1Score.ToString() + "   " + Pad2Score.ToString();
            }
            else if (_ball.gameObject.transform.position.x <= -6.25)
            {
                _Pad2Score++;
                _uiText.text = _Pad1Score.ToString() + "   " + Pad2Score.ToString();
            }
        }else if (_Pad1Score == 10)
        {
            _uiText.text = "Player 1 wins!!";
        }
        else if (_Pad2Score == 10)
        {
            _uiText.text = "Player 2 wins!!";
        }
    
    }
}
