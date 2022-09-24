using System.IO;

namespace Ude
{
	/// <summary>
	/// 
	/// </summary>
	public interface ICharsetDetector
	{
		string Charset { get; }
		float Confidence { get; }
		void Feed( byte[] buf, int offset, int len );
		void Feed( Stream stream );
		void Reset();
		bool IsDone();
		void DataEnd();
	}
}
