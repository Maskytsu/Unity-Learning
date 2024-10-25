using UnityEngine;

public class ActivateObjectOnKey : MonoBehaviour
{
    [SerializeField] private GameObject _gameObjectToActivate;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            _gameObjectToActivate.SetActive(!_gameObjectToActivate.activeSelf);
        }
    }
}
