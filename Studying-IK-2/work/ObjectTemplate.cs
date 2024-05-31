using System;

namespace Studying_IK_2.work
{
    internal class ObjectTemplate
    {
        // Properties
        public int IntProperty { get; set; } = 10;
        public string StringProperty { get; set; } = "some string";
        public bool BoolProperty { get; set; } = false;

        public void ToggleBoolProperty()
        {
            BoolProperty = !BoolProperty;
        }
    }

    public class ObjectTemp3
    {
        // Properties
        public int IntProperty { get; set; } = 10;
        public string StringProperty { get; set; } = "class c#";
        public string StringProperty2 { get; set; } = "Name-Isaac";
        public bool BoolProperty { get; set; } = false;

        public void ToggleBoolProperty()
        {
            BoolProperty = !BoolProperty;
        }

        public void Print()
        {
            Console.WriteLine($"StringProperty1: {StringProperty}, StringProperty2: {StringProperty2}");
        }
    }

    public class TestBasicObject
    {
        public static void Demo()
        {
            ObjectTemplate template1 = new ObjectTemplate();

            Console.WriteLine("Template 1 = IntProperty = {0} , StringProperty = {1}, BoolProperty = {2}",
                template1.IntProperty, template1.StringProperty, template1.BoolProperty);

            template1.BoolProperty = true;
            template1.StringProperty = "another string";
            //template1.IntProperty = 20;

            Console.WriteLine("Template 1 = IntProperty = {0} , StringProperty = {1}, BoolProperty = {2}",
                template1.IntProperty, template1.StringProperty, template1.BoolProperty);

            ObjectTemp3 template2 = new ObjectTemp3();

            Console.WriteLine("Template 2 = IntProperty = {0} , StringProperty = {1}, BoolProperty = {2}",
                template2.IntProperty, template2.StringProperty, template2.BoolProperty);

            template2.Print();
        }
    }
}
