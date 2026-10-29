using System.IO.Pipes;
using UnityEngine;

public class ARManager : MonoBehaviour
{

    bool animate;
    bool arMode = true;
    [SerializeField] GameObject arSession;
    [SerializeField] GameObject normalModeCollection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleRot();
    }

    private void HandleRot()
    {
        //if (Input.touchCount == 1) // If one finger touches screen.
        //{
        //    Touch touch = Input.GetTouch(0);

        //    if (touch.phase == TouchPhase.Began)
        //    {
        //        dragStartPos = touch.position;
        //    }
        //    else if (touch.phase == TouchPhase.Ended)
        //    {
        //        dragEndPos = touch.position;


        //        Vector2 delta = dragEndPos - dragStartPos;

        //        if (delta.magnitude < 0.1f)
        //        {
        //            return SwipeDirection.None;
        //        }

        //        if (Mathf.Abs(delta.x) > Mathf.Abs(delta.y))
        //        {
        //            if (delta.x > 0)
        //                return SwipeDirection.Right;
        //            else
        //                return SwipeDirection.Left;
        //        }
        //        else
        //        {
        //            if (delta.y > 0)
        //                return SwipeDirection.Up;
        //            else
        //                return SwipeDirection.Down;
        //        }
        //    }
        //}
        //return SwipeDirection.None;
    }

    public void ToggleAnimation()
    {
        animate = !animate;
    }

    public void ToggleARMode()
    {
        arMode = !arMode;
        arSession.SetActive(arMode);
        normalModeCollection.SetActive(!arMode);
    }
}
