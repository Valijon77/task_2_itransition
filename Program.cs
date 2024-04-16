// using System.Security.Cryptography;

// var sha = SHA256.Create();

// using(FileStream stream = File.OpenRead("as.txt")){
//     Console.WriteLine(sha.ComputeHash(stream));
//     var arr = sha.ComputeHash(stream);
//     // foreach(var i in arr){
//     //     Console.Write(i);
//     // }
//     string strRep = ByteToString(arr);
//     Console.WriteLine(strRep);
// }

// string ByteToString(byte[] bytes){
//     string result = "";
//     foreach (var b in bytes) result += b.ToString("x2");
//     return result;
// }
