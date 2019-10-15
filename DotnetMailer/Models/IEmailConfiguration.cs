namespace DotnetMailer.Models
{
    public interface IEmailConfiguration
    {
        global::System.String SmtpPassword { get; set; }
        global::System.Int32 SmtpPort { get; set; }
        global::System.String SmtpServer { get; set; }
        global::System.String SmtpUsername { get; set; }
    }
}