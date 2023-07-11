namespace _09._07._2023
{
    public class JokesService
    {
        public async Task<string> GetJokeAsync()
        {
            string? result;
            HttpClient client = new();

            HttpResponseMessage message = await client.GetAsync("https://v2.jokeapi.dev/joke/Any?format=txt");

            if (message.IsSuccessStatusCode)
            {
                result = await message.Content.ReadAsStringAsync();
                if (result != null)
                {
                    await Console.Out.WriteLineAsync(result);
                    return result;
                }
                throw new NullReferenceException();
            }
            throw new HttpRequestException();
        }


    }
}
