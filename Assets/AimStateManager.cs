using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemaschine;

public class AimStateManager : MonoBehaviour
{
    public Cinemaschine.AxisState xAxis, yAxis;
    [SerializeField] Transform cameraFollowPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xAxis.Update(Time.deltaTime);
        yAxis.Update(Time.deltaTime);
    }

    private void LateUpdate()
    {
        cameraFollowPosition.localEulerAngles = new Vector3(yAxis.Value, cameraFollowPosition.localEulerAngles.y, cameraFollowPosition.localEulerAngles.z);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, xAxis.Value, transform.eulerAngles.z);

    }
}
