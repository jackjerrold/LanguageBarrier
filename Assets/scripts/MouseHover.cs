using UnityEngine;
using UnityEngine.InputSystem;

public class MouseHover : MonoBehaviour
{
    private GameObject lastHoverd;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray,out hit))
        {
            GameObject hovering = hit.collider.gameObject;
            if (hovering != lastHoverd)
            {
                if (hovering.layer == 3)
                {
                    if (hit.collider.GetComponent<activeChar>() == null)
                    {

                    }
                }
            }
        }
    }
}

