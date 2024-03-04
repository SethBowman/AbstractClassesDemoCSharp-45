using AbstractClassesDemoCSharp_45;

var beagle = new Dog();

beagle.Move();
beagle.Breathe();

var python = new Snake();

python.Move();
python.Breathe();

var circleA = new Circle(25);

Console.WriteLine($"Area of circle is {circleA.CalculateArea()}");


