using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Libreta : MonoBehaviour
{
    [SerializeField] Expediente ex;
    public TMP_Dropdown Palabras;    
    public int palabra = -1;
    [SerializeField] int BenBenji;
    [SerializeField] int PieGrande;
    public string KateMilliard;
    bool apagado;

    
    public void PalabraSeleccionada ()
    {
        palabra = Palabras.value;
        
    }

    private void Update ()

    {
        if (ex.CasoLeido == true && apagado == false)
        {
            Palabras.options.Add(new TMP_Dropdown.OptionData() { text = "Ben Benji" });

            Palabras.options.Add(new TMP_Dropdown.OptionData() { text = "PieGrande" });
            
            ex.CasoLeido = false;
            apagado = true;
        }
        
    }


    public void agregarKate()
    {
        Palabras.options.Add(new TMP_Dropdown.OptionData() { text = "Kate Milliard" });
        
    }




}
