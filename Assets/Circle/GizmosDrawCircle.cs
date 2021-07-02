using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmosDrawCircle : MonoBehaviour
{
    [SerializeField] private Transform CenterCicrle, RadiusCicrle;
    [SerializeField] private GameObject All;

    private void OnDrawGizmos()
    {
        if (BrainUI.Index == 1)
        {
            All.SetActive(true);
            Gizmos.color = Color.white;
            UnityEditor.Handles.DrawWireDisc(CenterCicrle.position, Vector3.up, RadiusMove.Radius);
            UnityEditor.Handles.DrawLine(CenterCicrle.position, RadiusCicrle.position);
        }
        else
        {
            All.SetActive(false);
        }

    }
}