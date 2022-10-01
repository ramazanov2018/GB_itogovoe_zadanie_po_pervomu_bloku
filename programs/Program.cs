Console.WriteLine("Массив строк");
string[] arList = new string[4]{"hello", "2", "word",":-)"};

string[] ShortsValues(string[] arList, int columnLength = 3)
{
    int count = 0;
    for(int i = 0; i < arList.Length; i++){
        if(arList[i].Length <= columnLength){
            count++;
        }
    }
    string[] arResult = new string[count];
    int z = 0;
    for(int i = 0; i < arList.Length; i++){
        if(arList[i].Length <= columnLength){
            arResult[z] = arList[i];
            z++;
        }
    }
    return arResult;
}

void arPrint(string[] arList)
{
    Console.Write("[");
    for(int i = 0; i < arList.Length; i++){
        Console.Write(arList[i]+",");
    }
    Console.Write("]");
}

string[] arShortValues = ShortsValues(arList, 3);
arPrint(arShortValues);