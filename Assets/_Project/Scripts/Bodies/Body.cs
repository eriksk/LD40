

using System;
using UnityEngine;

public class Body : MonoBehaviour
{
    public float Health;

	public int Infection;
	public int Coughing;
	public int Fever;

    public void TakeMedication(Medication meds)
    {
        Debug.Log("Taking meds: " + meds.name);
        Infection += meds.Infection;
        Coughing += meds.Coughing;
        Fever += meds.Fever;
        Clamp();
    }

    private void Clamp()
    {
        Infection = Mathf.Clamp(Infection, 0, int.MaxValue);
        Coughing = Mathf.Clamp(Coughing, 0, int.MaxValue);
        Fever = Mathf.Clamp(Fever, 0, int.MaxValue);
    }
}