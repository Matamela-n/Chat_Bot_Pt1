
using System;
using System.Drawing;


namespace Chat_Bot_Pt1
{
    public class AsciiArt
    {
  public void DisplayLogo() 
  { //this is the start of the constructor
   ascii();

}//end of the constructor

private void ascii()
 {
  string path = string.Empty;
  string fullpath = AppDomain.CurrentDomain.BaseDirectory;
  path = fullpath.Replace(@"bin\Debug\", "logo.png");

 Bitmap image = new Bitmap(path);

 int width = 300;
 int height = 150;
 Bitmap resized = new Bitmap(image, new Size(width, height));
Console.ForegroundColor = ConsoleColor.Red;

 string asciiChars = "@##SS%%??**++;;::,,.. ";

 for (int y = 0; y < resized.Height; y++)
{
for (int x = 0; x < resized.Width; x++)
{
 Color pixel = resized.GetPixel(x, y);
    int gray = (pixel.R + pixel.G + pixel.B) / 3;
     int index = (gray * (asciiChars.Length - 1)) / 255;
 Console.Write(asciiChars[index]);

  }
  Console.WriteLine();
 }
}
 }
 }    

