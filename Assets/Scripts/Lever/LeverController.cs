using UnityEngine;

public class LeverController : MonoBehaviour
{
    [SerializeField] private Transform affectedObject;
    [SerializeField] private float senstivity;
    
    private void Update()
    {
        Quaternion rotation = Quaternion.Euler(transform.rotation.normalized.x * senstivity, 0f, 0f);
        affectedObject.rotation = rotation;
    }
}
