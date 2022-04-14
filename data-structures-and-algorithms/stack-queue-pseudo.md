## stack-queue-pseudo

![Screenshot (231)](https://user-images.githubusercontent.com/98957434/163307231-3b815414-2b8e-408e-ba08-435317b8fc87.png)

## Approach & Efficiency
For the Enqueue method, I used the regular push to stack method where I just keep pushing to the first stack, and for the space complexity, it is a O(1), and for the time complexity it is also a O(1).
For the Dequeue method, I used both of stacks to make it look like a queue, so I empty the first stack values and push them to the second stack, then pop one value and then push all the values from stack2 to stack1, and return the popped value.


## API
Enqueue(x):
1- While stack1 is not empty, push everything from stack1 to stack2.

2- Push x to stack1 (assuming size of stacks is unlimited).

3- Push everything back to stack1.

Dequeue():
1- If stack1 is empty then error message

2- Pop an item from stack1 and return it

Peek()
1- return queue peek