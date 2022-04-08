using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercico2 : MonoBehaviour {
    public int precio1;
    public int precio2;
    public int precio3;
    public int montodinero;
    // Use this for initialization
    void Start () {
        int preciototal = precio1 + precio2 + precio3;
        int sobra;
        if (montodinero > preciototal)
        {
            sobra = montodinero - preciototal;
            Debug.Log("El monot de dinero es superior al precio de los productos y sobran $" + sobra);
        }
        else if (preciototal > montodinero)
        {
            sobra = preciototal - montodinero;
            Debug.Log("El monot de dinero no supera al precio de los productos y faltan $" + sobra);
        }
        else
        {
            Debug.Log("El monot de dinero es igual al precio de los productos");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
