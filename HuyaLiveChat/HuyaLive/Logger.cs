﻿
using System;
using System.Diagnostics;
using System.Text;

namespace HuyaLive
{
    public enum LoggerType
    {
        Debug,
        Console,
        ConsoleOut
    }

    public interface Loggerable
    {
        void Print(string message);
        void Print(string format, params object[] args);
        void Write(string message);
        void Write(string format, params object[] args);
        void Write(Exception ex);
        void WriteLine(string message);
        void WriteLine(string format, params object[] args);
        void WriteLine(Exception ex);
        void Flush();
        void Close();
    }

    public class Debugger : Loggerable
    {
        public Debugger() : base()
        {
        }

        public void Close()
        {
            Debug.Close();
        }

        public void Flush()
        {
            Debug.Flush();
        }

        public void Print(string message)
        {
            Debug.Print(message);
        }

        public void Print(string format, params object[] args)
        {
            Debug.Print(format, args);
        }

        public void Write(string message)
        {
            Debug.Write(message);
        }

        public void Write(string format, params object[] args)
        {
            Debug.Print(format, args);
        }

        public void Write(Exception ex)
        {
            Debug.Write(ex.ToString());
        }

        public void WriteLine(string message)
        {
            Debug.WriteLine(message);
        }

        public void WriteLine(string format, params object[] args)
        {
            Debug.WriteLine(format, args);
        }

        public void WriteLine(Exception ex)
        {
            Debug.WriteLine(ex.ToString());
        }
    }

    public class Consoler : Loggerable
    {
        public Consoler() : base()
        {
        }

        public void Close()
        {
            // Not implement
        }

        public void Flush()
        {
            // Not implement
        }

        public void Print(string message)
        {
            Console.Write(message);
        }

        public void Print(string format, params object[] args)
        {
            Console.Write(format, args);
        }

        public void Write(string message)
        {
            Console.Write(message);
        }

        public void Write(string format, params object[] args)
        {
            Console.Write(format, args);
        }

        public void Write(Exception ex)
        {
            Console.Write(ex.ToString());
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public void WriteLine(string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }

        public void WriteLine(Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    public class ConsoleOut : Loggerable
    {
        public ConsoleOut() : base()
        {
        }

        public void Close()
        {
            Console.Out.Close();
        }

        public void Flush()
        {
            Console.Out.Flush();
        }

        public void Print(string message)
        {
            Console.Out.Write(message);
        }

        public void Print(string format, params object[] args)
        {
            Console.Out.Write(format, args);
        }

        public void Write(string message)
        {
            Console.Out.Write(message);
        }

        public void Write(string format, params object[] args)
        {
            Console.Out.Write(format, args);
        }

        public void Write(Exception ex)
        {
            Console.Out.Write(ex.ToString());
        }

        public void WriteLine(string message)
        {
            Console.Out.WriteLine(message);
        }

        public void WriteLine(string format, params object[] args)
        {
            Console.Out.WriteLine(format, args);
        }

        public void WriteLine(Exception ex)
        {
            Console.Out.WriteLine(ex.ToString());
        }
    }

    public class Logger : Loggerable
    {
        private Loggerable tracer = null;

        public Logger(Loggerable tracer)
        {
            SetInstance(tracer);
        }

        public void SetInstance(Loggerable tracer)
        {
            this.tracer = tracer;
        }

        public void Print(string message)
        {
            if (tracer != null)
            {
                tracer.Print(message);
            }
        }

        public void Print(string format, params object[] args)
        {
            if (tracer != null)
            {
                tracer.Print(format, args);
            }
        }

        public void Write(string message)
        {
            if (tracer != null)
            {
                tracer.Write(message);
            }
        }

        public void Write(string format, params object[] args)
        {
            if (tracer != null)
            {
                tracer.Write(format, args);
            }
        }

        public void Write(Exception ex)
        {
            if (tracer != null)
            {
                tracer.Write(ex.ToString());
            }
        }

        public void WriteLine(string message)
        {
            if (tracer != null)
            {
                tracer.WriteLine(message);
            }
        }

        public void WriteLine(string format, params object[] args)
        {
            if (tracer != null)
            {
                tracer.WriteLine(format, args);
            }
        }

        public void WriteLine(Exception ex)
        {
            if (tracer != null)
            {
                tracer.WriteLine(ex.ToString());
            }
        }

        public void Enter(string message)
        {
            if (tracer != null)
            {
                tracer.WriteLine("-------------------------------------------");
                tracer.WriteLine(message + " enter.");
            }
        }

        public void Leave(string message)
        {
            if (tracer != null)
            {
                tracer.WriteLine(message + " leave.");
                tracer.WriteLine("-------------------------------------------");
            }
        }

        public void Flush()
        {
            tracer.Flush();
        }

        public void Close()
        {
            tracer.Close();
        }

        static public void Print(ClientListener listener, string message)
        {
            if (listener != null)
            {
                listener.Print(message);
            }
        }

        static public void Print(ClientListener listener, string format, params object[] args)
        {
            if (listener != null)
            {
                listener.Print(format, args);
            }
        }

        static public void Write(ClientListener listener, string message)
        {
            if (listener != null)
            {
                listener.Write(message);
            }
        }

        static public void Write(ClientListener listener, string format, params object[] args)
        {
            if (listener != null)
            {
                listener.Write(format, args);
            }
        }

        static public void Write(ClientListener listener, Exception ex)
        {
            if (listener != null)
            {
                listener.Write(ex.ToString());
            }
        }

        static public void WriteLine(ClientListener listener, string message)
        {
            if (listener != null)
            {
                listener.WriteLine(message);
            }
        }

        static public void WriteLine(ClientListener listener, string format, params object[] args)
        {
            if (listener != null)
            {
                listener.WriteLine(format, args);
            }
        }

        static public void WriteLine(ClientListener listener, Exception ex)
        {
            if (listener != null)
            {
                listener.WriteLine(ex.ToString());
            }
        }

        static public void Flush(ClientListener listener)
        {
            if (listener != null)
            {
                listener.FlushLog();
            }
        }

        static public void Close(ClientListener listener)
        {
            if (listener != null)
            {
                listener.CloseLog();
            }
        }

        static public void Enter(ClientListener listener, string message)
        {
            if (listener != null)
            {
                listener.WriteLine("-------------------------------------");
                listener.WriteLine(message + " enter.");
            }
        }

        static public void Leave(ClientListener listener, string message)
        {
            if (listener != null)
            {
                listener.WriteLine(message + " leave.");
                listener.WriteLine("-------------------------------------");
            }
        }
    }
}