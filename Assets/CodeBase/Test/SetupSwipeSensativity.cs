
using UnityEngine;

public class SetupSwipeSensativity : MonoBehaviour
{
    private static SetupSwipeSensativity _instance;
    public float _swipeSensitivity;

    public static SetupSwipeSensativity Instance
    {
        get
        {
            if (_instance == null)
            {
                // Попробуйте найти экземпляр в сцене
                _instance = FindObjectOfType<SetupSwipeSensativity>();

                // Если экземпляр не найден, создайте новый
                if (_instance == null)
                {
                    GameObject singletonObject = new GameObject();
                    _instance = singletonObject.AddComponent<SetupSwipeSensativity>();
                    singletonObject.name = typeof(SetupSwipeSensativity).ToString() + " (Singleton)";
                }
            }
            return _instance;
        }
    }

    private void Awake()
    {
        // Убедитесь, что экземпляр единственный
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(gameObject); // Не уничтожать при загрузке новой сцены
    }

}
