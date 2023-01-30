public class Class1
{
    public int CalculatA()
    {
        //commented code
        int count = 1;
        for (int i = 0; i < 10; i++)
        {
            count++;
        }
        return count;
    }

    public int CalculatB()
    {
        int count = 1;
        for (int i = 0; i < 10; i++)
        {
            count++;
        }
        count += 50;
        return count;
    }

    public int CalculatC()
    {
        int count = 0;
        string code = "5";
        switch (count)
        {
            case "1":
                count = 1;
                break;
            case "2":
                count = 2;
                break;
            case "4":
                count = 4;
                break;
        }
        return count;
    }

}