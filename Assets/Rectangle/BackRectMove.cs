using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackRectMove : MonoBehaviour
{
    [SerializeField] private Transform A, B, C, D, Center, Bottom;
    public static float BackCent = 0.5f;
    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 4.25f); //��������� ��������� ����
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);                    //�� ��������� �������������
        Vector3 lastPosition = new Vector3(objPosition.x, 0.7f, Center.position.z);                 //������������ �������� 0.7

        BackCent = Center.position.x - transform.position.x;//�������� �� ���� �� �����

        Vector3 lastPositionA = new Vector3(Center.position.x + BackCent, 0.7f, Center.position.z - BottomRectMove.BottomCent);
        Vector3 lastPositionB = new Vector3(Center.position.x - BackCent, 0.7f, Center.position.z - BottomRectMove.BottomCent);
        Vector3 lastPositionC = new Vector3(Center.position.x - BackCent, 0.7f, Center.position.z + BottomRectMove.BottomCent);
        Vector3 lastPositionD = new Vector3(Center.position.x + BackCent, 0.7f, Center.position.z + BottomRectMove.BottomCent);

        Vector3 lastPositionBottom = new Vector3(objPosition.x, 0.7f, objPosition.z + (-BottomRectMove.BottomCent));
        transform.position = lastPosition; //���� �������

        A.transform.position = lastPositionA;
        B.transform.position = lastPositionB;
        C.transform.position = lastPositionC;
        D.transform.position = lastPositionD;


    }
}
