namespace PregledPlus.Repository
{
    public interface IUnitOfWork
    {
        ITerminRepository TerminRepository { get; }
        IVoziloRepository VoziloRepository { get; } 
        IUslugaRepository UslugaRepository { get; }
        INewsletterRepository NewsletterRepository { get; } 
        IApplicationUserRepository ApplicationUserRepository { get; }
        void Save();
    }
}
