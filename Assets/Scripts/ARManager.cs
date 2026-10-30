using System.Collections.Generic;
using System.IO.Pipes;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARManager : MonoBehaviour
{
    GameObject placedObject;
    Vector2 touchPos;
    [SerializeField] ARPlaneManager arPlaneMang;
    [SerializeField] ARRaycastManager rayMang;
    List<ARRaycastHit> hits = new List<ARRaycastHit>();

    bool arMode = true;
    [SerializeField] GameObject arSession;
    [SerializeField] GameObject normalModeCollection;
    [SerializeField] GameObject cloud;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (arMode)
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Began)
                    touchPos = touch.position;

                if (rayMang.Raycast(touchPos, hits, TrackableType.PlaneWithinPolygon))
                {
                    Pose hitPose = hits[0].pose;

                    if (placedObject == null)
                    {
                        placedObject = Instantiate(cloud, hitPose.position, Quaternion.identity);
                        arPlaneMang.planePrefab = null;
                    }
                    else
                    {
                        placedObject.transform.position = hitPose.position;
                    }

                }
            }
        }
    }

    public void ToggleARMode()
    {
        arMode = !arMode;
        arSession.SetActive(arMode);
        normalModeCollection.SetActive(!arMode);
    }
}
