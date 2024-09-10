
class Book
{
    public string name { get; private set; }// get allows any external class to read the value; private set allows only methods within the class to change the value
    public int year { get; private set; }
    public string author { get; private set; }
    public Book(string name, int year, string author)
    {
        this.name = name;
        this.year = year;
        this.author = author;
    }
    public override string ToString() //ToString() method converts an object to its string representation
    {
        return $"\"{name}\" (author:{author}; year:{year})";
    }
}