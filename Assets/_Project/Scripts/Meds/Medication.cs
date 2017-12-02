using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Custom/Meds/Medication")]
public class Medication : ScriptableObject
{
	public string Name;
	public string Description;
	public string FinePrint;
	public int Infection;
	public int Coughing;
	public int Fever;

	public string Tooltip { get { return Name + " - " + Description + "\n" + FinePrint; } }
}
