## stack-and-queue

## Stack
is a linear data structure. that consists of Nodes. Each Node references the next Node in the stack, but does not reference its previous.

## Approach & Efficiency
1. Stack.push and Queue.enqueue: Time O(1) / Space O(1)
2. Stack.pop and Queue.dequeue: Time O(1) / Space O(1)
3. Stack.peek and Queue.peek: Time O(1) / Space O(1)
4. Stack.isEmpty and Queue.isEmpty: Time O(1) / Space O(1)

## Stack class : 
* push
* pop
* peek
* isEmpty


## Queue
is a linear data structure. It is an ordered list that follows the principle FIFO (First In -First Out). A Queue is a structure that follows some restrictions on insertion and deletion

## Queue class : 
* enqueue
* dequeue
* peek
* isEmpty

## API
Stack methods:
1. Push: takes a value as an argument and adds a new node with that value to the top of the stack with an O(1) Time performance.
2. Pop: removes the node and returns the node's value from the top of the stack.
3. Peek: returns value of the node located at the top of the stack.
4. IsEmpty: returns a boolean indicating whether or not the stack is empty.

Queue methods:

1. Enqueue: adds a new node with that value to the back of the queue with an O(1) Time performance.
2. Dequeue Returns: the value from node from the front of the queue.
3. Peek: returns value of the node located at the front of the queue.
4. IsEmpty returns a boolean indicating whether or not the queue is empty.