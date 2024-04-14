using Core;

namespace ConsoleApp
{
    internal class Classroom
    {
        public string Name { get; internal set; }
        public int Id { get; internal set; }
        public IEnumerable<object> Students { get; internal set; }

        internal void AddStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}