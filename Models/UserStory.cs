

namespace WebApplicationUserstories1.Models
{
    public class UserStory
    {
        private static int nextId=0;
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }

        void NextID()
        {
            nextId++;
            Id = nextId;
        }

        public UserStory()
        {
            NextID();
            Title = "";
            Description = "";
        }

        public UserStory(string title, string description)
        {
            NextID();
            Title = title;
            Description = description;
        }


    }
}
