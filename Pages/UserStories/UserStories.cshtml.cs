using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationUserstories1.Services;
using WebApplicationUserstories1.Models;

namespace WebApplicationUserstories1.Pages.UserStories
{
    public class UserStoriesModel : PageModel
    {
        private UserStoryService userStoryService;

        public List<UserStory>? UserStories { get; private set; }

        public UserStoriesModel(UserStoryService userStoryService)
        {
            this.userStoryService = userStoryService;
        }

        
        public void OnGet()
        {
            UserStories = userStoryService.GetUserStories();
        }
    }
}
