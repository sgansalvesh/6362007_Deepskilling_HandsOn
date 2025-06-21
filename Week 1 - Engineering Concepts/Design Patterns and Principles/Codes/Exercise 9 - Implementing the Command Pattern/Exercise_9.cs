using System;

namespace CommandPatternExample
{
    public interface ICommand
    {
        void Execute();
    }

    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("The light is ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("The light is OFF");
        }
    }

    public class LightOnCommand : ICommand
    {
        private Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }
    }

    public class LightOffCommand : ICommand
    {
        private Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }
    }

    public class RemoteControl
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Light livingRoomLight = new Light();
            ICommand lightOn = new LightOnCommand(livingRoomLight);
            ICommand lightOff = new LightOffCommand(livingRoomLight);

            RemoteControl remote = new RemoteControl();

            remote.SetCommand(lightOn);
            remote.PressButton();

            remote.SetCommand(lightOff);
            remote.PressButton();
        }
    }
}
