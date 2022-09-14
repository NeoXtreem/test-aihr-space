using System.Collections.ObjectModel;
using System.Drawing;

namespace AIHR.Space.Models;

public class CelestialBody
{
    public string Name { get; set; } = string.Empty;

    public Image? Picture { get; set; }

    public int Mass { get; set; }

    public ICollection<Satellite> Satellites { get; set; } = new Collection<Satellite>();

    public IReadOnlyCollection<CelestialBody> GetSatellitesByOrbitalPeriod()
    {
        return Satellites.OrderBy(s => s.OrbitalPeriod).Select(s => s.CelestialBody).ToList().AsReadOnly();
    }
}