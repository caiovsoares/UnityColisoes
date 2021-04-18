using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleLista : MonoBehaviour
{
    [SerializeField]
    private GameObject[] objetos;

    private Toggle toggle;

    // Start is called before the first frame update
    void Start()
    {
        toggle = GetComponent<Toggle>();
        toggleLista();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleLista()
    {
        foreach(GameObject obj in objetos)
        {
            obj.SetActive(toggle.isOn);
        }
    }
}
