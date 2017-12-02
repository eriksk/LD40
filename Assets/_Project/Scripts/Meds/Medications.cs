using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Custom/Meds/Medications")]
public class Medications : ScriptableObject
{
    public List<Medication> Items;
}