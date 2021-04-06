using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Math;
using Base58Check;

namespace BitCoin
{
    class Program
    {
        static void Main(string[] args)

        {   // Elliptic Curve
            X9ECParameters ec = SecNamedCurves.GetByName("secp256k1");
            ECDomainParameters domainParams = new ECDomainParameters(ec.Curve, ec.G, ec.N, ec.H);
            SecureRandom random = new SecureRandom();

            // Generate EC KeyPair
            ECKeyPairGenerator keyGen = new ECKeyPairGenerator();
            ECKeyGenerationParameters keyParams = new ECKeyGenerationParameters(domainParams, random);
            keyGen.Init(keyParams);
            AsymmetricCipherKeyPair keyPair = keyGen.GenerateKeyPair();

            ECPrivateKeyParameters privateKeyParams = keyPair.Private as ECPrivateKeyParameters;
            ECPublicKeyParameters publicKeyParams = keyPair.Public as ECPublicKeyParameters;

            // Get Private Key
            BigInteger privD = privateKeyParams.D;
            byte[] privBytes = privD.ToByteArray();

            if(privBytes.Length == 33)
            {
                var temp = new byte[32];
                Array.Copy(privBytes, 1, temp, 0, 32);
                privBytes = temp;

            }
            else if (privBytes.Length < 32)
            {
                var temp = Enumerable.Repeat<byte>(0x00, 32).ToArray();
                Array.Copy(privBytes, 0, temp, 32 - privBytes.Length, privBytes.Length);
                privBytes = temp;
            }
            string privKey = BitConverter.ToString(privBytes).Replace("-", "");
            //Get compressed Public Key
            EcPoint q = publicKeyParams.Q;
            FpPoint fp = new FpPoint(ec.Curve, q.AffineXCoord, q.AffineCoord);
            byte[] enc = fp.GetEncoded(true);
            string compressedPubKey = BitConverter.ToString(enc).Replace("-", "");
            //Get Uncompressed Public Key
            enc = fp.GetEncoded(false);
            string uncompressedPubKey = BitConverter.ToString(enc).Replace('-', "");
            //출력
            Console.WriteLine(privKey);
            Console.WriteLine(compressedPubKey);
            Console.WriteLine(uncompressedPubKey);



            // C# 비트코인 주소 생성
            // Sample public key
            string sPubKey = "03CEA90F438580ED05F3A9D976EB31783D7AE3825D7C1E499E31F4F9DF5243E392";
            BigInteger pubKey = new BigInteger(sPubKey, 16);
            byte[] publicKey = pubKey.ToByteArray();

            // (1) SHA256 hash
            var sha256 = SHA256.Create();
            var shaHash = sha256.ComputeHash(publicKey);

            // (2) RIPEMD160 hash
            var ripemd160 = RIPEMD160.Create();
            var mdHash = ripemd160.ComputeHash(shaHash);

            // (3) Prefix version byte
            var xmdHash = new byte[mdHash.Length + 1];
            xmdHash[0] = 0x00; // Main network (0x00), Testnet3 (0x6f)
            Array.Copy(mdHash, 0, xmdHash, 1, mdHash.Length);

            // (4) Calc checksum
            var doubleHash = sha256.ComputeHash(sha256.ComputeHash(xmdHash));
            var checksum = new byte[4];
            Array.Copy(doubleHash, 0, checksum, 0, 4); // the first 4 bytes

            // (5) Add checksum at th end of Step 3
            // 25 bytes binary Bitcoin address
            var binAddr = new byte[25];
            Array.Copy(xmdHash, 0, binAddr, 0, 21);
            Array.Copy(checksum, 0, binAddr, 21, 4);

            // (6) Base58check encoding
            string address = Base58CheckEncoding.EncodePlain(binAddr);

            Console.WriteLine(address);
            // Output: 1PJ2er3A8sh2M7S9tGuhxRmRizTM2fCHqU
            public static byte [] GetHash160FromAddress( string address)
            {
                byte [] addrBytes = Base58CheckEncoding.DecodePlain(address);
                byte[] hash160 = new byte[20];
                Array.Copy(addrBytes, 1, hash160, 0, 20);
                return hash160;

             }
            byte[] hash160 = GetHash160FromAddress("mgzQkAs8XACLdE1GRx6RzaSFoGkw9RCXnT");

        }
    }
}
