namespace OCR.DigitConversion.Core
{
    public interface  IDigitConverter
    {
        bool CanConvert(char[][] digitLine);
        string Convert(char[][] digitLine);
     
    }
}
