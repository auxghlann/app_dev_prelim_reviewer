# App Dev Reviwer Prelim

* Understaning Controls By Creating a simple Calculator App :
  * Textboxes 
  * Buttons 
  * Labels
  * Conversion Methods

Example Output:

![Calculator](image1.png)

## Textboxes

These are controls used for user inputs

![Textboxes](image2.png)


* The syntax to get the value of the textbox is to call the Text Property of the TextBox class

Ex:
``` c#

string textBoxValue = textBoxName.Text;

```

Ex code:

![textProperty](textProperty.png)

> Note: That the Text Property returns a String. So, if the textBox holds a number in a string data type, you need to convert it to get the number representation (int or double) of that string number.


## Labels

* This is a control for labeling something
* Purely text

![label](image3.png)

> The labels in this image are "`Number 1`", "`Number 2`", "`Result: n`" 

* The only thing we do in labels is to statically set it a default value or to dynamically change it througout the runtime of the application

- The syntax to change the value of the text at runtime is:
``` c#
labelName.Text = "newTextValue";
```

> Note: Once again, the Text property returns a String so it also must **receive a String**.

- So, if the you want to pass a value that is a number (int or double), you must convert it to string first using the ToString() functiom.

EX:

``` c#

string numericValue = 69;
labelName.Text = numericValue.ToString();

```




