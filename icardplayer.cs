
namespace Card
{
    public interface ICardPlayer
    {
        Card play();
        void receive(Card card);
    }
}