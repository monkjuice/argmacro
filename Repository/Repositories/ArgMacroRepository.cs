using System;

namespace Repository
{
    public class ArgMacroRepository
    {
        public ArgMacroContext Context { get; set; }

        public ArgMacroRepository()
        {
            Context = new ArgMacroContext();
        }

    }
}
