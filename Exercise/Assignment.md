
# Exercise: Assignment

1.	Write extensions class with methods that make this code work:

`double d = "3.14".ToDouble(); // d should be: 3.14`

`bool b = "Something".HasValue(); // b should be True`

`bool b2 = "   ".HasValue(); // b should be False`

`var nums = new List<int>{1,2,3,4,5};`

`bool b3 = 4.IsIn(list); // b3 should be True`

`bool b4 = 88.IsIn(list); // b3 should be False`

Advanced (optional):

`string json = new {ID=1, Name="Moshe"}.ToJson(); // json should be {"ID":1,"Name":"Moshe"}`

---

2. Place a try-catch block around the most minimum code necessary in the following code:

`var data = new List<string>{"1","2","3",null};`
`var q = data.Select(x=>$"value is: {x}");`
`var result = q.ToList();`

---

3.	Assume there's a List of model object named "Order" with the following properties:

ID (int), CustomerName (string), Price (double), Created (DateTime).

Write code that writes to the console:

i.	The date & time of the most recent order

ii.	The number of orders in April 2020

iii.	The top 5 customer names that ordered the highest order (by price) (assume each customer has only one order in the list).
