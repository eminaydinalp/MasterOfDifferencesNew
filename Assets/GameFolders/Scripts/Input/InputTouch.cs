using UnityEngine;

namespace GameFolders.Scripts.Input
{
    public abstract class InputTouch : MonoBehaviour
    {
        protected global::Input _input;

        private void Awake()
        {
            _input = new global::Input();
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
}
