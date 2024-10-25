using NaughtyAttributes;
using UnityEngine;

public class ScritpOnEnable : MonoBehaviour
{
    [SerializeField] private TestingDependencyDebug testing;

    private string randomName = "";
    private int randomInt = 0;

    [Button]
    private void RandomMethod()
    {
        randomInt = 0;

        if (testing.randomEnum == RandomEnum.ESSA_TRZY)
        {
            randomName = testing.SetName("maciek");
        }

        if (testing.value < 20f)
        {
            randomName = testing.SetName("kuba");
        }

        if (randomName == "maciek")
        {
            gameObject.SetActive(false);
        }
    }

    private void OnEnable()
    {
        int i = 0;
        i++;
    }

    private void OnDisable()
    {
        int b = 0;
        b++;
    }
}
