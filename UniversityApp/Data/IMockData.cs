namespace UniversityApp.Data;

internal interface IMockData<T>
{
    public List<T> Data { get; set; }
}