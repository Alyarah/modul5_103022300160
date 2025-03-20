// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

public class SimpleDataBase <T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public void SimpleDataBae()
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime);
    }

    public void PrintAllData()
    {
        
    }

    class program
    {
        
    }
}
