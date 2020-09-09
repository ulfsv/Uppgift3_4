using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3_4
{
    abstract class UserError
    {
        public abstract string UEMessage();
    }

    class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }
    class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text  input in a numeric only field. This fired an error!";
        }
    }
    class NumericInputStatus : UserError
    {
        public override string UEMessage()
        {
            return "Numeric input is ongoing";
        }
    }

    class TextToLongError : UserError
    {
        public override string UEMessage()
        {
            return "Text is too long.";
        }
    }
}