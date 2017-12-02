

using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Body : MonoBehaviour
{
    public float Health;

	public float Infection;
	public float Coughing;
	public float Fever;

    public void TakeMedication(Medication meds)
    {
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

    void Update()
    {
        var damages = new []{ Infection, Coughing, Fever};
        var tookDamage = false;
        foreach(var damage in damages)
        {
            if(damage > 25f)
            {
                Health -= damage * 0.15f * Time.deltaTime;
                tookDamage = true;
            }
        }

        // var damage = Infection + Coughing + Fever;
        // var effect = damage * 0.05f;

        // if(effect > 0.2f)
        //     Health -= effect * Time.deltaTime;
        if(!tookDamage)
            Health += 0.2f * Time.deltaTime;

        Fever = IncreaseSickness(Fever);
        Coughing = IncreaseSickness(Coughing);
        Infection = IncreaseSickness(Infection);

        if(Health <= 0f)
        {
            SceneManager.LoadScene("GameOver");
        }

        Health = Mathf.Clamp(Health, 0f, 100f);
    }

    private float IncreaseSickness(float value)
    {
        if(value <= 0f) return value;
        return value + (0.2f * Time.deltaTime);
    }
}