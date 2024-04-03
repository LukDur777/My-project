using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update

    public float timeLeft = 90f;

    //elementy UI

    public GameObject timeCounter;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //zmniejsz ilosc czasu pozostalego na wykonanie poziomu
        //o czas, ktory minal od ostatniej klatki
        timeLeft -= Time.deltaTime;



        //aktualizuj UI
        UpdateUI();
    }

    void UpdateUI()
    {
        //funkcja odpowiedzialna za aktualizacje interfejsu uzytkownika

        timeCounter.GetComponent<TextMeshProUGUI>().text = "Pozost³y zas:" + Mathf.Floor(timeLeft).ToString();}
}
