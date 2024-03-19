using System;

namespace Kitware.VTK
{
	// Token: 0x02000B94 RID: 2964
	public sealed class TrialVersionException : Exception
	{
		// Token: 0x0601EDA1 RID: 126369 RVA: 0x002BC965 File Offset: 0x002BAB65
		public TrialVersionException()
		{
		}

		// Token: 0x0601EDA2 RID: 126370 RVA: 0x002BC970 File Offset: 0x002BAB70
		public TrialVersionException(string message) : base(message)
		{
		}

		// Token: 0x0601EDA3 RID: 126371 RVA: 0x002BC97C File Offset: 0x002BAB7C
		public TrialVersionException(string message, Exception inner) : base(message, inner)
		{
		}
	}
}
