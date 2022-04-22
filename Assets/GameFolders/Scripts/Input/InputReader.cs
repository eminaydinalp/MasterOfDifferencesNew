using GameFolders.Scripts.Controller;
using GameFolders.Scripts.Level;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GameFolders.Scripts.Input
{
    public class InputReader : MonoBehaviour
    {
        [SerializeField] LevelSwipe _levelSwipe;
		public bool isHeld;
        public Vector2 clickPosition;
		
		public void FirstDown(InputAction.CallbackContext action)
        {
			if (action.performed)
			{
                _levelSwipe.FirstDown();
                isHeld = true;
            }
            if (action.canceled)
			{
                isHeld = false;
			}
        }
        public void GetClickPosition(InputAction.CallbackContext callbackContext)
        {
            clickPosition = callbackContext.ReadValue<Vector2>();
            if (CollisionController.instance == null) return;
            CollisionController.instance.clickPosition = callbackContext.ReadValue<Vector2>();
        } 
        
        public void FirstDownGame(InputAction.CallbackContext action)
        {
            if (action.performed && CollisionController.instance != null)
            {
                CollisionController.instance.ClickProsess();
            }
        }
    }
}
