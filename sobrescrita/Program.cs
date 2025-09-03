var rel = new Relatorio();
rel.imprime();
var fat = new Fatura();
fat.imprime();

public abstract class Imprimir {

    public abstract void imprime(); 
}

public class Relatorio : Imprimir { 
    public override void imprime() { 
        Console.WriteLine("Relatório impresso");
    }
}

public class Fatura : Imprimir { 
    public override void imprime() { 
        Console.WriteLine("Fatura impressa");
    }
}