<h1> MonstaMathLIB - Version: 1.1</h1>
<hr>
<p>This is an early version math library written in C# programming language.
I am hoping to help students in middle school and high school with their math homework and their exam prep questions.
This project will be supported and will be taken to high level to also help college students with their studies.
The reason it is on console is that I want anyone with any operating system to be able to run this software and use it for their studies.</p>

<hr>
<h2>Features</h2>
<hr>
<ul>
  <li>Basic Calculations</li>
  <ul>
    <li>Addition</li>
    <li>Subtraction</li>
    <li>Multiplying</li>
    <li>Dividing</li>
  </ul>
  <li>Area Calculations</li>
  <ul>
    <li>Square</li>
    <li>Rectangle</li>
    <li>Triangle</li>
    <li>Circle</li>
  </ul>
  <li>Perimeter Calculations</li>
  <ul>
    <li>Triangle</li>
    <li>Rectangle</li>
    <li>Parallelogram</li>
    <li>Square</li>
    <li>Rhombus</li>
    <li>Hexagon</li>
  </ul>
</ul>
<hr>
<h2>Import Library</h2>
<p>After creating the project</p>
<ul>
  <li>Right Click on "Dependencies" in Solution.</li>
  <li>Click on "Add COM Reference".</li>
  <li>On the bottom of the panel click on "Browse" button.</li>
  <li>Navigate to the ".dll" file path.</li>
  <li>Choose the ".dll" file.</li>
  <li>On the left side menu click on "Browse".</li>
  <li>If the check box is not selected click on the checkbox and be sure it is selected.</li>
  <li>Press "OK" button on the bottom of the panel.</li>
</ul>
<hr>
<h2>Example Usage</h2>

```
using MonstaMathLIB;

namespace MathLIBTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            monstaLib mathlib = new monstaLib();
            string result = mathlib.add(10,20);
            Console.WriteLine(result);
            result = mathlib.circleArea(4);
            Console.WriteLine(result);
        }
    }
}
```
