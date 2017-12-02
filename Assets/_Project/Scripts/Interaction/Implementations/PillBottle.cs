using UnityEngine;

public class PillBottle : MonoBehaviour, IInteractable, IHoverable
{
    public Medication Medication;

    public void Interact()
    {
    }

    public void OnHover()
    {
        if(Medication == null) return;

        var tooltip = ObjectLocator.Tooltip;
        if(tooltip == null) return;

        tooltip.Display(Medication.Tooltip);
    }
}