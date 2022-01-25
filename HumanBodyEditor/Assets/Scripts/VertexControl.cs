using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VertexControl : MonoBehaviour
{
    public Slider targetSlider;
    public GameObject gameObject;

    enum BodyPart
    {
        HeadRadius,
        HeadHeight,
        NeckHeight,
        NeckThickness,
        ShoulderWidth,
        WaistWidth,
        Breast,
        Hip,
        UpperArmLength,
        UpperArmThickness,
        LowerArmLength,
        LowerArmThickness,
        UpperLegLength,
        UpperLegThickness,
        LowerLegLength,
        LowerLegThickness
    }

    private void Start()
    {
        targetSlider.onValueChanged.AddListener(delegate { OnValueChanged(targetSlider); });
    }
    public void OnValueChanged(Slider tSlider)
    {
        BodyPart bodyPart;
        Vector3[] vertices = gameObject.GetComponent<MeshFilter>().mesh.vertices;
        Mesh mesh = gameObject.GetComponent<MeshFilter>().mesh;

        Debug.Log(tSlider.name);
        int index = (int)System.Enum.Parse(typeof(BodyPart), tSlider.name);
        

        for (int i = 50*index; i < 50*index+10; i++)
        {
            vertices[i].x = UI1_Control.baseVertices[i].x + tSlider.value / 10;
            vertices[i].y = UI1_Control.baseVertices[i].y + tSlider.value / 10;
            vertices[i].z = UI1_Control.baseVertices[i].z + tSlider.value / 10;
        }
        // UI1_Control.baseVertices = vertices;
        gameObject.GetComponent<MeshFilter>().mesh.vertices = vertices;
    }
}
