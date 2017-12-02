using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class MedicationTests 
{
	[Test]
	public void TakeMedication_MedicationPropertiesAffectsBody()
	{
		var body = new Body()
		{
			Coughing = 2,
			Fever = 0,
			Infection = 0
		};

		var medication = new Medication()
		{
			Name = "Couch Syrup",
			Coughing = -1,
			Fever = 0,
			Infection = 1
		};

		body.TakeMedication(medication);

		Assert.AreEqual(1, body.Coughing, "Coughing should go down");
		Assert.AreEqual(1, body.Infection, "Infection should go up");
		Assert.AreEqual(0, body.Fever, "Fever stays the same");
	}
}
