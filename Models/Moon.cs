using AIHR.Space.Interfaces;

namespace AIHR.Space.Models;

internal class Moon : CelestialBody, ITerrestrial
{
    public bool CanSustainLife { get; set; }

    public bool CanBeTerraformed { get; set; }
}