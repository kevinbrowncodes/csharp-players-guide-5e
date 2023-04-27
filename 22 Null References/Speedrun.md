Speedrun

- Reference types may contain a reference to nothing: null, representing a lack of an object.

- Carefully consider whether null makes sense as an option for a variable and program accordingly.

- Check for null with x == null, the null
  conditional operator x?.DoStuff() and x?[3], and use ?? to allow null values to fall back to some other default: x ?? "empty"
