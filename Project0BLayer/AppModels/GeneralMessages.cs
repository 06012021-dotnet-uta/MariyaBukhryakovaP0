namespace Project0BLayer.AppModels
{
    public class GeneralMessages
    {

        public string WelcomeMessage()
        {
            return "Welcome to Mariya's TechEmporium!/nWhere we have ALL your tech needs!";
        }
        public string RequestNameInfo()
        {
            return "Please input your First and Last Name";

        }
        public void StoreLocationMessage()
        {
            System.Console.WriteLine($"Your chosen store location is:");
        }
    }
}