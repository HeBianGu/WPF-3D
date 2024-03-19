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
	// Token: 0x02000AF6 RID: 2806
	public class vtkColor4ub : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D811 RID: 120849 RVA: 0x0029AC4B File Offset: 0x00298E4B
		static vtkColor4ub()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkColor4ub.MRClassNameKey, Type.GetType("Kitware.VTK.vtkColor4ub"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D812 RID: 120850 RVA: 0x0029AC73 File Offset: 0x00298E73
		public vtkColor4ub(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D813 RID: 120851 RVA: 0x0029AC81 File Offset: 0x00298E81
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D814 RID: 120852
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColor4ub_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount, float a, float b, float c, float d);

		// Token: 0x0601D815 RID: 120853 RVA: 0x0029AC8C File Offset: 0x00298E8C
		public vtkColor4ub(float a, float b, float c, float d) : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkColor4ub.vtkColor4ub_New(ref num, ref maxValue, ref num2, a, b, c, d);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F13 RID: 7955
		public new const string MRFullTypeName = "Kitware.VTK.vtkColor4ub";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F14 RID: 7956
		public new static readonly string MRClassNameKey = "class vtkColor4ub";
	}
}
