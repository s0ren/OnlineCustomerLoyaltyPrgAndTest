Online Customer Loyalty Programme
=================================
This system is a small demonstration and exercise in the art of programming for test, 
and testing programms. This is also known as Test Driven Development (TDD).
Our case is a system to encurage custmers to return to recent vendors and make new orders on previusly unknown items.
The ecact model of encuregement could be chalanged and changed, and would require adjustmens of the tests as well.
## Purchases
A purchase is seen as a relation between a vendor and a customer. The customer makes a purchase at the vendor. 
When the customer makes a purchase, the vendor returns loyalty points for that purchase.
How many points to return is decided by the vendor.
Customers have IDs to identify them at the vendor, as a returning customer.
The ProductVendor is responsable for its products and the amount of points returned for each product. 
The ProductVendor also records each purchase with CustomerID od ItemID.
## Vendors and Customers
Vendors and customers are modeled in the classes ProductVendor and Customer.
The customer class should be finnished by the student, while most of the class ProductVendor is given here.
To finnish the Custommer, and particularly the tests for it, you may have to alter or add to the ProductVendor class.
If you do so, please adjust and add to VendorTest.
The class Customer is widely unfinnished. Your mission, should you choose to accept it, is to complete this class.

Please see the tasks inside Customer.cs.

## VendorTests and CustomerTest
The tests for this system are organized to two extra projects under the same solution. This makes it easy'er to distribuate the program without the tests, once it is finnished.
The test for the ProductVendor class is in VendorTest, and are complete to the current funtionality og the class. 
This serves both as a sample, and as a fixture, to messure future additions to the system.
The tests for Customers are very incomplete, as are the customer class itself. Your mission, as a student, is to complete this test. 

Please see the tasks inside UnitTest1.cs of CustomerTest.

