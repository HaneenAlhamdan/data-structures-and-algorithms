## Singly Linked List
contain nodes which have a data part and an address part, i.e., Next, which points to the next node in the sequence of nodes. The next pointer of the last node will point to null.



## Challenge
* To implement Linked list in this challenge we need two classes: "Node" and "LinkedList".
* The LinkedList class contains all the function we need to solve this challenge, and before each function I write explanation.


## Approach & Efficiency
* create a node class that has next pointer and data to be inserted to the linked list
* create a linked list class, have reference to head node and contructor to intialize head to null, and has 3 fuctions for insert node,search for node,print all nodes.


## API
* Insert(int data) method that takes an integer value as argument,then creates a new node that holds this value inside it as data and insert it to the front by changing the head poniter to it in a way that keeps the linked list safe from loss.

* Includes(int data) method that loops through the linked list using a temp pointer to search for a searched data and returns true if it's found, otherwise it returns false. The condition of this loop is to keep iterating until the pointer reaches to null.

* LinkedListToString() method that returns the data of each node as a formatted string after it concatenates them inside a string using a while loop to traverse the whole linked list.