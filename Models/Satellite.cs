namespace AIHR.Space.Models;

public class Satellite
{
    public Satellite(CelestialBody celestialBody) => CelestialBody = celestialBody;

    public CelestialBody CelestialBody { get; }

    public int Distance { get; set; }

    public int OrbitalPeriod { get; set; }
}