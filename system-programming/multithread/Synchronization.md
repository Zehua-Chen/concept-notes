# Synchronization

## Mutex vs Atomic

- Mutex and atomic works in a similar fasion:
  - Require exclusive access
  - Do something
  - Release access
- **Atomic operations are implemented on a hardware level, which are
  inheritantly faster** than mutexes
