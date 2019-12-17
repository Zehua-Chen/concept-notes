# Orphans and Zombies

- A zombie is a process that is killed, but has not been waited by its parent
  process, thereby causing **its entry in the process table to not be removed**
  (**Killed, but still around**).

  - All well-behaving user process would enter this stage shortly after they
    exit, before their parents `wait` them

- An orphan process is a process whose parent has exited. On Linux and Unix,
  these types of processes immediately uses the `init` process as their parent.
  - The `init` process periodically `wait` its children (some of which are
    zombies)
  - A **long-living zombie process** can only be created when **the parent has
    neither exit nor wait, but the children has already exited**

# Process Layout

- string literal stored inside the readonly section of **data**;
