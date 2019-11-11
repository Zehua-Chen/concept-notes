# Resource Allocation Graph

A "resource allocation graph" is a directed graph in which:

- Both threads and resources are nodes in a graph
- If a thread has exclusive access to a resource, then an arrow
  is **drawn from the resource to the thread**
- If a thread requests exclusive access to a resource, then an
  arrow is **drawn from the thread to the resource**

## Detecting Deadlock

A **deadlock would occur** if there is **a circle in the graph**.

Note that it may not only be the threads that are invovled in the cycle
that are deadlocked. **All threads** requesting resources owned
by the deadlocked threads have the potential to deadlock
