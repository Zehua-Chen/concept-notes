# Relationship Between Thread and Process

- **Memory space**: a process has its own memory space while a thread only has
  its own stack
- When `forking a program`, the threads won't be copied. In another word, the
  **child process only has a single thread**

# Thread Life Cycle

- Create thread `pthread_create`
- Exit the current thread `pthread_exit`
- Wait till a thread finishes `pthread_join`
- Cancel a thread `pthread_cancel`

Note that even though you try to cancel a thread, a thread may still continue.
In practice this function is not used much as threads won't be able to clean up
their resources.

`exit(int)` would terminate the calling process while `pthread_exit(void *)`
only terminates the calling thread.

# Thread and Process Life Cycle

- A process would terminate when either of the following conditions are true
  - The main thread **returns**
  - All theads has completed, when after main thread has **existed**,

# Busy Waiting

When a process repeatedly checks if a condition is true
