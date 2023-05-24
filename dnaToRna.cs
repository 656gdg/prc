
        // Create a function which translates a given DNA string into RNA. For example: "GCAT"  =>  "GCAU"
        // The input string can be of arbitrary length - in particular, it may be empty.
        // All input is guaranteed to be valid, i.e. each input string will only ever consist of 'G', 'C', 'A' and/or 'T'.

        public string dnaToRna(string dna)
        {
            return dna.Replace('T', 'U');
        }
