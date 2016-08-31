namespace Session08
{
    public partial class Student
    {
        public long Id { get; set; }
        public string FullName { get; set; }

        public Student(long id, string fullname)
        {
            Id = id;
            FullName = fullname;
        }
    }
}
