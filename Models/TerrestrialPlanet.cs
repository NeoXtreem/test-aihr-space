using AIHR.Space.Interfaces;

namespace AIHR.Space.Models;

public sealed class TerrestrialPlanet : Planet, ITerrestrial
{
    public bool CanSustainLife { get; set; }

    public bool CanBeTerraformed { get; set; }
}