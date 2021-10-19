using System;

namespace SerialPort
{
    class WindowsSerialPort
    {
        public static void setBaud()
        {

        }
        public static void setNumBits()
        {

        }
        public static void wait()
        {

        }
    }

    class LinuxSerialPort
    {
        public static void setConnection()
        {

        }
        public static void setBaudAndBits()
        {

        }
    }
    class SerialPort
    {
        static string OS;
        SerialPort(string _OS)
        {
            OS = _OS;            
        }

        public static void Open()
        {
            if (OS == "WINDOWS")
            {
                WindowsSerialPort.setBaud();
                WindowsSerialPort.setNumBits();
                WindowsSerialPort.wait();
            }
            else if (OS == "LINUX")
            {
                LinuxSerialPort.setBaudAndBits();
                LinuxSerialPort.setConnection();
            }
        }
    }

    class Program
    {
        static string OS;
        static void Main(string[] args)
        {
            // This simply opens the serial connection, regardless to the OS
            SerialPort.Open();           
        }
    }
}
