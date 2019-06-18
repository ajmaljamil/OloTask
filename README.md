# OloTask
OloTask
# To do
I had a json file in which I had different toppings order.I had to sort and show top 20 orders of toppings combination depending on the number of times a topping is ordered.

# What I used
I have used web client to get the json file from url. And then deserialize it. Then ordered the topping combination by using IEnumerableComparer in which I override interface "IEqualityComparer" method Equals and other methods.  

# Code To Look
Home controller Index method    
Index View     
IEnumerableComparer In Helper Folder     
And Models    
