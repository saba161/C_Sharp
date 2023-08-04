namespace Exercise.CSharp.Events;

// Step 1: Define a custom event delegate
public delegate void EventHandlerDelegate(object sender, EventArgs e);

public class EventPublisher
{
    // Step 2: Define the event using the custom delegate
    public event EventHandlerDelegate MyEvent;
    
    public void DoSomething()
    {
        // Step 3: Raise the event
        OnMyEvent(EventArgs.Empty);
    }

    protected virtual void OnMyEvent(EventArgs e)
    {
        // Step 4: Check if any subscribers and invoke the event
        MyEvent?.Invoke(this, e);
    }
}