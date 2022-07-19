




static void OddArray(int num){
    int odd = num/2 + 1;
    int[] oddNums = new int[odd];
    int index = 0;
    for( int i = 1; i <= num; i = i + 2){
        oddNums[index] = i;
        Console.WriteLine(oddNums[index]);
        index++;
    }
}


OddArray(255);
