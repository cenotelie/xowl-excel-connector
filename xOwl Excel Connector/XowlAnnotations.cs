using System;

namespace xOwl_Annotations
{
    public class BusinessClass : Attribute
    {
        public string BaseUri { get; set; }
        //TODO: Position is mandatory in case of complex mapping
        public string Position { get; set; }
        public string ProcessId { get; set; }
        public string TaskId { get; set; }
    }

    public abstract class CellConfiguration : Attribute
    {
        //TODO: use template language instead; position is mandatory in case of complex mapping
        public int[] Position { get; set; }
    }

    //TODO: eventually add other presentation properties: Color, Font, etc.
    public class PushConfiguration : CellConfiguration
    {
    }

    public class SpecConfiguration : CellConfiguration
    {
    }

    //FIXME: temporary solutions - try to use tuples instead => (worksheetname, row, col)
    public class PowerRamDataConfiguration : CellConfiguration
    {
    }

    public class StaticPerformanceConfiguration: CellConfiguration
    {
    }

    public class ActuatorConfiguration: CellConfiguration
    {
    }

    public class HydraulicBlockConfiguration : CellConfiguration
    {
    }
}
