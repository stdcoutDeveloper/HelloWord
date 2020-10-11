using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    [Flags] // Don't forget to add the Flags attribute.
    public enum ForumPrivileges
    {
        CreatePosts = 1 << 0, // 1 or 00000001
        EditOwnPosts = 1 << 1, // 2 or 00000010
        VoteOnPosts = 1 << 2, // 4 or 00000100
        EditOthersPosts = 1 << 3, // 8 or 00001000
        DeletePosts = 1 << 4, // 16 or 00010000
        CreateThreads = 1 << 5, // 32 or 00100000
        Suspended = 1 << 6, // 64 or 01000000
                            // Note we can also add in "shortcuts" here:
        None = 0,
        BasicUser = CreatePosts | EditOwnPosts | VoteOnPosts,
        Administrator = BasicUser | EditOthersPosts | DeletePosts | CreateThreads
    }

    class NullableTypes
    {
        public NullableTypes()
        {
        }

        public NullableTypes(int number)
        {
        }

        public void Test()
        {
            Nullable<bool> isFound = null;
            bool? isStop = null;
            if (isStop.HasValue)
            {
                bool realValue = isStop.Value;
            }

            bool actualValue = isStop ?? false;

            int result = 0b00001101 >> 2; // Binary literal 13
            Console.WriteLine(result);
            Console.WriteLine(0b00001101 << 2);

            ForumPrivileges privileges = ForumPrivileges.BasicUser;
            privileges |= ForumPrivileges.Suspended; // Turn on the 'suspended' field
            bool isSuspended = (privileges & ForumPrivileges.Suspended) == ForumPrivileges.Suspended;
            // turn off a particular field
            privileges &= ~ForumPrivileges.Suspended;
            // toggle a field
            privileges ^= ForumPrivileges.DeletePosts;

            Type type = typeof(int);
            Type typeOfClass = typeof(NullableTypes);
            Console.WriteLine(type + " " + typeOfClass);
        }

        public void DoFooThings(int number)
        {
        }

        ~NullableTypes()
        {
            Console.WriteLine("Destructor was called.");
        }
    }

    class NullableTypesTest
    {
        public void Test()
        {
            NullableTypes myObject = new NullableTypes();
            Type type = myObject.GetType();
            Console.WriteLine(type);

            ConstructorInfo[] contructors = type.GetConstructors();
            foreach (var element in contructors)
                Console.WriteLine(element);

            MethodInfo[] methods = type.GetMethods();
            foreach (var element in methods)
                Console.WriteLine(element);

#if DEBUG
            ConstructorInfo constructor = type.GetConstructor(new Type[] { typeof(int) });
            Console.WriteLine(constructor);
            MethodInfo method = type.GetMethod("DoFooThings", new Type[] { typeof(int) });
            Console.WriteLine(method);
#endif

            #region Any region name you want here
            object newObject = constructor.Invoke(new object[] { 17 });
            method.Invoke(newObject, new object[] { 4 });
            #endregion

            //using (FileStream fileStream = File.OpenWrite("test.txt"))
            //{
            //}
        }
    }
}
