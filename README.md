Demonstration of Compare-NET-object issue
=========================================

This repository demonstrates issue with Compare-NET-object. The library fails
to detect differences between objects:

    var a = (1, new List<(string first, (string, int) second)> { ("foo", ("bar", 2)) });
    var b = (1, new List<(string first, (string, int) second)> { ("foo", ("foo", 2)) });
