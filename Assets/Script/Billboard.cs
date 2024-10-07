using UnityEngine;

public class Billboard : MonoBehaviour
{
    void Update()
    {
        Camera mainCamera = Camera.main;

        Vector3 direction = mainCamera.transform.position - transform.position;

        direction.y = 0;

        transform.rotation = Quaternion.LookRotation(direction);
    }
}
