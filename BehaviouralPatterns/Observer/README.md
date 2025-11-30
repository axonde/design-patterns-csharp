# Observer

Subscription. You have an object, that have an important logic, which would notify some others objects on the event.

Confusing? Not.

The easy implementation of it looks like let's just create a class, store observers like simple field and notify them when we need it.

So wrong. OCP violation. Hard to add new observers in future, hard to maintain it, haven't a stable interface...

Let's just create something good.

## Structure:

```
+-----------<I>-+
|               |
|  ISubscriber  |
|               |<---   +-----------------------------------------------+
+---------------+   |---|                                               |
                        |  Publisher  +-------------------------------+ |
+-----------<I>-+       |             |                               | |
|               |       |             | Subscription : ISubscription  | |
| ISubscription |<------|             |                               | |
|               |       |             +-------------------------------+ |
+---------------+       +-----------------------------------------------+
```
