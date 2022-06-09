namespace Bookish.Models;

public class CheckedOutBook
{
    public int Id { get; set; }
    public int Copy_Id { get; set; }
    public int Member_Id { get; set; }
    public DateOnly Due_Date { get; set; }
    public Boolean Checked_Out { get; set; }

}