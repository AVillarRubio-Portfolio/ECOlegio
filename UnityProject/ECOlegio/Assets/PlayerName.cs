using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using uAdventure.Runner;

public class PlayerName : MonoBehaviour {

    string nombre_ = "";
    string apellidos_ = "";

    public GameObject nameInput_;
    public GameObject surnameInput_;
    bool activeInput_ = true;

    public GameObject nameText_;
    public GameObject surnameText_;
    bool activeText_ = false;

    public void SetName(string n) { 
        nombre_ = n;
        nameText_.GetComponent<Text>().text = nombre_;
    }

    public string GetName() { return nombre_; }

    public void SetSurname(string s) { 
        apellidos_ = s;
        surnameText_.GetComponent<Text>().text = apellidos_;
    }

    public string GetSurname() { return apellidos_; }
    void Update()
    {
        ActiveInput();
        ActiveText();
    }

    private void ActiveInput()
    {
        activeInput_ = (Game.Instance.GameState.CurrentTarget == "Menu");
        nameInput_.SetActive(activeInput_);
        surnameInput_.SetActive(activeInput_);
    }

    private void ActiveText()
    {
        activeText_ = (Game.Instance.GameState.CurrentTarget == "NotasFinales");
        nameText_.SetActive(activeText_);
        surnameText_.SetActive(activeText_);
    }
}
