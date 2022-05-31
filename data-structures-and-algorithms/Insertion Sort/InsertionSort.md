## InsertionSort

### Implementation of Insertion Sort.

Provide a visual step through for each of the sample arrays based on the provided pseudo code.
Convert the pseudo-code into working code in your language.
Present a complete set of working tests

![Screenshot (278)](https://user-images.githubusercontent.com/98957434/170838905-7e0ddc36-c24b-49fd-952e-67ce16657457.png)

![Untitled (15)](https://user-images.githubusercontent.com/98957434/171091607-1e32e1da-45f0-443a-b796-3b2f4dd3662d.jpg)

### Desciption

1- Initially, the first two elements of the array are compared in insertion sort.
33, 12, 7, 15, 21, 2, 0

Here, 33 is greater than 12 hence they are not in the ascending order and 33 is not at its correct position. Thus, swap 12and 33. 
12, 33, 7, 15, 21, 2, 0

2- Now, move to the next two elements and compare them
Here, 7 is less than 33,hence they are not in the ascending order and 7 is not at its correct position, hence, swapping will occur. 33 and 7
12, 7, 33, 15, 21, 2, 0

After swapping, elements 7 and 12 are not sorted, thus swap again
7, 12, 33, 15, 21, 2, 0


3- Here, again 15 and 33 are not sorted, hence swap again
7, 12, 15, 33, 21, 2, 0

4- Now, Moving to the next two elements 21and 33
7, 12, 15, 21, 33, 2, 0

5- Here, 2 is less than 33,hence they are not in the ascending order and 2 is not at its correct position, hence, swapping will occur. 33 and 33
7, 12, 15, 21, 2, 33, 0

Now, 2 is smaller than 21, hence, swap again
7, 12, 15, 2, 21, 33, 0

And swap again
7, 12, 2, 15, 21, 33, 0

And again
7, 2, 12, 15, 21, 33, 0

And again
2, 7, 12, 15, 21, 33, 0

6-Now, 0 is smaller than 33, hence, swap
2, 7, 12, 15, 21, 0, 33

And swap again
2, 7, 12, 15, 0, 21, 33

And again
2, 7, 12, 0, 15, 21, 33

And again
2, 7, 0, 12, 15, 21, 33

And again
2, 0, 7, 12, 15, 21, 33

And Finally
0, 2, 7, 12, 15, 21, 33

