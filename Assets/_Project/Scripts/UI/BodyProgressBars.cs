

using UnityEngine;

[RequireComponent(typeof(Body))]
public class BodyProgressBars : MonoBehaviour
{
    public ProgressBar Health, Cough, Infection, Fever;

    private Body _body;

    void Start()
    {
        _body = GetComponent<Body>();
    }

    void Update()
    {
        Health.Value = _body.Health / 100f;
        Cough.Value = _body.Coughing / 100f;
        Infection.Value = _body.Infection / 100f;
        Fever.Value = _body.Fever / 100f;
    }
}
