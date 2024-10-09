using UnityEngine;

namespace CodeBase.Services
{
    public class MobileInputService : IInputService
    {
        private const string HORIZONTAL_AXIS = "Horizontal";
        private const string VERTICAL_AXIS = "Vertical";
        public Vector2 Axis => new(SimpleInput.GetAxis(HORIZONTAL_AXIS), SimpleInput.GetAxis(VERTICAL_AXIS));
        public bool isMovingLeft()
        {
            throw new System.NotImplementedException();
        }

        public bool isMovingRight()
        {
            throw new System.NotImplementedException();
        }
    }
}