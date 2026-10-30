using UnityEngine;

public class Cloud : MonoBehaviour
{
    static bool animate = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HandleRot();
    }

    public void ToggleAnimation()
    {
        animate = !animate;

        Animation[] animations = FindObjectsByType<Animation>(
        FindObjectsInactive.Include,
        FindObjectsSortMode.None
          );

        foreach (Animation anim in animations)
        {
            anim.wrapMode = WrapMode.Loop;
            foreach (AnimationState state in anim)
            {
                state.speed = animate ? 1f : 0f;
            }
        }
    }


    private void HandleRot()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                float rotationAmount = touch.deltaPosition.x * 1f;
                this.transform.Rotate(Vector3.up, rotationAmount, Space.Self);
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(Vector3.up, 1f, Space.Self);
        }
    }
}
