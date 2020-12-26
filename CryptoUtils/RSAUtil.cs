using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CryptoUtils
{
    public class RSAUtil
    {
        /// <summary>
        /// 生成密钥对
        /// </summary>
        /// <returns></returns>
        public static (string publicKey, string privateKey) generateRSAKeyPair()
        {
            var generator = new RsaKeyPairGenerator();
            var param = new RsaKeyGenerationParameters(Org.BouncyCastle.Math.BigInteger.ValueOf(3), new SecureRandom(), 2048, 25);
            generator.Init(param);
            var pair = generator.GenerateKeyPair();
            var publicKeyInfo = SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(pair.Public);
            var publicKey = Convert.ToBase64String(publicKeyInfo.GetEncoded());
            var pemObject = new Pkcs8Generator(pair.Private).Generate();
            var privateKey = Convert.ToBase64String(pemObject.Content);
            return (publicKey, privateKey);
        }

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="data"></param>
        /// <param name="publicKey"></param>
        /// <returns></returns>
        public static string Encrypt(string data, string publicKey)
        {
            var rsaKeyParameters = (RsaKeyParameters)PublicKeyFactory.CreateKey(Convert.FromBase64String(publicKey));
            var engine = new Pkcs1Encoding(new RsaEngine());
            engine.Init(true, rsaKeyParameters);
            var input = Encoding.UTF8.GetBytes(data);
            var output = new List<byte>();
            var size = Math.Min(engine.GetInputBlockSize(), input.Length);
            for (var i = 0; i < input.Length; i+= size)
            {
                output.AddRange(engine.ProcessBlock(input, i, size));
            }
            return Convert.ToBase64String(output.ToArray());
        }

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="content"></param>
        /// <param name="privateKey"></param>
        /// <param name="isPKCS8"></param>
        /// <returns></returns>
        public static string Decrypt(string content, string privateKey, bool isPKCS8 = true)
        {
            var privateKeyParameters = getPrivateKeyParameters(privateKey, isPKCS8);
            var input = Convert.FromBase64String(content);
            var engine = new Pkcs1Encoding(new RsaEngine());
            engine.Init(false, privateKeyParameters);
            var output = new List<byte>();
            var size = Math.Min(engine.GetInputBlockSize(), input.Length);
            for (var i = 0; i < input.Length; i += size)
            {
                output.AddRange(engine.ProcessBlock(input, i, size));
            }
            return Encoding.UTF8.GetString(output.ToArray());
        }

        private static RsaPrivateCrtKeyParameters getPrivateKeyParameters(string privateKey, bool isPKCS8)
        {
            string sign = isPKCS8 ? " " : " RSA ";
            privateKey = new StringBuilder().AppendLine($"-----BEGIN{sign}PRIVATE KEY-----").AppendLine(privateKey).AppendLine($"-----END{sign}PRIVATE KEY-----").ToString();
            return (RsaPrivateCrtKeyParameters)new PemReader(new StringReader(privateKey)).ReadObject();

        }

        /// <summary>
        /// 用私钥签名
        /// </summary>
        public static string SignWithSHA256(string data, string privateKey, bool isPKCS8 = true)
        {
            var privateKeyParameters = getPrivateKeyParameters(privateKey, isPKCS8);
            var input = Encoding.UTF8.GetBytes(data);
            var signer = SignerUtilities.GetSigner("SHA-256withRSA");
            signer.Init(true, privateKeyParameters);
            signer.BlockUpdate(input, 0, input.Length);
            byte[] sigBytes = signer.GenerateSignature();
            return Convert.ToBase64String(sigBytes);
        }
    }
}
