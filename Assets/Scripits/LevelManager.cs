using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update

    public float timeLeft = 90f;

    //elementy UI

    public GameObject timeCounter;
    public GameObject gameOverOverlay;
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

        timeCounter.GetComponent<TextMeshProUGUI>().text = "Pozost³y zas:" + Mathf.Floor(timeLeft).ToString();

        if (timeLeft <= 0)
            gameOverOverlay.SetActive(true);
    }
    public void OnWin()
    {
        //zwyciestwo
        gameOverOverlay.SetActive(true);
        gameOverOverlay.transform.Find("TextReason").GetComponent<TextMeshProUGUI>().text = "Wygrales!";

    }
    public void OnLose()
    {
        //porazka
        gameOverOverlay.SetActive(true);
        gameOverOverlay.transform.Find("TextReason").GetComponent<TextMeshProUGUI>().text = "Kamera cie zobaczyla!";
    }
}