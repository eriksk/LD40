

using UnityEngine;
using UnityEngine.UI;

public class InteractionCrosshairs : MonoBehaviour
{
    public LayerMask InteractionMask;
    public float InteractionDistance;
    public Image CrosshairsImage;

    private IInteractable _currentInteractable;

    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, InteractionDistance, InteractionMask))
        {
            var hitObject = hit.collider.gameObject;
            // var interactable = hitObject.GetComponent<IInteractable>();

            // if(interactable != null)
            // {
                
            // }
            CrosshairsImage.color = Color.green;
            CrosshairsImage.rectTransform.localScale = Vector3.one * 3f;
        }
        else
        {
            CrosshairsImage.color = Color.white;
            CrosshairsImage.rectTransform.localScale = Vector3.one * 1f;
        }
    }
}
