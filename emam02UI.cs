using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class emam02UI : MonoBehaviour
{
    [SerializeField] Button mBtnTest02;
    [SerializeField] Button btnDrawLine;

    // Start is called before the first frame update
    void Start()
    {
        mBtnTest02.onClick.AddListener(
            () => 
            {
                Debug.Log("Test02");

                GameObject triangle = new GameObject("triangle02");
            }
        );

        btnDrawLine.onClick.AddListener(
            () => {
                GameObject lineObj = new GameObject("line_object");

                LineRenderer lineRenderer = lineObj.AddComponent<LineRenderer>();

                int pointCount = 2;
                Vector3[] points = new Vector3[2];

                points[0] = new Vector3(0,0,0);
                points [1] = new Vector3(5,0,0);

                lineRenderer.positionCount = pointCount;
                lineRenderer.SetPositions(points);
                lineRenderer.startWidth = 0.05f;

                lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
                lineRenderer.material.color = Color.red;


            }
        );

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
