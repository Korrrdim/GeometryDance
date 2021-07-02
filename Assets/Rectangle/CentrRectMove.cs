using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentrRectMove : MonoBehaviour
{
    [SerializeField] private Transform A, B, C, D, Bottom, Back;
    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 4.25f); //отримання координат тапу
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);                    //їх правильна трансформація
        Vector3 lastPosition = new Vector3(objPosition.x, 0.7f, objPosition.z);                 //встановлення ординати 0.7

        Vector3 lastPositionA = new Vector3(objPosition.x + BackRectMove.BackCent, 0.7f, objPosition.z - BottomRectMove.BottomCent);
        Vector3 lastPositionB = new Vector3(objPosition.x - BackRectMove.BackCent, 0.7f, objPosition.z - BottomRectMove.BottomCent);
        Vector3 lastPositionC = new Vector3(objPosition.x - BackRectMove.BackCent, 0.7f, objPosition.z + BottomRectMove.BottomCent);
        Vector3 lastPositionD = new Vector3(objPosition.x + BackRectMove.BackCent, 0.7f, objPosition.z + BottomRectMove.BottomCent);

        Vector3 lastPositionBottom = new Vector3(objPosition.x, 0.7f, objPosition.z + (-BottomRectMove.BottomCent));
        Vector3 lastPositionBack = new Vector3(objPosition.x + (-BackRectMove.BackCent), 0.7f, objPosition.z );
        transform.position = lastPosition; //зміна позиції
        A.transform.position = lastPositionA;
        B.transform.position = lastPositionB;
        C.transform.position = lastPositionC;
        D.transform.position = lastPositionD;

        Bottom.transform.position = lastPositionBottom;
        Back.transform.position = lastPositionBack;


    }
}
