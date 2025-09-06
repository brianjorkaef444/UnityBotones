using UnityEngine;
using TMPro;

public class ControlFuente : MonoBehaviour
{
    public TextMeshProUGUI texto;

    public void CambiarTexto()
    {
        texto.text = "Texto cambiado!";
    }
}
