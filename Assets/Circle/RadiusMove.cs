using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadiusMove : MonoBehaviour
{
    [SerializeField] private Transform CentreCicrle;
    public static float Radius = 1.0f;
    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 3.9f); //отримання координат тапу
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);                    //їх правильна трансформація
        Vector3 lastPosition = new Vector3(CentreCicrle.position.x, 0.7f, objPosition.z);                 //встановлення ординати 0.7
        transform.position = lastPosition; //зміна позиції
        Radius = CentreCicrle.position.z - transform.position.z;


    }
}
