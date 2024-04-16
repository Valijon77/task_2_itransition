using System.Security.Cryptography;
using System.Text;

string path = "./task2";
const string myEmail = "valiizzatullayev@gmail.com";

// Console.WriteLine(SHA3_256.IsSupported);

HashAlgorithm sha = SHA3_256.Create();
List<string> hashes = [];

foreach(string filename in Directory.EnumerateFiles(path))
{
    using FileStream stream = File.Open(filename, FileMode.Open);
    hashes.Add(ByteToString(sha.ComputeHash(stream)).ToLower());
}

// hashes = hashes.OrderBy(x => x);
// foreach(var i in hashes){
//     Console.WriteLine(i);
// }
// Console.WriteLine(hashes);

var hashesWithoutEmail = string.Join("", hashes.OrderBy(x => x));

// Console.WriteLine(hashesWithoutEmail);

var hashesWithEmail = hashesWithoutEmail + myEmail;

// Console.WriteLine(hashesWithEmail);

var computedHash = sha.ComputeHash(Encoding.UTF8.GetBytes(hashesWithEmail));
Console.WriteLine(ByteToString(computedHash));

string ByteToString(byte[] bytes)
{
    var result = "";
    
    foreach (byte b in bytes) 
        result += b.ToString("x2");

    return result;
}