Also known as Action.

The goal is to transform our actions, transactions in objects. Why? For easy management! Objects you can move, change, store, and an action (let's say, that it is just a simple sequence of state [not a function and etc. just an ordered sequence of states in you favorite language!]) ... and an action you can't store. You can put in some place in code, but you can't store it.

Any idea with store it in function, class, or something else is actually the command idea. So you will, probably, don't invent anything new.

So, the problem is: SRP violation. If we use the action directly in complex logic (all is complex logic, if it's harder than 2 + 2), it will get a OCP violation too. Just imagine: you must at every time create a new design and, of top of that, new logic, that can be repeated and with a huge amount of variations you will surely have a combinatoric boom...

So. The idea is naive. Let's solve this by just create a new interlayer between the **caller** and the **executor**.

We store the action in the object and call it accordingly.

So we have something like that:

```
+-----------+   +-----------+   +------------+
|           |   |           |   |            |
|  Button1  |-->|  Command  |-->|  Business  |
|           |   |           |   |            |
+-----------+   +-----------+   +------------+
```

Example:

Realization >>

```csharp
public interface INodeCommand
{
    NodeCommandExecutionResult Execute(JsonDocument document);
}

public sealed class FilterNodeCommand : INodeCommand
{
    NodeCommandExecutionResult Execute(JsonDocument document)
    {
        // ...
    }
}
```

Integration>>

```csharp
public class FilterNode
{
    public NodeExecutionResult Execute(JsonDocument input)
    {
        if (input is JsonObjectDocument objectDocument)
        {
            var command = new FilterNodeCommand();
            NodeCommandExecutionResult result = command.Execute(objectDocument);
            // ...
        }

        throw new NotImplemented();
    }
}
```
