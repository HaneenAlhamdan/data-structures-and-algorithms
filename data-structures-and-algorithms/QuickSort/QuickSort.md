## Quick sort

![Screenshot (280)](https://user-images.githubusercontent.com/98957434/171086185-7a909b06-c21f-40f7-be14-3b758b2d4403.png)

![Untitled (16)](https://user-images.githubusercontent.com/98957434/171093364-59986651-a7e0-4b04-9331-2e5e0a44046f.jpg)


### Desciption

1- Take two elements left first element and right last element
2-  Make low store the starting index of the array, low -1
3- Make pivot store the last index of the array
4- Take a variable i and initialize it to left
5- Traverse through the entire array using the variable i and compare each element with pivot
6- Increment i by 1
7- When the loop terminates, return low + 1.
8- The value returned by the partitioning algorithm gives us the correct position or index of the pivot in the array. What is meant by correct position is that all elements preceding the pivot are smaller than the pivot and all the elements after the pivot are greater than it.