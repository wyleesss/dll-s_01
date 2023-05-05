using System.Runtime.InteropServices;

public class DllImportExample
{
    // альтернативний варіант (пошук за іменем залежно від параметра поля CharSet)
    [DllImport("User32.dll", CharSet = CharSet.Unicode, ExactSpelling = false)]
    public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

    // перший варіант (пошук за точним іменем)
    [DllImport("User32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
    public static extern int MessageBoxW(IntPtr hWnd, string text, string caption, uint type);
}

class Program
{
    static void Main()
    {
        DllImportExample.MessageBox(IntPtr.Zero, "виконано успішно!", "пошук за кодуванням  ", 0);

        DllImportExample.MessageBoxW(IntPtr.Zero, "виконано успішно!", "пошук за точним іменем", 0);
    }
}