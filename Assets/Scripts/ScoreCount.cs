using System;
using UnityEngine;
using TMPro;


public class ScoreCount : MonoBehaviour
{

    private int _pad1Score;
    private int _pad2Score;
    private TextMeshProUGUI _uiText;
    [SerializeField]private GameObject _ball;
    
    public int Pad1Score
    {
        get => _pad1Score;
        set => _pad1Score = value;
    }

    public int Pad2Score
    {
        get => _pad2Score;
        set => _pad2Score = value;
    }

    

    

    public GameObject Ball
    {
        get => _ball;
        set => _ball = value;
    }
    
    
    private void Awake()
    {
        try
        {
            // Referencia al componente instalado
            _uiText = GetComponent<TextMeshProUGUI>();
            _uiText.text = "0   0";
            //_ball = GameObject.Find("Ball");
            Pad1Score = 0;
            Pad2Score = 0;
        }
        catch (ArgumentException e)
        {
            print(e);
        }

    }

    private void Update()
    {
        try
        {
            if (Pad1Score < 10 && _pad2Score < 10)
            {
                if (_ball.transform.position.x > 6.4f )
                {
                    Pad1Score+=1;
                    _uiText.text = Pad1Score.ToString() + "   " + Pad2Score.ToString();
                }
                else if (_ball.transform.position.x <= -6.4f)
                {
                    _pad2Score+=1;
                    _uiText.text = Pad1Score.ToString() + "   " + Pad2Score.ToString();
                }
            }else if (Pad1Score == 10)
            {
                _uiText.text = "Player 1 wins!!";
            }
            else if (Pad2Score == 10)
            {
                _uiText.text = "Player 2 wins!!";
            }
        }
        catch (ArgumentException e)
        {
            print(e);
        }
        
    
    }

    
}
