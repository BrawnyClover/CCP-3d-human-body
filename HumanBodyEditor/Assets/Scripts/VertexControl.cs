using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VertexControl : MonoBehaviour
{
    public Slider testSlider;
    public GameObject gameObject;

    private Vector3[] baseVertices;

    // Start is called before the first frame update
    void Start()
    {
        print("Renderer Å©±â:" + gameObject.GetComponent<Renderer>().bounds.size);     // (10.0, 0.0, 10.0)
        baseVertices = gameObject.GetComponent<MeshFilter>().mesh.vertices;

        for (int i = 0; i < baseVertices.Length; i++)
        {
            print("Vertices[" + i + "]:" + baseVertices[i].x + "," + baseVertices[i].y + "," + baseVertices[i].z);
        }
    }

    public void OnValueChanged()
    {
        Vector3[] vertices = gameObject.GetComponent<MeshFilter>().mesh.vertices;
        for (int i = 0; i < 10; i++)
        {
            vertices[i].x = baseVertices[i].x + testSlider.value / 10;
            vertices[i].y = baseVertices[i].y + testSlider.value / 10;
            vertices[i].z = baseVertices[i].z + testSlider.value / 10;
        }
        gameObject.GetComponent<MeshFilter>().mesh.vertices = vertices;
    }

    // Update is called once per frame
    void Update()
    {
        OnValueChanged();
    }
}
