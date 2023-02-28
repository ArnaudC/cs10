namespace CS10;

class ExtendedPropertyPatterns {
    public double SwitchOnExtendedPropertyPatterns(DataMeasurment dm) =>
        dm switch {
            { Measurement: 10 } => dm.Measurement * 10,
            { Measurement: 20 } => dm.Measurement * 2,
            _ => 0,
        };
}
