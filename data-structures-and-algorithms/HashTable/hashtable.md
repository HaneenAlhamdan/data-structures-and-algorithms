## Hashtable

### What is a Hashtable?

Hash - A hash is the result of some algorithm taking an incoming string and converting it into a value that could be used for either security or some other purpose. In the case of a hashtable, it is used to determine the index of the array.
Buckets - A bucket is what is contained in each index of the array of the hashtable. Each index is a bucket. An index could potentially contain multiple key/value pairs if a collision occurs.
Collisions - A collision is what happens when more than one key gets hashed to the same location of the hashtable.


### API
1. void Set(key, value): this method should hash the key, and set the key and value pair in the table, handling collisions as needed. Should a given key already exist, replace its value from the value argument given to this method(Complexity: O(n)).
2. string value Get(key): this method return a value associated with that key in the table(Complexity: O(n)).
3. bool Contains(key): this method returns a boolean, indicating if the key exists in the table already(Complexity: O(n)).
4. List keys(): this method return a collection of keys(Complexity: O(n))
5. int Hash(key): this method returns an index in the collection for that key(Complexity: O(1)).