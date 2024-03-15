using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    Button mBtnTest01;


    // Start is called before the first frame update
    void Start()
    {
        mBtnTest01.onClick.AddListener(
            () =>
            {
                Debug.Log("Test1");

                GameObject triangle = new GameObject("triangle");
            }

            );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
