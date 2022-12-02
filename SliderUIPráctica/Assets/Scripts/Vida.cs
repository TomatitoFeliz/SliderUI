using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Vida : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI labelTiempo;
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    Slider sliderVida;
    [SerializeField]
    public int MaxVida;
    [SerializeField]
    int MinVida = 0;
    
    private void Start()
    {
        sliderVida.maxValue = MaxVida;
        sliderVida.minValue = MinVida; 
        sliderVida.value = MaxVida;
    }
    private void Update()
    {
        if (sliderVida.value <= 20)
        {        
            sliderVida.value -= Time.deltaTime;
            Debug.Log(sliderVida.value);
            labelTiempo.text = sliderVida.value.ToString (".00");
        }
        if (sliderVida.value <= 0)
        {
            Destroy(prefab);
        }
    }

}
