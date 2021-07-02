using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMove : MonoBehaviour
{
    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 4.25f); //��������� ��������� ����
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);                    //�� ��������� �������������
        Vector3 lastPosition = new Vector3(objPosition.x, 0.7f, objPosition.z);                 //������������ �������� 0.7
        Vector3 lastPositionRadius = new Vector3(objPosition.x, 0.7f, objPosition.z - RadiusMove.Radius); //���� ������� ������� ������
        transform.position = lastPosition; //���� �������
    }
}
