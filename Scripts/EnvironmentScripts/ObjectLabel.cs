using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class ObjectLabel : MonoBehaviour
{
    public ObjectInfo objectInfo;


    //GlobalSettings globalSettings;

    public TextMeshPro object_label;

    public float textDuration = 5f;

    public float yoffset = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //   globalSettings = GameObject.FindGameObjectWithTag("Global_Settings").GetComponent<GlobalSettings>();

        TextMeshPro textMeshProInstance = Instantiate(object_label);
        textMeshProInstance.transform.SetParent(this.transform);
        textMeshProInstance.transform.position = gameObject.transform.position;
        textMeshProInstance.transform.position += new Vector3(0, yoffset, 0);

        object_label = textMeshProInstance;

        object_label.text = objectInfo.titleName;
        object_label.enabled = false;


    }

    void ShowText()
    {
        // Show the text
        object_label.enabled = true;
        Invoke("HideText", textDuration);
    }

    void HideText()
    {
        // Hide the text after 5 seconds
        object_label.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ShowText();
        }
        
    }
}