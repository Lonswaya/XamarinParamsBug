using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XamarinParamsBug
{
    public class StringTrimmer
    {
        private char charToTrim;
        public StringTrimmer(char charToTrim)
        {
            this.charToTrim = charToTrim;
        }
        public string TrimString(string toTrim)
        {
            return toTrim.Trim(charToTrim);
        }

        public string TrimStringWorkaround(string toTrim)
        {
            return toTrim.Trim(new char[charToTrim]);
        }

        public static string TrimSpaces(string toTrim)
        {
            return toTrim.Trim();
        }
    }
}