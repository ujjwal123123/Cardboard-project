using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AddCompanyName : MonoBehaviour
{
    public string companyName = "Microsoft";

    // Start is called before the first frame update
    void Start()
    {
        // find textMesh Pro in the children of the building
        TMP_Text text = GetComponentInChildren<TMP_Text>();
        Debug.Log("Debug " + "Text: " + text.text);
        text.text = companyName;

        // GameObject text = GameObject.Find("/Building1/Text");
        // // TextMesh[] texts = text.GetComponentsInChildren<TextMesh>();
        // // Debug.Log(texts.Length);
        // // text.GetComponent<TextMesh>().text = companyName;
        // Debug.Log("Debug " + "Company Name: " + companyName);
        // Debug.Log("Debug " + "Text: " + text.GetComponent<TextMesh>().text);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
