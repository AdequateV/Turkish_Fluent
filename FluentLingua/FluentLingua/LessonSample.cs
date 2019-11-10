namespace FluentLingua
{
    public class LessonSample
    {
        public string LessonName { get; set; }
        public int LessonNumber { get; set; }

        public LessonSample(string LName, int LNumber)
        {
            LessonNumber = LNumber;
            LessonName = LName;
        }
    }
}
