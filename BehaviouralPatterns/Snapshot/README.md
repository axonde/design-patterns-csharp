# Snapshot (also history, memento (bruh))

Usually for create object history management. That's all.

But why we need another way of history creating if we have `Prototype` pattern? Yeaaa, the prototype goal is only to COPY the object, but not to replace. Its easy possible that copy is not so hard than replace action.

Imagine: you are in a war battle. You can easy get millions of new weapons near you, but if a sniper will check for you and the weapons will be aside him, it will be, believe me, impossible to replace your broken one.

So yes, sometime you need an extra object, for control the replace action.

That is the snapshot goal.

Structure:

## History owner principle

```
+-----------+   +---------------+
|           |   |               |
|  History  |-->|   Originator  |
|           |   |               |
+-----------+   +---------------+
             \
              \
                +--------------+
                |              |
                |   Snapshot   |
                |              |
                +--------------+
```

## Snapshot in owner creating principle (inner class):

```
+--------------------------------+
|                                |
|               +-------------+  |      +-----------+
|               |             |  |      |           |
|  Originator   |  Snapshot   |  |<-----|  History  |
|               |             |  |      |           |
|               +-------------+  |      +-----------+
|                                |
+--------------------------------+
```
