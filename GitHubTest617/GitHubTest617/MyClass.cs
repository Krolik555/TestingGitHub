using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTest617
{
    public class MyClass
    {
        public delegate void CallBack(int Value); // When running the "Count" Method, a user can use this delegate to pass a method
                                                  // into the "Count" Metho as long as it matches this delegate.
        public delegate void EndingMethod();

        public void Count(CallBack MethodPassedIn)
        {
            for (int i = 0; i < 10; i++)
            {
                // do stuff


                MethodPassedIn(i); // Run the method passed in and pass into THAT method the value 'i' 
                                   // which was declared in this "Count" method. -- method-ception.
            }
        }
        public void Count(CallBack MethodPassedIn, EndingMethod Finished)
        {
            for (int i = 0; i<10; i++)
            {
                // do stuff


                MethodPassedIn(i); // Run the method passed in and pass into THAT method the value 'i' 
                                   // which was declared in this "Count" method. -- method-ception.
            }

            Finished();
        }
    }
}
