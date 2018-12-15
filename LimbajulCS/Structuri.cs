using System;


struct persoana
{
    private int varsta;
    private string nume;
    public int Varsta
    {
        get
        {
            return varsta;
        }
        set
        {
            if (value < 0)
                varsta = 0;
            else
                varsta = value;
        }
    }
    public string Nume
    {
        get
        {
            return nume;
        }
        set
        {
            nume = value;
        }
    }
    public persoana(int varsta=0, string nume="")
    {

        this.varsta = varsta;
        this.nume = nume;
    }
    public void Prezentare()
    {
        Console.WriteLine($"Ma numesc {nume} si am varsta de {varsta} ani.");
    }
  
    public override string ToString()
    {
        return nume;
    }
  

};
    class Structuri
    {
        static void Main()
        {
        persoana P = new persoana(16, "Alex");
        P.Prezentare();
        P.Nume = "Catia";
        P.Varsta = 19;
        P.Prezentare();

        Console.ReadKey();
        }
    }

