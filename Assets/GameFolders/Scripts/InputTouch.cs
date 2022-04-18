using UnityEngine;

public abstract class InputTouch : MonoBehaviour
{
    protected Input _input;

    private void Awake()
    {
        _input = new Input();
    }

    private void Start()
    {
        _input.Genel.Click.started += context =>
        {
            OnFirstTouchDown();
        };
    }

    private void OnEnable()
    {
        _input.Enable();
    }

    private void OnDisable()
    {
        _input.Disable();
    }
    
    protected abstract void OnFirstTouchDown();
    
    protected virtual Vector2 GetFirstClickPosition()
    {
        return _input.Genel.ClickPosition.ReadValue<Vector2>();
    }
}
