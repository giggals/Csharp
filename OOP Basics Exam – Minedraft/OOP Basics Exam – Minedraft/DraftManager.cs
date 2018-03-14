using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class DraftManager
{
    private ProviderFactory providerFactory;
    private HarvesterFactory harvesterFactory;
    private List<Harvester> harvesters;
    private List<Provider> providers;
    private string mode;
    private double totalEnergyStored;
    private double totalMinedOre;

    public DraftManager()
    {
        providerFactory = new ProviderFactory();
        harvesterFactory = new HarvesterFactory();
        harvesters = new List<Harvester>();
        providers = new List<Provider>();
        totalEnergyStored = 0;
        totalMinedOre = 0;
        mode = "Full";
    }


    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            var harvester = harvesterFactory.CreateHarvester(arguments);
            harvesters.Add(harvester);
            return $"Successfully registered {arguments[0]} Harvester - {harvester.Id}";
        }
        catch (ArgumentException ex)
        {
            return ex.Message;
        }

    }

    public string RegisterProvider(List<string> arguments)
    {
        try
        {
            var provider = providerFactory.CreatePRovider(arguments);
            providers.Add(provider);

            return $"Successfully registered {arguments[0]} Provider - {provider.Id}";
        }
        catch (ArgumentException ex)
        {
            return ex.Message;
        }

    }

    public string Day()
    {
        StringBuilder str = new StringBuilder();

        var summedEnergyStored = providers.Sum(p => p.EnergyOutput);
        totalEnergyStored += summedEnergyStored;

        double summedEnergyReq = 0, dayMinedOres = 0;

        if (mode == "Full")
        {
            summedEnergyReq = harvesters.Sum(h => h.EnergyRequirement);
            dayMinedOres = harvesters.Sum(h => h.OreOutput);
        }
        else if (mode == "Half")
        {
            summedEnergyReq = harvesters.Sum(h => h.EnergyRequirement) * 0.6;
            dayMinedOres = harvesters.Sum(h => h.OreOutput) * 0.5;
        }
        else if (mode == "Energy")
        {
            dayMinedOres = 0;
            summedEnergyReq = 0;
        }

        if (totalEnergyStored >= summedEnergyReq)
        {
            totalMinedOre += dayMinedOres;
            totalEnergyStored -= summedEnergyReq;
        }
        else
        {
            dayMinedOres = 0;
        }

        str.AppendLine("A day has passed.").AppendLine($"Energy Provided: {summedEnergyStored}").Append($"Plumbus Ore Mined: {dayMinedOres}");
        return str.ToString();

    }

    public string Mode(List<string> arguments)
    {
        this.mode = arguments[0];
        return $"Successfully changed working mode to {mode} Mode";

    }

    public string Chek(List<string> arguments)
    {
        Unit unit = (Unit)harvesters.FirstOrDefault(h => h.Id == arguments[0]) ?? providers.FirstOrDefault(p => p.Id == arguments[0]);
        if (unit != null)
        {
            return unit.ToString();
        }

        return $"No element found with id - {arguments[0]}";

    }

    public string ShutDown()
    {
        return $"System Shutdown" + Environment.NewLine +
             $"Total Energy Stored: {totalEnergyStored}" + Environment.NewLine +
             $"Total Mined Plumbus Ore: {totalMinedOre}";

    }
}

