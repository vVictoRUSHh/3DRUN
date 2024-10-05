using CodeBase.Infrastracture;
using CodeBase.SaveSystemDir;
using CodeBase.Services;
using UnityEngine;
namespace CodeBase.Player
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMove : MonoBehaviour, IMovable
    {
        [SerializeField] private Rigidbody _rb;
        [SerializeField] private float _speed;
        private IInputService _inputService;
        private void Awake() => _inputService = Game._inputService;
        private void Update() => Move();
        public void Move()
        {
            Vector3 moveVector = new Vector3(_inputService.Axis.x, 0, _inputService.Axis.y) *
                                 _speed * Time.deltaTime;
            if (moveVector.magnitude > 0)
            {
                _rb.MovePosition(_rb.position + moveVector);
                Vector3 forwardDirection =
                    new Vector3(_inputService.Axis.x, 0, _inputService.Axis.y).normalized;
                if (forwardDirection != Vector3.zero)
                {
                    Quaternion targetRotation = Quaternion.LookRotation(forwardDirection);
                    _rb.rotation = Quaternion.Slerp(_rb.rotation, targetRotation, Time.deltaTime * 10f);
                }
            }
        }
    }
}