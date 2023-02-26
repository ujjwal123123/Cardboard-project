using TMPro;
using UnityEngine;

public class AddBuildings : MonoBehaviour
{
    public GameObject buildingPrefab1; // Prefab to use for buildings
    public GameObject buildingPrefab2; // Prefab to use for buildings
    public GameObject buildingPrefab3; // Prefab to use for buildings
    public GameObject buildingPrefab4; // Prefab to use for buildings

    int saneMod(int x, int m)
    {
        // https://stackoverflow.com/a/51018529/11659427
        int r = x % m;
        return r < 0 ? r + m : r;
    }

    // Start is called before the first frame update
    void Start()
    {
        string[] companies = { "NVIDIA", "ARM", "Samsung", "Intel" };
        GameObject[] buildings = { buildingPrefab1, buildingPrefab2, buildingPrefab3, buildingPrefab4 };

        // iterate over each company and create a building
        int x = 0;
        foreach (string company in companies)
        {
            int buildingIndex = saneMod(company.GetHashCode(), buildings.Length);
            GameObject building = Instantiate(buildings[buildingIndex], new Vector3((float)(80 + x), 0, 140), Quaternion.identity);
            // TMP_Text nameholder = building.GetComponentInChildren<TMP_Text>();
            // nameholder.text = company;
            x += 40;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
