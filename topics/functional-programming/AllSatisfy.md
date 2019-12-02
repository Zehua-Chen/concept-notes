# All Satisfy

1. Go through all elements of a collection
2. Check each value using some predicate
3. If all checks return true, then "all satisfy" returns true

## JavaScript

```js
let someBoolean = collection.every((entry) => { return false; });
```

## Swift

```swift
let someBoolean = collection.allSatisfy { value in return false; }
```

## C++

```cpp
#include <algorithm>

bool result = std::all_of(collection.begin(), collection.end(), [=](auto e) {
  return false;
});
```

## C#

```cs
using System.Linq;

// AsEnumerate() is not needed if the collection conforms
// to IEnumerable<T>
bool all = elements.AsEnumerable()
  .All((int element) =>
  {
    Console.WriteLine("run");
    return true;
  });
```
