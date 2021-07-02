using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmosDrawTriangle : MonoBehaviour
{
    [SerializeField] private Transform ATri, BTri, CTri;
    [SerializeField] private GameObject All;
    private void OnDrawGizmos()
    {
        if (BrainUI.Index == 3)
        {
            All.SetActive(true);
            Gizmos.color = Color.white;
            UnityEditor.Handles.DrawLine(ATri.position, BTri.position);
            UnityEditor.Handles.DrawLine(BTri.position, CTri.position);
            UnityEditor.Handles.DrawLine(CTri.position, ATri.position);
        }
        else
        {
            All.SetActive(false);
        }
    }
}
