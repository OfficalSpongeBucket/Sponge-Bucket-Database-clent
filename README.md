
# Sponge Bucket cloud storage

A minimal C# CLI server with RAM simulation, node isolation, and command handling.

## Features
- Node ID assignment (`node_01`, `node_02`, ...)
- RAM tracking (512-2GB per node)
- Commands: `touch`, `del`, `ls`, `mem`, `edit`, `exit`

## How to Run
1. Start the .cs file
2. Run the database file and watch it connect to `localhost:9090`
3. Type commands and watch the magic

I wish to take this to the next step by using a aws instance as my server,`t4g.small` to be exact 

## Coming Soon
- `store`, `query`, `clean`, `rename`, `echo`
