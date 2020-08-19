using UnityEngine;
using TMPro;


public class ScoreCount : MonoBehaviour
{
    private TMP_Text m_TextComponent;

    private void Awake()
    {
        // Referencia al componente instalado
        m_TextComponent = GetComponent<TMP_Text>();
    }

    private void Start()
    {
        // Cambiar el texto en el componente tmp text
        m_TextComponent.text = "0   0";
    }
}
