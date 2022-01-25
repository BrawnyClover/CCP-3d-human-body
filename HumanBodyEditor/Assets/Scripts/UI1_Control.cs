using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI1_Control : MonoBehaviour
{
    public GameObject targetBody;

    public Material mat1;
    public Material mat2;

    static public Vector3[] baseVertices;

    private bool materialFlag = false;

    private void Start()
    {
        baseVertices = targetBody.GetComponent<MeshFilter>().mesh.vertices;
        Debug.Log("initialized base Verticies");
    }

    public void OnClickToggleMesh()
    {
        if (materialFlag)
        {
            targetBody.GetComponent<MeshRenderer>().material = mat2;
            }
        else
        {
            targetBody.GetComponent<MeshRenderer>().material = mat1;
            }
        materialFlag = !materialFlag;
        Debug.Log(targetBody.GetComponent<MeshRenderer>().material);
    }

}
