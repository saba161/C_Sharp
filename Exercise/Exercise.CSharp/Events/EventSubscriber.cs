namespace Exercise.CSharp.Events;

public class EventSubscriber
{
    public EventSubscriber(EventPublisher publisher)
    {
        // Step 5: Subscribe to the event
        publisher.MyEvent += Publisher_MyEvent;
    }

    private void Publisher_MyEvent(object sender, EventArgs e)
    {
        Console.WriteLine("Event was raised! Handling it here...");
    }
}