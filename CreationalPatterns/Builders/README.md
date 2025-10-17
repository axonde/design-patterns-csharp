## Builder

`Builder` pattern answers to his name well.

When an object is hard to configure (huge count of variants) we don't find the using of an enormous constructor well. Than, the pattern `builder` can take all the massive _construction_ logic in himself to produce the wanted object.

And if there are some popular way of object build configs, we can create a `Director`, which will be just delegate the memorized logic to all builder's method.

Realization:

- [SkinBuilder](SkinBuilder/README.md)
