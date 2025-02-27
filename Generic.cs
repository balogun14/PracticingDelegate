namespace Test;
class Generic<T>
{ 
    public  void Print<G>(G items)
    {
        Console.WriteLine(items);
    }

    public T AddNumbers(T a , T b){
        Console.WriteLine($"{a} + {b}");
        return a;
    }

    public void PrintName<C>(C person){
        Console.WriteLine(person);
    }
}
