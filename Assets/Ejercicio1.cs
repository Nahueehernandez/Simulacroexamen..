using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    // Start is called before the first frame update
    //1.Crea un programa que permita ingresar por Inspector dos valores enteros y responda si son iguales o no lo son.
    public int valor1;
    public int valor2;
    void Start()
    {
        if (valor1 == valor2)
        {
            Debug.Log("Los valores son iguales");
        }
        else
        {
            Debug.Log("Los valors NO son iguales");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
