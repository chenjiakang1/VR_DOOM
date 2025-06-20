
using UnityEngine;

public class RandomizeTransform : MonoBehaviour
{
    [Header("旋转随机化")]
    public bool randomRotation = true;
    public Vector3 rotationRange = new Vector3(0, 360, 0);

    [Header("缩放随机化")]
    public bool randomScale = true;
    public Vector2 scaleRange = new Vector2(0.8f, 1.2f);

    void Start()
    {
        if (randomRotation)
        {
            transform.rotation = Quaternion.Euler(
                Random.Range(-rotationRange.x, rotationRange.x),
                Random.Range(-rotationRange.y, rotationRange.y),
                Random.Range(-rotationRange.z, rotationRange.z)
            );
        }

        if (randomScale)
        {
            float scale = Random.Range(scaleRange.x, scaleRange.y);
            transform.localScale *= scale;
        }
    }
}