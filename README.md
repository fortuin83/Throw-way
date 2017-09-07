# Throw Away

> notes by Brian Fortuin

The line above is equivalent to an  `<h1>Throw Away</h1>` HTML markup.

The idea of  markdown files is to make it easier to write text that you want to have some sort of **richeness** to it, but dont want to get hung up on the details of markup (HTML) or having to resort to more 'binary representation such as in MS Word.

Markdown can produce lists just like this:

-A List item can either start with a dash or an asterix
	-its a good idea to be consistent
	- This line and the one aboe are indented in the lists
-undordered lists are easy to do in markdown.
- Besides unordered lists, you can do ordered lists. For and ordered list, use the number 1 followed by a dot (as seen below).

## Other examples

The line above is equivalent to an <h2> element.</h2> (Note 2 pound symbols - you can have up to six!)

For your homework:

1. Learn about the different stylings for markdown. Specifically how to do:
	1. Headings
	1. Lists (undordered/ordered)
	1. Code snippets (like <h1>Code</h1>)
	1. Code blocks (multiple lines of codes)
	1. **Bold** and *Italic*
	1. Tables
	1. Hyperlinks (eg: google home page (www.google.com)
	1. Images
	1. Other interesting things
1. Answer the question whats is the difference between **Github Flavored Markdown**  (GFM) and regular markdown?
1. Find out how to do a checkbox in a list using GFM.


You can do code blocks in markdown, and even have it highlighted in the right colors for the appropriated kind of code. for example, here's some HTML:

```html
<h1>Hello World</h1>
<p>You should really get into learning about CSS grid and Flexbox!<p>
```

Here is and example of C# Code

```Csharp
public class Greeter
{
	private string_Greeting = "Hello World";
	private string_Goodbye;
}

	public Greeter(string greeting, string goodbyw)
	{
		_Greeting = greeting;
		_Goodbye = goodbye;
	}
	
	public string SayHello()
	{
		return_Greeting;
	}