using WebApplicationUserstories1.Models;
using WebApplicationUserstories1.MockData;


namespace WebApplicationUserstories1.Services
{
    public class UserStoryService
    {
        private List<UserStory>? userStories;
        
        public UserStoryService()
        {
            userStories= MockUserStories.GetMockUserStories();
        }

        public List<UserStory> GetUserStories()
        {
            return userStories;
        }
    }

    

}
