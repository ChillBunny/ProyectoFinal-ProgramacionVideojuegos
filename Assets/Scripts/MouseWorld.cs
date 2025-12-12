using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseWorld : MonoBehaviour
{

    private static MouseWorld instance;
    [SerializeField] private LayerMask mousePlaneLayerMask;

    private void Awake()
    {
        instance = this;

    }
    
    public static Vector3 GetMouseWorldPosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out RaycastHit hitInfo, float.MaxValue, LayerMask.GetMask("MousePlane"));
        return hitInfo.point;
    }

    
    // Update is called once per frame
    private void Update()
    {

        //Debug.Log(Input.mousePosition);
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //Debug.Log(Physics.Raycast(ray, out RaycastHit hitInfo, float.MaxValue));
        //transform.position = hitInfo.point;
        transform.position = MouseWorld.GetMouseWorldPosition();
    }

}
