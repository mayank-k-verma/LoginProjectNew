namespace LoginProject.Models;

public class SignUpModel{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string JwtToken { get; set; } = "";
}