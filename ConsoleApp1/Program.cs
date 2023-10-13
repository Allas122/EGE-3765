
Dictionary<int,int> prostDel(int n)
{
    var o =new Dictionary<int,int>();
    for (int i = 2; i <= Math.Sqrt(n)+1; i++)
    {
        if (!o.ContainsKey(i) && n % i ==0)
        {
            o[i] = 0;
        }
        while(n % i == 0)
        {
            n /= i;
            o[i] += 1;
        }
    }
    if (n != 1)
    {
        o[n]= 1;
    }
    return o;
}


int N(int k) {
    return 1850000000 + k;
}


int sumOfDels(Dictionary<int,int> pr){
    int o = 1;
    int un = 1;
    foreach(int i in pr.Keys)
    {
        if(i != 2)
        {
            un *= (pr[i] + 1);
        }
        o *= (pr[i] + 1);
    }
    return o - un;
}

for(int i = 0; i <=1000000 ; i+=2)
{
    var pr = prostDel(N(i));
    var s = sumOfDels(pr);
    if (s % 2 != 0)
    {
        Console.WriteLine(i.ToString() + " " + s);
    }
}