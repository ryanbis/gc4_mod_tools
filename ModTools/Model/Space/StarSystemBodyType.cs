using System.ComponentModel;

namespace ModTools.Model.Space;

public enum StarSystemBodyType
{
    [Description(null)]
    Random,
    [Description("Star")]
    UnaryStar,
    // BinaryStar,
    [Description("Planet")]
    Planet,
    [Description("Asteroid")]
    Asteroid
}