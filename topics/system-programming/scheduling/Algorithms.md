# Shortest Job First

## Cons

- Need to make an estimate of how long a process would take, which is hard to do

# First Come First Serve

## Cons

- Long running processes can starve other jobs

# Round Robin

## Cons

- A lot of **context switching**
  - Context switching requires a TLB flush; TLB is supposed to improve
    efficiency
  - Cache needs to be saved
