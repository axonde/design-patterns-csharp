# Iterator

Just a simple concept: let's create an object, which will iterate right our inner data, if it is connected in some way to a collection mean.

I don't want to tell lot about it, because some [books](../../README.md) do it more educative and right than me.

Get us forward. Iterator is a separate object, but, of course, they're linked. We use it for encapsulate, hide and concrete the possibilities of iterating on our object.

## Possible structure:

```
   +------<I>-+       +--------<I>-+
   |          |       |            |
   | Iterator |<------|  Iterable  |
   |          |       | collection |
   +----------+       |            |
         |            +------------+
         |                  ^
         v                  |
+----------------+    +----------------+
|                |    |                |
|    Iterator    |    |    Iterable    |
| implementation |    |   collection   |
|                |    |                |
+----------------+    +----------------+

```

But you can always make more simple structures, even like in C++ you have a built-in `input-iterator-tag` for iterators object and that's all.
