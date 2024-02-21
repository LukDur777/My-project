using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.position += new Vector3(1, 0, 0) * Time.deltaTime ;
        //mozna prosciej: Vector3.right


        //zczytaj klawiature w osi poziomej:
        float x = Input.GetAxis("Horizontal");
        //wyswietl w konsoli stan klawiatury
        Debug.Log(x);

        //wylicz przesuniecie w osi x
        Vector3 movement = Vector3.right * x;

        //zczytaj z klawiatury os y
        float y = Input.GetAxis("Vertical");

        //wylicz przesuniecie w osi y i dodaj do istniejacego przesuniecia w osi x
        
        movement += Vector3.forward * y;

        //normalizujemy wektor
        movement = movement.normalized;

        //poprawka ba czas ostatniej klatki
        movement *= Time.deltaTime;

        //pomnoz przez predkosc ruchu
        movement *= moveSpeed;

        //przesun gracza w osi x
        transform.position += movement;
        

        //probujemy uzyc translateaa



       
    }
}
