/*

Difference Between == and Equals():

    == Operator:
        Compares the references (memory addresses) of two objects to see if they refer to the same instance. However, 
        when used with strings, the == operator is overridden by the String class to compare the values of the strings 
        (their contents) instead of their references.
        Can be used for both reference and value types, and when used with strings, it typically compares the values of the strings.

    Equals() Method:
        Also compares the values of two strings to check if they are equal.
        The Equals() method is more explicit and is considered to be a better practice when comparing strings, 
        especially if the comparison is intended to be case-sensitive or if the comparison logic might be more complex in the future.

When to Use:

    Use == when you need a quick comparison of two strings and are confident in the comparison logic (e.g., for simple cases).
    Use Equals() when you want to make it explicit that you are comparing the values of two strings, 
    especially when considering case sensitivity, or if you want to compare with options like ignoring case.


    Explanation:

    Line 1: Console.WriteLine(str1 == str2);
        Output: True
        Reason: str1 and str2 both refer to the same string literal "Hello" in memory 
        due to string interning in C#. The == operator compares their values, which are identical.

    Line 2: Console.WriteLine(str1 == str3);
        Output: True
        Reason: Even though str3 is created with the new keyword 
        (which typically creates a new object in memory), the == operator 
        in the String class is overridden to compare the content of the strings, not their references. 
        Since the content of str1 and str3 are the same ("Hello"), the comparison returns True.

    Line 3: Console.WriteLine(str1.Equals(str3));
        Output: True
        Reason: The Equals() method compares the values of str1 and str3. 
        Since their content is the same ("Hello"), this comparison returns True.

*/