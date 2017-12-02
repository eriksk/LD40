using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEditor.Experimental.AssetImporters;

[ScriptedImporter(1, "meds")]
public class MedsImporter : ScriptedImporter
{
    public override void OnImportAsset(AssetImportContext ctx)
    {
        var lines = File.ReadAllLines(ctx.assetPath, Encoding.UTF8);

        var valueLines = lines.Skip(1);

        var meds = new List<Medication>();

        valueLines.Select(x => 
        {
            var fields = x.Split('\t');
            var med = new Medication();

            med.Name = fields[0];
            med.Infection = int.Parse(fields[1]);
            med.Coughing = int.Parse(fields[2]);
            med.Fever = int.Parse(fields[3]);

            return med;
        });

        var medication = new Medications();
        medication.Items = meds;
        ctx.SetMainAsset("MainAsset", medication);
    }
}