namespace Telvee32.MinesweeperCore.Common.Communication.Response
{
    public abstract class BaseResponse
    {
        public string Message { get; set; }
        public ResponseStatus Status { get; set; }
        public GameStatus GameStatus { get; set; }
    }

    public enum ResponseStatus
    {
        Ok, Error
    }
}
