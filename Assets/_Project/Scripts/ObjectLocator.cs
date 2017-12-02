
using UnityEngine;

public static class ObjectLocator
{
    private static Tooltip _tooltip;
    public static Tooltip Tooltip 
    {
        get
        {
            if(_tooltip != null) return _tooltip;
            var tooltipObject = GameObject.Find("Tooltip");

            if(tooltipObject == null) return null;

            _tooltip = tooltipObject.GetComponent<Tooltip>();

            return _tooltip;
        }
    }
}