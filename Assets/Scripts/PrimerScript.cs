using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimerScript : MonoBehaviour
{
    // Variables
     public int numeroEntero = 5; // Variable para numeros enteros
     private float numeroDecimal = 7.5f; // Variable para numeros decimales
     bool boleana = true;                // Variable con solo 2 estados, true o false 
     string cadenaTexto = "Borderlands 4";  // Variable para texto 


    // Start is called before the first frame update
    void Start()
    {
      Calculos();   // Para llamar a la función 
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    void Calculos()
      {
         Debug.Log(numeroEntero);
        numeroEntero = 17;  // Establecer valor al iniciar el codigo
        Debug.Log(numeroEntero);   // Para que aparezca en la consola al dar play la variable seleccionada

        numeroEntero = 7 + 5;  // Puedes sumar, restar, mnultiplicar y dividir el numero 
        Debug.Log(numeroEntero);

        numeroEntero++; // Para subir o bajar de uno en uno 

        numeroEntero += 2; // Para sumar o restar cantidades en concreto 

  

    }
}
