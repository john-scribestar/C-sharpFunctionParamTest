namespace CSharpfunctionParamTest
{
  using System;
  using System.Drawing;
  using System.Drawing.Imaging;

  public class Program
  {
    public static void Main(string[] args)
    {
      CreateAndTestfunction();
    }

    public static void CreateAndTestfunction()
    {
      var b = new Bitmap(500, 500, PixelFormat.Format32bppArgb);
      MethodAcecptingtestFunction(() => Testfunction(b));
    }

    public static void MethodAcecptingtestFunction(Func<Bitmap> testFunc)
    {
      using (var b = testFunc())
      {
        Console.Write(b);
      }
    }

    public static Bitmap Testfunction(Bitmap b)
    {
      return b;
    }
  }
}
