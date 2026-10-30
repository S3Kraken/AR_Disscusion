using System.IO.Pipes;
using UnityEngine;

public class ARManager : MonoBehaviour
{

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

    }

    public void ToggleARMode()
    {
        arMode = !arMode;
        arSession.SetActive(arMode);
        normalModeCollection.SetActive(!arMode);
    }
}
