class Program
{
    static void Main(string[] args)
    {
        // Crear el sujeto
        Subject subject = new Subject();

        // Crear los observadores
        IObserver observer1 = new ConcreteObserver("Observador 1");
        IObserver observer2 = new ConcreteObserver("Observador 2");

        // Agregar observadores al sujeto
        subject.Attach(observer1);
        subject.Attach(observer2);

        // Cambiar el estado del sujeto
        subject.State = "Estado A";
        subject.State = "Estado B";

        // Remover un observador y cambiar el estado
        subject.Detach(observer1);
        subject.State = "Estado C";
    }
}



