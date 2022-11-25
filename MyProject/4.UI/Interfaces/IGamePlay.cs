namespace MyProject._4.UI
{
    public interface IGamePlay
    {
        public string Name { get; set; }
        public int Score { get; set; }  

        public void Play();
       
    }
}