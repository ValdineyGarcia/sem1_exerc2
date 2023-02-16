double alturaTriangulo, baseTriangulo;
Console.WriteLine("Informe a altura do triângulo (em cm):");
alturaTriangulo = double.Parse(Console.ReadLine());
Console.WriteLine("Informe a base do triângulo (em cm):");
baseTriangulo = double.Parse(Console.ReadLine());
double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
Console.WriteLine($"A área do triângulo é de {areaTriangulo} cm.");

