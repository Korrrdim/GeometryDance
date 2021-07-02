using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmosDrawRectangle : MonoBehaviour
{
    [SerializeField] private Transform A, B, C, D;
    [SerializeField] private GameObject All;
    private void OnDrawGizmos()
    {
        if (BrainUI.Index == 2)
        {
            All.SetActive(true);
            Gizmos.color = Color.white;
            UnityEditor.Handles.DrawLine(A.position, B.position);
            UnityEditor.Handles.DrawLine(B.position, C.position);
            UnityEditor.Handles.DrawLine(C.position, D.position);
            UnityEditor.Handles.DrawLine(D.position, A.position);
        }
        else
        {
            All.SetActive(false);
        }

    }
}
