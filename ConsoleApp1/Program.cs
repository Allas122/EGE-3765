
Dictionary<int,int> Factorization(int n)
{
    var Factorization =new Dictionary<int,int>();
    for (int Dels = 2; i <= Math.Sqrt(n)+1; i++)
    {
        if (!Factorization.ContainsKey(i) && n % Dels ==0)
        {
            Factorization[Dels] = 0;
        }
        while(n % Dels == 0)
        {
            n /= Dels;
            Factorization[Dels] += 1;
        }
    }
    if (n != 1)
    {
        Factorization[n]= 1;
    }
    return Factorization;
}


int N(int k) {
    return 1850000000 + k;
}


int CountDels(Dictionary<int,int> Factorization){
    int Dels = 1;
    int DelsWithoutTwo = 1;
    foreach(int i in Factorization.Keys)
    {
        if(i != 2)
        {
            DelsWithoutTwo *= (pr[i] + 1);
        }
        Dels *= (Factorization[i] + 1);
    }
    return Dels - DelsWithoutTwo;
}

for(int i = 0; i <=1000000 ; i+=2)
{
    var factorization = Factorization(N(i));
    var s = CountDels(factorization);
    Console.WriteLine(i.ToString() + " " + s);
}