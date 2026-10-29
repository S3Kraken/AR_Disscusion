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
        if (Input.touchCount == 0)
            return;

        Touch touch = Input.GetTouch(0);

        if (touch.phase == TouchPhase.Moved)
        {
            float rotationAmount = touch.deltaPosition.x * 5f;
            transform.Rotate(Vector3.up, rotationAmount, Space.Self);
        }
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
