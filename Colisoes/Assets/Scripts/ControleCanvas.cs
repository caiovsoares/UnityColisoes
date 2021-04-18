using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ControleCanvas : MonoBehaviour
{
    [SerializeField]
    private GameObject objeto,objetoCanvas,formulas;
    private DadosCanvas dadosCanvas;
    private FormColors formColors;
    [SerializeField]
    private Text textX, textY, textHeigth, textWidth, textColidiu;
    [SerializeField]
    private Slider sliderX, sliderY, sliderHeigth, sliderWidth;
    [SerializeField]
    private DetectaColisao detectaColisao;

    // Start is called before the first frame update
    void Start()
    {
        dadosCanvas = objetoCanvas.GetComponent<DadosCanvas>();
        formColors = formulas.GetComponent<FormColors>();
        onChanged();
    }

    public void onChanged()
    {
        //seta o texto dos sliders para o numero
        textX.text = Math.Round(sliderX.value, 2).ToString();
        textY.text = Math.Round(sliderY.value, 2).ToString();
        textHeigth.text = Math.Round(sliderHeigth.value, 2).ToString();
        textWidth.text = Math.Round(sliderWidth.value, 2).ToString();


        //seta a posição e escala do objeto
        objeto.transform.position = new Vector3(sliderX.value, -sliderY.value, 0);
        objeto.transform.localScale = new Vector3(sliderWidth.value, sliderHeigth.value, 1);

        //detecta colisao e troca as cores
        bool[] condicoes = detectaColisao.detectaColisao();
        formColors.updateColor(condicoes);
        bool colidiu = condicoes[0] && condicoes[1] && condicoes[2] && condicoes[3];
        textColidiu.text = colidiu ? "COLISÃO DETECTADA" : "";
        textColidiu.color = colidiu ? Color.green : Color.red;

        //atualiza os dados no canvas do objeto e a posição do mesmo
        dadosCanvas.setX(sliderX.value);
        dadosCanvas.setY(sliderY.value);
        dadosCanvas.setHeight(sliderHeigth.value);
        dadosCanvas.setWidth(sliderWidth.value);
        dadosCanvas.updatePos(objeto.transform);
    }
}
