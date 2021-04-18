using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DadosCanvas : MonoBehaviour
{
    [SerializeField]
    private TextMesh textX, textY, textHeight, textWidth, objetoTexto;

    public void updatePos(Transform objeto)
    {
        Vector3 corrector = new Vector3(objeto.localScale.x, -objeto.localScale.y, 0);

        objetoTexto.transform.position = objeto.position + corrector;
        textX.transform.position = objeto.position + new Vector3(-objeto.localScale.x, objeto.localScale.y+0.3f, 0) + corrector;
        textY.transform.position = objeto.position + new Vector3(-objeto.localScale.x, objeto.localScale.y, 0) + corrector;
        textHeight.transform.position = objeto.position + new Vector3(-objeto.localScale.x, 0, 0) + corrector;
        textWidth.transform.position = objeto.position + new Vector3(0, -objeto.localScale.y, 0) + corrector;
    }

    public void setX(float value) => textX.text = "X: " + Math.Round(value, 2);
    public void setY(float value) => textY.text = "Y: " + Math.Round(value, 2);
    public void setHeight(float value) => textHeight.text = "Altura: " + Math.Round(value, 2);
    public void setWidth(float value) => textWidth.text = "Largura: " + Math.Round(value, 2);
}

