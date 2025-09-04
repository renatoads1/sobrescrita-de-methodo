
var mot = new MotoqueiroIfood();
mot.FazerEntrega();

public abstract class Entregador {

    public abstract void Entregar();
    public abstract void Retirar();

}

public class MotoqueiroIfood : Entregador {

    public override void Entregar() {
        Console.WriteLine("Entregando encomenda");
    }
    public override void Retirar() {

        Console.WriteLine("Retirando Encomenda");
    }

    public void FazerEntrega() {
        Retirar();
        Entregar();
    }
}