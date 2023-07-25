# builder

Is used to separate the construction of a complex object from its representation, allowing the same construction process to create different representations.


Imagine you have a menu with different types of burgers, and each burger has different ingredient choices, such as type of bun, meat, cheese, vegetables and sauces. Instead of creating a class for each possible combination of ingredients, you can use the Builder pattern to define a common construction process for all burgers and allow the user to select the ingredients he wants.

### consider using the Builder pattern when:

* The process of building an object is complex and requires several steps.
* You want to create different representations of the same object.
* You want to encapsulate the code for the construction of an object in one place.
* You want to separate the construction of an object from its representation.
