using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Camera camera;
    [SerializeField] Vector3 initialPosition;
    [SerializeField] float initialSize;
    [SerializeField] Vector3 USAPosition;
    [SerializeField] float USASize;
    [SerializeField] Vector3 CanadaPosition;
    [SerializeField] float CanadaSize;
    [SerializeField] Vector3 SpainPosition;
    [SerializeField] float SpainSize;
    [SerializeField] Vector3 FrancePosition;
    [SerializeField] float FranceSize;
    [SerializeField] Vector3 UKPosition;
    [SerializeField] float UKSize;
    [SerializeField] Vector3 ItaliPosition;
    [SerializeField] float ItaliSize;
    [SerializeField] Vector3 GermanyPosition;
    [SerializeField] float GermanySize;
    [SerializeField] Vector3 KoreaPosition;
    [SerializeField] float KoreaSize;
    [SerializeField] Vector3 JapanPosition;
    [SerializeField] float JapanSize;
    [SerializeField] Vector3 AustraliaPosition;
    [SerializeField] float AustraliaSize;
    

    public void GoToInitial(){
        LeanTween.move(camera.gameObject, initialPosition, 1f);
        float r = camera.orthographicSize;
        LeanTween.value(r, initialSize, 1f).setOnUpdate((float val) => {
            camera.orthographicSize = val;
        });
    }

    public void GoToUsa(){
        LeanTween.move(camera.gameObject, USAPosition, 1f);
        float r = camera.orthographicSize;
        LeanTween.value(r, USASize, 1f).setOnUpdate((float val) => {
            camera.orthographicSize = val;
        });
    }
    public void GoToCanada(){
        LeanTween.move(camera.gameObject, CanadaPosition, 1f);
        float r = camera.orthographicSize;
        LeanTween.value(r, CanadaSize, 1f).setOnUpdate((float val) => {
            camera.orthographicSize = val;
        });
    }
        public void GoToSpain(){
        LeanTween.move(camera.gameObject, SpainPosition, 1f);
        float r = camera.orthographicSize;
        LeanTween.value(r, SpainSize, 1f).setOnUpdate((float val) => {
            camera.orthographicSize = val;
        });
    }
        public void GoToFrance(){
        LeanTween.move(camera.gameObject, FrancePosition, 1f);
        float r = camera.orthographicSize;
        LeanTween.value(r, FranceSize, 1f).setOnUpdate((float val) => {
            camera.orthographicSize = val;
        });
    }
        public void GoToUK(){
        LeanTween.move(camera.gameObject, UKPosition, 1f);
        float r = camera.orthographicSize;
        LeanTween.value(r, UKSize, 1f).setOnUpdate((float val) => {
            camera.orthographicSize = val;
        });
    }
        public void GoToItalia(){
        LeanTween.move(camera.gameObject, ItaliPosition, 1f);
        float r = camera.orthographicSize;
        LeanTween.value(r, ItaliSize, 1f).setOnUpdate((float val) => {
            camera.orthographicSize = val;
        });
    }
        public void GoToGermany(){
        LeanTween.move(camera.gameObject, GermanyPosition, 1f);
        float r = camera.orthographicSize;
        LeanTween.value(r, GermanySize, 1f).setOnUpdate((float val) => {
            camera.orthographicSize = val;
        });
    }
        public void GoToKorea(){
        LeanTween.move(camera.gameObject, KoreaPosition, 1f);
        float r = camera.orthographicSize;
        LeanTween.value(r, KoreaSize, 1f).setOnUpdate((float val) => {
            camera.orthographicSize = val;
        });
    }
        public void GoToJapan(){
        LeanTween.move(camera.gameObject, JapanPosition, 1f);
        float r = camera.orthographicSize;
        LeanTween.value(r, JapanSize, 1f).setOnUpdate((float val) => {
            camera.orthographicSize = val;
        });
    }
        public void GoToAustralia(){
        LeanTween.move(camera.gameObject, AustraliaPosition, 1f);
        float r = camera.orthographicSize;
        LeanTween.value(r, AustraliaSize, 1f).setOnUpdate((float val) => {
            camera.orthographicSize = val;
        });
    }
}
