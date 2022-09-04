using WebApplicationUserstories.Models;
using WebApplicationUserstories.MockData;


namespace WebApplicationUserstories.Services
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
