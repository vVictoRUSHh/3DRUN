using System.Collections;
using CodeBase.Infrastracture;
using CodeBase.Services;
using UnityEngine;
namespace CodeBase.Player
{
    [RequireComponent(typeof(CharacterController))]
    [RequireComponent(typeof(PlayAreaLimiter))]
    public class PlayerMove : MonoBehaviour, IMovable
    {
        [SerializeField] private float _moveConst;
        [SerializeField] private float _moveDuration;
        [SerializeField] private SwipeDitector _swipeDitector;
        private CharacterController _characterController;
        private PlayAreaLimiter _playAreaLimiter;
        private IInputService _inputService;
        private void Awake()
        {
            _characterController = GetComponent<CharacterController>();
            _playAreaLimiter = GetComponent<PlayAreaLimiter>();
            _inputService = Game._inputService;
        }
        private void Update() => Move();

        public void Move()
        {
            _playAreaLimiter.LimitingPlayArea();
            if (!_swipeDitector._isSwiped)
            {
                var targetPosition = transform.position + new Vector3(_swipeDitector._swipeDirection.x * _moveConst,0,0);
                print(targetPosition);
                StartCoroutine(MoveToPosition(targetPosition, _moveDuration));
            }
        }
        private IEnumerator MoveToPosition(Vector3 target, float duration)
        {
            Vector3 startPosition = transform.position;
            float elapsedTime = 0f;

            while (elapsedTime < duration)
            {
                elapsedTime += Time.deltaTime;
                float t = Mathf.Clamp01(elapsedTime / duration);
                Vector3 newPosition = Vector3.Lerp(startPosition, target, t);
                Vector3 moveDirection = newPosition - transform.position;
                _characterController.Move(moveDirection);
                yield return null;
            }
            Vector3 finalMoveDirection = target - transform.position;
            _characterController.Move(finalMoveDirection);
        }
    }
}
