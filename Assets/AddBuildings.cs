using TMPro;
using UnityEngine;

public class AddBuildings : MonoBehaviour
{
    public GameObject buildingPrefab; // Prefab to use for buildings

    // Start is called before the first frame update
    void Start()
    {
        string[] companies = { "NVIDIA", "ARM", "Samsung", "Intel" };

        // iterate over each company and create a building
        int x = 0;
        foreach (string company in companies)
        {
            GameObject building = Instantiate(buildingPrefab, new Vector3((float)(146.3 + x), (float)21.5, (float)112.3), Quaternion.identity);
            TMP_Text nameholder = building.GetComponentInChildren<TMP_Text>();
            nameholder.text = company;
            x += 20;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
