void ShowArray(string[] words)
{
    Console.Write("{ ");
    foreach(string w in words)
    {
        Console.Write( w + " ");
    }
    Console.Write("}");
    //Console.WriteLine();
}

int FindLengthOfNewArray(string[] words)
{
    int count=0;
    foreach(string w in words)
    {
        if(w.Length <= 3) count++;
    }
    return count;
}

string[] CreateNewArray(string[] words, int len)
{
    string[] newWords = new string[len];
    int i = 0;
    foreach(string w in words) 
    {
        if(w.Length <= 3)
        {
            newWords[i] = w;
            i++;
        }
    }
    return newWords; 
}

string[] myArray = new string[7] { "fqwe", "rry", "yt", "rrty", "yyur", "yuyi", "ghyy"};
int myLen = FindLengthOfNewArray(myArray);
if(myLen > 0) 
{
    string[] myNewArray = CreateNewArray(myArray, myLen);
    ShowArray(myArray);
    Console.Write(" -> ");
    ShowArray(myNewArray);
}
else if(myLen == 0)
{
    ShowArray(myArray);
    Console.Write(" -> {  }");
}

