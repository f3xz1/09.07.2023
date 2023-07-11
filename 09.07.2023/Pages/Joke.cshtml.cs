using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _09._07._2023.Pages
{
    public class JokeModel : PageModel
    {
        public string Joke { get; set; }
        public JokesService JokesService { get; set; } = new JokesService();

        public async Task OnGetAsync()
        {
            Joke = await JokesService.GetJokeAsync();
        }
    }
}
