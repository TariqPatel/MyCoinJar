using System;
namespace MyCoinJarApp.Core.Models
{
    public class RadioButton
    {
        public string Caption { get; set; }
        public RadioButton(string caption)
        {
            Caption = caption;
        }
    }
}
