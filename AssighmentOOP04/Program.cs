using AssighmentOOP04.Interfaces;
using System.Text;

namespace AssighmentOOP04
{
    internal class Program
    {
        public static void Share(INotificationService notificationService)
        {
            Console.WriteLine("Enter Message");
            string mes = Console.ReadLine();
            if(notificationService != null)
            {
                Console.WriteLine(notificationService.SendNotification(mes));
            }
        }
        static void Main(string[] args)
        {
            #region Part01
            #region Q1 
            /*What is the primary purpose of an interface in C#?*/
            //a) To provide a way to implement multiple inheritance
            #endregion
            #region Q2
            /*Which of the following is NOT a valid access modifier for interface members in C#?*/
            //a) private
            #endregion
            #region Q3
            /*Can an interface contain fields in C#?*/
            //b) No
            #endregion
            #region Q4
            /*In C#, can an interface inherit from another interface?*/
            //b)Yes, interfaces can inherit from multiple interfaces
            #endregion
            #region Q5
            /*Which keyword is used to implement an interface in a class in C#?*/
            //d) implements
            #endregion
            #region Q6
            /*Can an interface contain static methods in C#?*/
            //a) Yes
            #endregion
            #region Q7
            /*In C#, can an interface have explicit access modifiers for its members?*/
            //b) No, all members are implicitly public
            #endregion
            #region Q8
            /*What is the purpose of an explicit interface implementation in C#?*/
            //b) To provide a clear separation between interface and class members
            #endregion
            #region Q9
            /*In C#, can an interface have a constructor?*/
            //b) No, interfaces cannot have constructors
            #endregion
            #region Q10
            /*How can a C# class implement multiple interfaces?*/
            //c) By separating interface names with commas
            #endregion
            #endregion
            #region Part02
            #region Q1
            /*Define an interface named IShape with a property Area and a method DisplayShapeInfo.
             * Create two interfaces, ICircle and IRectangle, that inherit from IShape. Implement these
             * interfaces in classes Circle and Rectangle. 
             * Test your implementation by creating instances of both classes and displaying their shape information.
             */
            Circle circle = new Circle();
            //ICircle circle = new Circle();
            circle.Area = 50;
            Console.WriteLine($"Area is a {circle.Area}");
            circle.DisplayShapeInfo();
            Rectangle rectangle = new Rectangle();
            rectangle.Area = 100;
            Console.WriteLine($"Area Rectangle is a {rectangle.Area}.");
            rectangle.DisplayShapeInfo();
            #endregion
            #region Q2
            /* In this example, we start by defining the IAuthenticationService interface
             * with two methods: AuthenticateUser and AuthorizeUser.
             * The BasicAuthenticationService class implements this interface and
             * provides the specific implementation for these methods.
             * In the BasicAuthenticationService class, the AuthenticateUser method compares
             * the provided username and password with the stored credentials.
             * It returns true if the user is authenticated and false otherwise.
             * The AuthorizeUser method checks if the user with
             * the given username has the specified role.
             * It returns true if the user is authorized and false otherwise.
             * */
            //BasicAuthenticationService[] basic = new BasicAuthenticationService[4]
            //{
            //    new BasicAuthenticationService(){ UserName ="Mo@8299", Password = "1999" },
            //    new BasicAuthenticationService(){ UserName ="yora259", Password = "1999" },
            //    new BasicAuthenticationService(){ UserName ="Aya5299", Password = "Aya5299" },
            //    new BasicAuthenticationService(){ UserName ="Ali1099", Password = "Ali1099" }
            //};
            IAuthenticationService authService = new BasicAuthenticationService()
            {

                UserName = "Mohamed", //true
                Password = "Mohamed"  //true

            };
            authService.AuthenticateUser();
            authService.AuthorizeUser();

            #endregion
            #region Q3
            /*we define the INotificationService interface with a method SendNotification that takes a recipient and a message as parameters.
            We then create three classes: EmailNotificationService, SmsNotificationService, and PushNotificationService,
            which implement the INotificationService interface.
            In each implementation, we provide the logic to send notifications through the respective communication channel:
            The EmailNotificationService class simulates sending an email by outputting a message to the console.
            The SmsNotificationService class simulates sending an SMS by outputting a message to the console.
            The PushNotificationService class simulates sending a push notification by outputting a message to the console.
            In the Main method, we create instances of each notification service class
            and call the SendNotification method with sample recipient and message values.
            This implementation allows you to easily switch between different notification
            channels by creating new classes that implement the INotificationService interface
            and provide the specific logic for each channel



             */
            EmailNotificationService service = new EmailNotificationService();
            service.EMail = "Mohamed@yahoo.com";
            Share(service);
            SmsNotificationService smsService = new SmsNotificationService();
            smsService.SMs = "01276738534";
            Share(smsService);
            PushNotificationService pushService = new PushNotificationService();
            Share(pushService);

            

            #endregion
            #endregion
        }
    }
}
