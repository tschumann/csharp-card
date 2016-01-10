
namespace Card
{
    interface ICardPlayer
    {
        Card play();
        void receive(Card card);
    }
}