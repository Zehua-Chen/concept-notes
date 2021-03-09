# Coffman Conditions

A deadlock situation would **arise if and only if all four** of the following
situations hold in a system:

- **Hold and wait**: a process is currently holding at least one resource and
  requesting additional resource held by another process
- **Circular wait**: `p1` waits for `p2`, `p2` waits for `p3` and `p3` waits for
  `p1`
- **No pre-emption**: a resource can only be released voluntarily by the the
  process holding it, after that resource has completed its task
- **Mutual exclusion**: at least one resource is held in a non-sharable state

## Sample Questions

- **No circular wait**: threads need two items, one item is distributed first,
  and then the other.
- **No mutual exclusion**: if anything related to **sharing** is mentioned
