# Thread

## Busy Waiting

When a process repeatedly checks if a condition is true

## Mutex vs Atomic

- Mutex and atomic works in a similar fasion:
  - Require exclusive access
  - Do something
  - Release access
- **Atomic operations are implemented on a hardware level, which are
  inheritantly faster** than mutexes
