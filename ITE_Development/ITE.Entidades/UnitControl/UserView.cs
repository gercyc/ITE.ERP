namespace ITE.Entidades.UnitControl
{
    public class UserView
    {
        public string Nickname { get; set; }
        public UserView()
        {

        }

        public override string ToString()
        {
            return Nickname;
        }
    }
}
