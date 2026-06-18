using System;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Extension;

namespace Server.Helper;

public static class CreateCertificate
{
	public static X509Certificate2 CreateCertificateAuthority(string caName, int keyStrength)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		SecureRandom val = new SecureRandom((IRandomGenerator)new CryptoApiRandomGenerator());
		RsaKeyPairGenerator val2 = new RsaKeyPairGenerator();
		val2.Init(new KeyGenerationParameters(val, keyStrength));
		AsymmetricCipherKeyPair val3 = val2.GenerateKeyPair();
		X509V3CertificateGenerator val4 = new X509V3CertificateGenerator();
		X509Name val5 = new X509Name("CN=" + caName);
		BigInteger serialNumber = BigInteger.ProbablePrime(120, (Random)(object)val);
		val4.SetSerialNumber(serialNumber);
		val4.SetSubjectDN(val5);
		val4.SetIssuerDN(val5);
		val4.SetNotAfter(DateTime.MaxValue);
		val4.SetNotBefore(DateTime.UtcNow.Subtract(new TimeSpan(2, 0, 0, 0)));
		val4.SetPublicKey(val3.Public);
		val4.AddExtension(X509Extensions.SubjectKeyIdentifier, false, (Asn1Encodable)new SubjectKeyIdentifierStructure(val3.Public));
		val4.AddExtension(X509Extensions.BasicConstraints, true, (Asn1Encodable)new BasicConstraints(true));
		ISignatureFactory val6 = (ISignatureFactory)new Asn1SignatureFactory("SHA512WITHRSA", val3.Private, val);
		X509Certificate2 x509Certificate = new X509Certificate2(DotNetUtilities.ToX509Certificate(val4.Generate(val6)));
		AsymmetricKeyParameter obj = val3.Private;
		x509Certificate.PrivateKey = DotNetUtilities.ToRSA((RsaPrivateCrtKeyParameters)(object)((obj is RsaPrivateCrtKeyParameters) ? obj : null));
		return x509Certificate;
	}
}
