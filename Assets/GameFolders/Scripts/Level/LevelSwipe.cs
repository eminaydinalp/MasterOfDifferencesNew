using GameFolders.Scripts.Input;
using GameFolders.Scripts.Manager;
using UnityEngine;

namespace GameFolders.Scripts.Level
{
	public class LevelSwipe : MonoBehaviour
	{
        [SerializeField] InputReader _inputReader;
        [SerializeField] GameObject swipeLevel;

        Vector2 _clickPosition;
        float _startPosY;

        private void Update()
		{
            if (_inputReader.isHeld && GameManager.instance.isMapActive)
            {
                HeldProcess();
            }
        }
		private RaycastHit2D ThrowRay()
        {
            this._clickPosition = _inputReader.clickPosition;
            this._clickPosition = Camera.main.ScreenToWorldPoint(_clickPosition);

            return Physics2D.Raycast(_clickPosition, Vector3.back, Mathf.Infinity);
        }

        public void HeldProcess()
        {
            RaycastHit2D raycastHit = ThrowRay();
            if (raycastHit.transform == null) return;
            if (raycastHit.transform.CompareTag("Background"))
            {
                //this.clickPosition.y = Mathf.Clamp(this.clickPosition.y, -20f, -3.5f);
                swipeLevel.transform.position = new Vector3(transform.position.x, this._clickPosition.y - _startPosY, transform.position.z);
                if (swipeLevel.transform.position.y > -3.5f) swipeLevel.transform.position = new Vector3(transform.position.x, -3.5f, transform.position.z);
                if (swipeLevel.transform.position.y < -52f) swipeLevel.transform.position = new Vector3(transform.position.x, -52f, transform.position.z);
            }
        }

        public void FirstDown()
		{
            this._clickPosition = _inputReader.clickPosition;
            this._clickPosition = Camera.main.ScreenToWorldPoint(_clickPosition);

            _startPosY = _clickPosition.y - swipeLevel.transform.position.y;
        }
    }
}

