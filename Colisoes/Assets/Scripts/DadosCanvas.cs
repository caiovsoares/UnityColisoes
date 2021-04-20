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
        //posicionamento é baseado no Anchor usado por cada textMesh
        objetoTexto.transform.position = objeto.position + new Vector3(objeto.localScale.x, -objeto.localScale.y, 0) / 2;
        textX.transform.position = objeto.position + new Vector3(0, 0.3f, 0);
        textY.transform.position = objeto.position;
        textHeight.transform.position = objeto.position + new Vector3(0,-objeto.localScale.y,0)/2;
        textWidth.transform.position = objeto.position + new Vector3(objeto.localScale.x/2, -objeto.localScale.y, 0);
    }

    //Funções que setam os valores dos textMeshs
    public void setX(float value) => textX.text = "X: " + Math.Round(value, 2);
    public void setY(float value) => textY.text = "Y: " + Math.Round(value, 2);
    public void setHeight(float value) => textHeight.text = "Altura: " + Math.Round(value, 2);
    public void setWidth(float value) => textWidth.text = "Largura: " + Math.Round(value, 2);
}

