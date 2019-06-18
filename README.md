# OloTask
One of our restaurant clients wants to know which pizza topping combinations are the most popular. 

Using a language in our technical stack, write an app or script that will download orders directly from http://files.olo.com/pizzas.json and output the top 20 most frequently ordered pizza topping combinations. List the toppings for each popular pizza topping combination along with its rank and the number of times that combination has been ordered.    

# To do
I had a json file in which I had different toppings order.I had to sort and show top 20 orders of toppings combination depending on the number of times a topping is ordered.

# What I used
I have used web client to get the json file from url. And then deserialize it. Then ordered the topping combination by using IEnumerableComparer in which I override interface "IEqualityComparer" method Equals and other methods.  

# Code To Look
Home controller Index method    
Index View     
IEnumerableComparer In Helper Folder     
And Models    
