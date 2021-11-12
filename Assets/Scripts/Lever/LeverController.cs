using UnityEngine;

public class LeverController : MonoBehaviour
{
    [SerializeField] private Transform leverXRot;
    [SerializeField] private Transform leverZRot;
    [SerializeField] private Transform affectedObject;
    [SerializeField] private float senstivity;
    
    private void Update()
    {
        Quaternion rotation = Quaternion.Euler(leverXRot.rotation.normalized.x * senstivity, 0f, 
            leverZRot.rotation.normalized.z * senstivity);
        affectedObject.rotation = rotation;
    }
}
