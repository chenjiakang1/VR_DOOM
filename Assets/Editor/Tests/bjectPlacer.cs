using UnityEngine;

public class ObjectPlacer : MonoBehaviour
{
    public GameObject prefabToPlace;
    public LayerMask groundLayer;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, 100f, groundLayer))
            {
                Instantiate(prefabToPlace, hit.point, Quaternion.identity);
            }
        }
    }
}
