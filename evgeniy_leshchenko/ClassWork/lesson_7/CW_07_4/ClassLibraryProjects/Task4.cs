class Task4
{

    public int[] Array = new int[3];


    public void initMass(int[] MyArr)
    {

        MyArr[0] = 2;
        MyArr[1] = 10;
        MyArr[2] = 20;
    }

    public void multiply2(int[] MyArr)
    {

        for (int i = 0; i < MyArr.Length; i++)
        {
            MyArr[i] = MyArr[i] * 2;
        }
    }

    public void MinusA(int[] MyArr, int A)
    {

        for (int i = 0; i < MyArr.Length; i++)
        {
            MyArr[i] = MyArr[i] - A;
        }
    }

    public void DivisionOn1st(int[] MyArr)
    {

        for (int i = 0; i < MyArr.Length; i++)
        {
            MyArr[i] = MyArr[i] / MyArr[0];
        }
    }

    // увеличить в 2 раза
    //уменьшить на число А
    // Разделить на первій єлемент

}