# Sequential Orderings

A system has sequential ordering if the result of operations from multiple
threads is the same as if those operations are interleaved and executed on one
processor.

For example

- Thread A
  - Operation 1
  - Operation 2
- Thread B
  - Operation 3
  - Operation 4

After **interleaving**, operation 1 and 2 may or may not semantically run before
3 and 4 but 1 will always run before 2 and 3 will always run before 4. **In
reality the operations don't have to run in this order, it's just the result
should be the same as if the operations are run in this order**.

## Implementations

- [`std::atomic` (C++)](https://en.cppreference.com/w/cpp/atomic/atomic)
- [`std::sync::atomic` (Rust)](https://doc.rust-lang.org/std/sync/atomic/index.html)
