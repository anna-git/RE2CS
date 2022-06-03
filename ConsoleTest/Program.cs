// See https://aka.ms/new-console-template for more information

using RE2CS;

const string pattern = @"\[(.*?)\]((?:.\s*)*?)\[\/\1\]";

Console.WriteLine("Hello, World!");
var re = new RE2(pattern);
var m = re.Match("123-123-1234");