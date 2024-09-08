using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooksDetails : MonoBehaviour
{
    public GameObject detailsUSA;
    public GameObject detailsCanada;
    public GameObject detailsSurCorea;
    public GameObject detailsJapon;
    public GameObject detailsAlemania;
    public GameObject detailsUK;
    public GameObject detailsFrancia;
    public GameObject detailsSpain;
    public GameObject detailsItalia;
    public GameObject detailsAustralia;
    
    public void HideAll(){
        detailsUSA.SetActive(false);
        detailsCanada.SetActive(false);
        detailsSurCorea.SetActive(false);
        detailsJapon.SetActive(false);
        detailsAlemania.SetActive(false);
        detailsUK.SetActive(false);
        detailsSpain.SetActive(false);
        detailsItalia.SetActive(false);
        detailsAustralia.SetActive(false);
        detailsFrancia.SetActive(false);
    }

    public void ShowUSA(){
        detailsUSA.SetActive(true);
    }
    public void ShowCanada(){
        detailsCanada.SetActive(true);
    }
    public void ShowKorea(){
        detailsSurCorea.SetActive(true);
    }
    public void ShowJapon(){
        detailsJapon.SetActive(true);
    }
    public void ShowAlemania(){
        detailsAlemania.SetActive(true);
    }
    public void ShowUK(){
        detailsUK.SetActive(true);
    }
    public void ShowSpain(){
        detailsSpain.SetActive(true);
    }
    public void ShowItalia(){
        detailsItalia.SetActive(true);
    }
    public void ShowAustralia(){
        detailsAustralia.SetActive(true);
    }
    public void ShowFrancia(){
        detailsFrancia.SetActive(true);
    }
}
