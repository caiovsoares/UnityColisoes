using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectaColisao : MonoBehaviour
{

    [SerializeField]
    private GameObject obj1, obj2;

    private Vector3 pos1, pos2, sca1, sca2;

    private bool con1, con2, con3, con4;

    //usa as formulas utilizadas em love for lua para detecção de colisões
    //os valores do eixo Y são invertidos pois em Lua o eixo Y cresce de cima para baixo, ao contrário de Unity
    public bool[] detectaColisao()
    {
        pos1 = obj1.transform.position;
        pos2 = obj2.transform.position;
        sca1 = obj1.transform.localScale;
        sca2 = obj2.transform.localScale;

        con1 = pos2.x >= (pos1.x - sca2.x);
        con2 = pos2.x <= (pos1.x + sca1.x);
        con3 = (-pos2.y + sca2.y) >= -pos1.y;
        con4 = -pos2.y <= (-pos1.y + sca1.y); 
        return new bool[4] { con1, con2, con3, con4 };
    }
}

