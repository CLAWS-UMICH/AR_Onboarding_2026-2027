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

