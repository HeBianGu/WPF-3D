using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkColor
	/// </summary>
	/// <remarks>
	///    templated type for storage of colors.
	///
	///
	/// This class is a templated data type for storing and manipulating fixed size
	/// colors. It derives from the vtkVector templated data structure.
	/// </remarks>
	// Token: 0x02000AF3 RID: 2803
	public class vtkColor4d : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D802 RID: 120834 RVA: 0x0029AAAF File Offset: 0x00298CAF
		static vtkColor4d()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkColor4d.MRClassNameKey, Type.GetType("Kitware.VTK.vtkColor4d"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D803 RID: 120835 RVA: 0x0029AAD7 File Offset: 0x00298CD7
		public vtkColor4d(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D804 RID: 120836 RVA: 0x0029AAE5 File Offset: 0x00298CE5
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D805 RID: 120837
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColor4d_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount, float a, float b, float c, float d);

		// Token: 0x0601D806 RID: 120838 RVA: 0x0029AAF0 File Offset: 0x00298CF0
		public vtkColor4d(float a, float b, float c, float d) : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkColor4d.vtkColor4d_New(ref num, ref maxValue, ref num2, a, b, c, d);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F0D RID: 7949
		public new const string MRFullTypeName = "Kitware.VTK.vtkColor4d";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F0E RID: 7950
		public new static readonly string MRClassNameKey = "class vtkColor4d";
	}
}
