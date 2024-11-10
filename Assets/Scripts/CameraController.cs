using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject firstCamera;
    [SerializeField] private GameObject thirdCamera;
    public bool active;
    private void Start()
    {
        firstCamera.SetActive(active);
        thirdCamera.SetActive(!active);
        active = true;
    }
    public void CheckVersion()
    {
        if (active)
        {
            firstCamera.SetActive(!active);
            thirdCamera.SetActive(active);
            active=false;
        }
        else
        {
            thirdCamera.SetActive(active);
            firstCamera.SetActive(!active);
            active = true;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            CheckVersion();

        }
    }
}
