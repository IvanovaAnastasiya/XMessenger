namespace ClientAPI.View
{
    public interface IView<out TController>
    {
        TController Presenter { get; }
    }
}