using System;

namespace Kitware.VTK
{
	// Token: 0x02000B95 RID: 2965
	public sealed class TrialVersionSingleton
	{
		// Token: 0x0601EDA4 RID: 126372 RVA: 0x002BC989 File Offset: 0x002BAB89
		private TrialVersionSingleton()
		{
			this.firstInstance = true;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0601EDA5 RID: 126373 RVA: 0x002BC99C File Offset: 0x002BAB9C
		public static TrialVersionSingleton Instance
		{
			get
			{
				return TrialVersionSingleton.instance;
			}
		}

		// Token: 0x0601EDA6 RID: 126374 RVA: 0x002BC9B4 File Offset: 0x002BABB4
		public void CheckExpiration()
		{
			if (this.firstInstance)
			{
				try
				{
					this.firstInstance = false;
					DateTime now = DateTime.Now;
					DateTime d = new DateTime(2024, 4, 17, 0, 0, 0);
					double totalDays = (d - now).TotalDays;
					Console.WriteLine(string.Concat(new object[]
					{
						"ActiViz by Kitware - Trial Edition. (",
						Math.Round(totalDays),
						" Days remaining).",
						Environment.NewLine,
						"Contact kitware@kitware.fr for more information"
					}));
					if (totalDays < 0.0)
					{
						throw new TrialVersionException();
					}
				}
				catch (TrialVersionException ex)
				{
					Environment.Exit(0);
				}
			}
		}

		// Token: 0x04002130 RID: 8496
		private static readonly TrialVersionSingleton instance = new TrialVersionSingleton();

		// Token: 0x04002131 RID: 8497
		private bool firstInstance;
	}
}
