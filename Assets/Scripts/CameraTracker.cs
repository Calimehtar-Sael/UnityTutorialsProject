using UnityEngine;

public class CameraTracker : MonoBehaviour
{
    [SerializeField] private Transform targetTransform;
    [SerializeField] private Vector3 targetPositionOffset;

    private void Update()
    {
        if(targetTransform != null)
        {
            transform.position = targetTransform.position + targetPositionOffset;
        }
    }
}
