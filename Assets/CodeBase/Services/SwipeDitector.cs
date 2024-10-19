using CodeBase.MyPlugins;
using UnityEngine;
public class SwipeDitector : MonoBehaviour
{
    [SerializeField] private float _minimumSwipeDistance;
    private Vector2 _fingerDownPosition;
    private Vector2 _fingerUpPosition;
    public Vector2 _swipeDirection;
    public bool _isSwiped;
    private void Update()
    {
        foreach (var touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                _fingerDownPosition = touch.position;
                _fingerUpPosition = touch.position;
                print($"Touch is beggining!");
                _isSwiped = false;
            }

            if (touch.phase == TouchPhase.Moved)
            {
                _fingerDownPosition = touch.position;
                _isSwiped = false;
                DetectSwipe();
            }

            if (touch.phase == TouchPhase.Ended)
            {
                _fingerDownPosition = touch.position;
                print($"Finger is out of screen!");
                DetectSwipe();
                _isSwiped = true;
                _swipeDirection = new Vector2(0, 0);
            }
        }
    }
    private void DetectSwipe()
    {
        if (IsMinimalSwipeDistanceAccepted())
        {
            if (IsVerticalSwipe())
            {
                var direction = _fingerDownPosition.y - _fingerUpPosition.y < 0
                    ? new Vector2(0, 1f)
                    : new Vector2(0,-1f);
                _swipeDirection = direction;
            }
            else
            {
                var direction = _fingerDownPosition.x - _fingerUpPosition.x > 0
                    ? new Vector2(1f,0)
                    : new Vector2(-1f,0);
                _swipeDirection = direction;
                DebugExtantion.WrongLog($"Direction info{direction}");
            }
        }
    }
    private bool IsVerticalSwipe()
    {
        return HorizontalSwipeValue() < VerticalSwipeValue();
    }
    private bool IsMinimalSwipeDistanceAccepted()
    {
        print(SetupSwipeSensativity.Instance._swipeSensitivity);
        return HorizontalSwipeValue() > SetupSwipeSensativity.Instance._swipeSensitivity || VerticalSwipeValue() > SetupSwipeSensativity.Instance._swipeSensitivity;
    }
    private float HorizontalSwipeValue()
    {
        return Mathf.Abs(_fingerDownPosition.x - _fingerUpPosition.x);
    }
    private float VerticalSwipeValue()
    {
        return Mathf.Abs(_fingerDownPosition.y - _fingerUpPosition.y);
    }
}
