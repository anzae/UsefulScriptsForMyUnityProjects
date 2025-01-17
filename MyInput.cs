using UnityEngine;
using UnityEngine.InputSystem;

public class MyInput : MonoBehaviour
{
    public static MyInput Instance;

    // reference to Actions class, auto generated by Input Manager Asset
    private Actions controls;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        controls = new Actions();
    }

    private void OnEnable()
    {
        if (controls == null)
        {
            Debug.LogError("Controls is not initialized. Make sure to instantiate the class in Awake.");
            return;
        }
        controls.Enable();
    }

    private void OnDisable()
    {
        if (controls == null)
        {
            Debug.LogError("Controls is not initialized. Make sure to instantiate the class in Awake.");
            return;
        }
        controls.Disable();
    }

    public float GetX()
    {
        return controls.Player.X.ReadValue<float>();
    }

    public float GetY()
    {
        return controls.Player.Y.ReadValue<float>();
    }

    public float GetZ()
    {
        return controls.Player.Z.ReadValue<float>();
    }

    public float GetRx()
    {
        return controls.Player.Rx.ReadValue<float>();
    }

    public float GetRy()
    {
        return controls.Player.Ry.ReadValue<float>();
    }

    public float GetRz()
    {
        return controls.Player.Rz.ReadValue<float>();
    }
}
