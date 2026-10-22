using System.Collections.Generic;

// Example Event Type:
public class Event 
{
    public string message { get; private set; }

    public Event(string msg)
    {
        message = msg;
    }
}

// Add event types here as needed...
// TODO:
// - Add a vitals update event type for EV1
// - Add a vitals update event type for EV2

public class VitalsUpdatedEvent
{
    public VitalsDetails vitalsDetails { get; private set; }
    public VitalsUpdatedEvent(VitalsDetails v) { vitalsDetails = v; }
}

public class FellowVitalsUpdatedEvent
{
    public VitalsDetails vitalsDetails { get; private set; }
    public FellowVitalsUpdatedEvent(VitalsDetails v) { vitalsDetails = v; }
}

