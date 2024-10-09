using System.Collections;
using CodeBase.Infrastracture;
using CodeBase.Services;
using UnityEngine;
namespace CodeBase.Player
{
    [RequireComponent(typeof(PlayAreaLimiter))]
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMove : MonoBehaviour, IMovable
    {
        [SerializeField] private Rigidbody _rb;
        [SerializeField] private float _moveConst;
        [SerializeField] private float _moveDuration;
        [SerializeField] private PlayAreaLimiter _playAreaLimiter;
        private IInputService _inputService;
        private void Awake() => _inputService = Game._inputService;
        private void FixedUpdate() => Move();
        public void Move()
        {
            var direction = _inputService.isMovingRight() ? 1 : _inputService.isMovingLeft() ? -1 : 0;
            _playAreaLimiter.LimitingPlayArea();
            if (direction != 0 )
            {
                var targetPosition = transform.position + new Vector3(direction * _moveConst, 0, 0);
                StartCoroutine(MoveToPosition(targetPosition, _moveDuration));
            }
        }
        private IEnumerator MoveToPosition(Vector3 target, float duration)
        {
            Vector3 startPosition = transform.position;
            float elapsedTime = 0f;

            while (elapsedTime < duration)
            {
                float t = elapsedTime / duration;
                Vector3 newPosition = Vector3.Lerp(startPosition, target, t);
                _rb.MovePosition(newPosition); // Используем Rigidbody для перемещения
                elapsedTime += Time.deltaTime;
                yield return null;
            }
            _rb.MovePosition(target); // Убедитесь, что объект точно достиг целевой позиции
        }
    }
}