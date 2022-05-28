using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer2 : MonoBehaviour
{
    public float speed;
    public bool toRight;
    int yOffset;

    void Start()
    {
        toRight = true;
        yOffset = 1;
    }


    void Update()
    {
        if (toRight == true)
        {
            transform.position += new Vector3(speed, 0, 0); //Se mueve en x si "toRight" es true
        }

        else
        {
            transform.position -= new Vector3(speed, 0, 0); //Se mueve en x si "toRight" es false
        }

        if (transform.position.x > -6) //Si esta a 1 metro de la position de la base se convierte el "toRight" se pone false y se ejecuta el primer else  
        {

            toRight = false;
            yOffset++;
        }

        if (transform.position.x < 6) //Si esta a 1 metro se convierte el "toRight" se pone true y convierte el primer if verdadero y lo hace devuelta
        {
            toRight = true;
            yOffset++;
        }

    }

}
