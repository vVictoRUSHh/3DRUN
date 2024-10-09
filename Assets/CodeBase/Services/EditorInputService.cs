using UnityEngine;

namespace CodeBase.Services
{
    public class EditorInputService : IInputService
    {
        private const string HORIZONTAL_AXIS = "Horizontal";
        private const string VERTICAL_AXIS = "Vertical";
        public Vector2 Axis => new(Input.GetAxis(HORIZONTAL_AXIS), Input.GetAxis(VERTICAL_AXIS));
        public bool isMovingLeft()
        {
            return Input.GetKeyUp(KeyCode.A);
        }

        public bool isMovingRight()
        {
            return Input.GetKeyUp(KeyCode.D);
        }
    }
}