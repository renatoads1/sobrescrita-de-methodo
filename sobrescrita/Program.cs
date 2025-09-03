

var animais = new List<Animal>
{
    new Animal(),
    new Cachorro(),
    new Gato()
};

foreach (var animal in animais)
{
    animal.EmitirSom();
}

//O animal faz um som.
//cachorro late
//gato mia

public class Animal
{
    public virtual void EmitirSom()
    {
        Console.WriteLine("O animal faz um som.");
    }
}

public class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("O cachorro late.");
    }
}

public class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("O gato mia.");
    }
}