using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoniaVacaciones : MonoBehaviour
{
    public int infantiles;
    public int juveniles;
    int profesoresInfantiles;
    int profesoresJuveniles;
    int coordinadores;
    int profesTotales;
    int listaEspera;

    // Start is called before the first frame update
    void Start()
    {
        profesoresInfantiles = (infantiles - infantiles % 10) / 10;
        profesoresJuveniles = (juveniles - juveniles % 20) / 20;
        profesTotales = profesoresInfantiles + profesoresJuveniles;
        coordinadores = (profesTotales + (5 - profesTotales % 5)) / 5;
        listaEspera = (juveniles % 20) + (infantiles % 10);

        if (infantiles <0 || infantiles > 100 || juveniles<0 || juveniles>100)
        {
            Debug.Log("La cantidad de infanitles y juveniles debe estar entre 0 y 100");
        } else {
            Debug.Log("Se necesitan " + profesoresJuveniles + " profesores para los inscriptos juveniles");
            Debug.Log("Se necesitan " + profesoresInfantiles + " profesores para los inscriptos infantiles");
            Debug.Log("Se necesitan " + coordinadores + " coordinadores para los profesores");
            Debug.Log("Hay " + listaEspera + " inscriptos en la lista de espera");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
