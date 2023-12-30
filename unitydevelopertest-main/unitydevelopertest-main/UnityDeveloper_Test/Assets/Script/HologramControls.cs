using UnityEngine;

public class HologramControls : MonoBehaviour
{
    public GameObject hologramPrefab;
    public Transform spawnLocation;
    private GameObject instantiatedHologram;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            InstantiateHologram(Quaternion.Euler(0f, 0f, 180f));
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            InstantiateHologram(Quaternion.Euler(0f, 0f, -90f));
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            InstantiateHologram(Quaternion.Euler(0f, 0f, 90f));
        }
        else if (AnyKeyOtherThanArrowKeysPressed())
        {
            DestroyHologram();
        }
    }

    void InstantiateHologram(Quaternion rotation)
    {
        if (instantiatedHologram != null)
        {
            Destroy(instantiatedHologram);
        }

        instantiatedHologram = Instantiate(hologramPrefab, spawnLocation.position, rotation);
    }

    void DestroyHologram()
    {
        if (instantiatedHologram != null)
        {
            Destroy(instantiatedHologram);
            instantiatedHologram = null;
        }
    }

    bool AnyKeyOtherThanArrowKeysPressed()
    {
        if (Input.anyKeyDown)
        {
            foreach (KeyCode keyCode in System.Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(keyCode) && !IsArrowKeyCode(keyCode))
                {
                    return true;
                }
            }
        }

        return false;
    }

    bool IsArrowKeyCode(KeyCode keyCode)
    {
        return keyCode == KeyCode.UpArrow || keyCode == KeyCode.RightArrow || keyCode == KeyCode.LeftArrow;
    }
}
