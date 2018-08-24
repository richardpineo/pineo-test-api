namespace PineoTest.Models
{
    public class HelloWorldItem
    {
        public HelloWorldItem() {
            this.Salutation = "Hello, world.";
        }
        public string Salutation { get; set; }
        public long Id {get; set;}
    }
}