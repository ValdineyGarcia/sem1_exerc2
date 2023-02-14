double alturaTriangulo, baseTriangulo;
Console.WriteLine("Informe a altura do triangulo (em cm):");
alturaTriangulo = double.Parse(Console.ReadLine());
Console.WriteLine("Informe a base do triangulo (em cm):");
baseTriangulo = double.Parse(Console.ReadLine());
double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
Console.WriteLine($"A área do triangulo é de {areaTriangulo} cm.");

