using UnityEngine;

public class AddBuildings : MonoBehaviour
{
    public GameObject buildingPrefab; // Prefab to use for buildings

    // Start is called before the first frame update
    void Start()
    {
        for (int x = -50; x < 50; x += 20)
        {
            Instantiate(buildingPrefab, new Vector3(x, 0, -4), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
