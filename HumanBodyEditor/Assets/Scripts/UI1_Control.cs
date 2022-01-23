using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI1_Control : MonoBehaviour
{
    public GameObject maleBody;
    public GameObject femaleBody;

    public Material mat1;
    public Material mat2;

    private bool materialFlag = false;

    public void OnClickToggleMesh()
    {
        if (materialFlag)
        {
            maleBody.GetComponent<MeshRenderer>().material = mat1;
            femaleBody.GetComponent<MeshRenderer>().material = mat1;
        }
        else
        {
            maleBody.GetComponent<MeshRenderer>().material = mat2;
            femaleBody.GetComponent<MeshRenderer>().material = mat2;
        }
        materialFlag = !materialFlag;
        Debug.Log(maleBody.GetComponent<MeshRenderer>().material);
    }
}
