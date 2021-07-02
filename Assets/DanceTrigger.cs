using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceTrigger : MonoBehaviour
{

    [SerializeField] private Transform CentreCicrle;

    [SerializeField] private Transform A, B, C, D, Center, Bottom;
    /*private float SRectangle,SAll;  //***************ГЕРОН***************
    private float AD, AB, AP, CP, DP, BP;
    private float cpb_p, cpd_p, apd_p, bpd_p;
    private float cpb_S, cpd_S, apd_S, bpd_S;*/

    [SerializeField] private Transform ATri, BTri, CTri;
    private float a, b, c;

    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        switch (BrainUI.Index)
        {
            case 1: 
                {
                    //круг
                    if ((Mathf.Pow((this.transform.position.x - CentreCicrle.position.x), 2f) + Mathf.Pow((this.transform.position.z - CentreCicrle.position.z), 2f)) <= Mathf.Pow(RadiusMove.Radius, 2f))
                    {
                        animator.SetBool("Dance", true);

                    }
                    else
                    {
                        animator.SetBool("Dance", false);
                    }
                }
                break;
            case 2: 
                {
                    //пярмоугольник
                    if (transform.position.x <= A.position.x && transform.position.x >= B.position.x && transform.position.z >= B.position.z && transform.position.z <= C.position.z)//после отработки мозга геороном я сделал это.
                    {
                        animator.SetBool("Dance", true);
                    }
                    else
                    {
                        animator.SetBool("Dance", false);
                    }
                }
                break;
            case 3:
                {
                    //треугольник
                    a = (ATri.position.x - this.transform.position.x) * (BTri.position.z - ATri.position.z) - (BTri.position.x - ATri.position.x) * (ATri.position.z - this.transform.position.z);
                    b = (BTri.position.x - this.transform.position.x) * (CTri.position.z - BTri.position.z) - (CTri.position.x - BTri.position.x) * (BTri.position.z - this.transform.position.z);
                    c = (CTri.position.x - this.transform.position.x) * (ATri.position.z - CTri.position.z) - (ATri.position.x - CTri.position.x) * (CTri.position.z - this.transform.position.z);
                    if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))
                    {
                        animator.SetBool("Dance", true);
                    }
                    else
                    {
                        animator.SetBool("Dance", false);
                    }
                }
                break;
            case 0: { }break;
        }



        //***************ГЕРОН***************

        /*AD = (Mathf.Sqrt(Mathf.Pow((A.position.x - D.position.x), 2f))) + (Mathf.Pow((A.position.z - D.position.z), 2f));//CB
        AB = (Mathf.Sqrt(Mathf.Pow((A.position.x - B.position.x), 2f)) + (Mathf.Pow((A.position.z - B.position.z), 2f)));//CD
        SRectangle = AD * AB;

        AP = (Mathf.Sqrt(Mathf.Pow((A.position.x - transform.position.x), 2f))) + (Mathf.Pow((A.position.z - transform.position.z), 2f));
        CP = (Mathf.Sqrt(Mathf.Pow((C.position.x - transform.position.x), 2f))) + (Mathf.Pow((C.position.z - transform.position.z), 2f));
        DP = (Mathf.Sqrt(Mathf.Pow((D.position.x - transform.position.x), 2f))) + (Mathf.Pow((D.position.z - transform.position.z), 2f));
        BP = (Mathf.Sqrt(Mathf.Pow((B.position.x - transform.position.x), 2f))) + (Mathf.Pow((B.position.z - transform.position.z), 2f));
        //CPB
        cpb_p = (AD + CP + BP) / 2;
        cpb_S = (Mathf.Sqrt((cpb_p * (cpb_p - AD) * (cpb_p - CP) * (cpb_p - BP))));
        //CPD
        cpd_p = (AB + CP + DP) / 2;
        cpd_S = (Mathf.Sqrt(cpd_p * (cpd_p - AB) * (cpd_p - CP) * (cpd_p - DP)));
        //DPA
        apd_p = (AD + DP + AP) / 2;
        apd_S = (Mathf.Sqrt((cpd_p * (apd_p - AD) * (apd_p - DP) * (apd_p - AP))));
        //BPA
        bpd_p = (AB + AP + BP) / 2;
        bpd_S = (Mathf.Sqrt(bpd_p * (bpd_p - AB) * (bpd_p - AP) * (bpd_p - BP)));
        SAll = cpb_S + cpd_S + apd_S + bpd_S;
        if (SRectangle >= SAll - 0.3f && SRectangle <= SRectangle + -0.3f)
        {
            animator.SetBool("Dance", true);
        }
        else
        {
            animator.SetBool("Dance", false);
        }*/

        //***************ГЕРОН***************





    }
}
