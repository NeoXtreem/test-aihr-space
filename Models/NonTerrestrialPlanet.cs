using AIHR.Space.Types;

namespace AIHR.Space.Models;

public sealed class NonTerrestrialPlanet : Planet
{
    public NonTerrestrialPlanetType PlanetType { get; set; }
}