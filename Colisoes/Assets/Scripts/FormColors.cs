using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FormColors : MonoBehaviour
{
    private Color trueColor = Color.green;
    private Color falseColor = Color.gray;

    [SerializeField]
    private Text tCon1, tCon2, tCon3, tCon4, limpar;

    [SerializeField]
    private GameObject[] iCons;

    private void Start()
    {
        limparClick();
    }

    //atualiza as cores das condições na tela baseado em um array de bools recebido
    public void updateColor(bool[] cond)
    {
        tCon1.color = cond[0] ? trueColor : falseColor;
        tCon2.color = cond[1] ? trueColor : falseColor;
        tCon3.color = cond[2] ? trueColor : falseColor;
        tCon4.color = cond[3] ? trueColor : falseColor;
    }

    //funções para setar qual condição esta ativa visualmente no momento
    public void con1Click()
    {
        foreach (GameObject iCon in iCons)
            iCon.SetActive(iCon.tag == "con1");
        limpar.gameObject.SetActive(true);
    }
    public void con2Click()
    {
        foreach (GameObject iCon in iCons)
            iCon.SetActive(iCon.tag == "con2");
        limpar.gameObject.SetActive(true);
    }
    public void con3Click()
    {
        foreach (GameObject iCon in iCons)
            iCon.SetActive(iCon.tag == "con3");
        limpar.gameObject.SetActive(true);
    }
    public void con4Click()
    {
        foreach (GameObject iCon in iCons)
            iCon.SetActive(iCon.tag == "con4");
        limpar.gameObject.SetActive(true);
    }

    public void limparClick()
    {
        limpar.gameObject.SetActive(false);
        foreach (GameObject iCon in iCons)
            iCon.SetActive(false);
    }
}
