using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evaluacion : MonoBehaviour
{
    public string Nombre, Ori;
    public int Anio;
    // Start is called before the first frame update
    void Start()
    {
        if (Nombre != "")
        {
            if (Anio == 1 || Anio == 2)
            {
                Debug.Log("Error. Aún estás en el ciclo básico");
            }
            else if (Anio == 3 || Anio == 4 || Anio == 5)
            {
                if (Ori == "M" || Ori == "T" || Ori == "H" || Ori == "G" || Ori == "D")
                {
                    Debug.Log("Muchas gracias " + Nombre);
                }
                else
                {
                    Debug.Log("Solo puede ingresar T, D, G, M o H");
                }
            }
            else
            {
                Debug.Log("El año ingresado no es valido.");
            }
        } else
        {
            Debug.Log("El nombre ingresado no es valido.");
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
