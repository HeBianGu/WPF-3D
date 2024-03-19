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
	// Token: 0x02000AF5 RID: 2805
	public class vtkColor3ub : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D80C RID: 120844 RVA: 0x0029ABC3 File Offset: 0x00298DC3
		static vtkColor3ub()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkColor3ub.MRClassNameKey, Type.GetType("Kitware.VTK.vtkColor3ub"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D80D RID: 120845 RVA: 0x0029ABEB File Offset: 0x00298DEB
		public vtkColor3ub(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D80E RID: 120846 RVA: 0x0029ABF9 File Offset: 0x00298DF9
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D80F RID: 120847
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColor3ub_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount, float x, float y, float z);

		// Token: 0x0601D810 RID: 120848 RVA: 0x0029AC04 File Offset: 0x00298E04
		public vtkColor3ub(float x, float y, float z) : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkColor3ub.vtkColor3ub_New(ref num, ref maxValue, ref num2, x, y, z);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F11 RID: 7953
		public new const string MRFullTypeName = "Kitware.VTK.vtkColor3ub";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F12 RID: 7954
		public new static readonly string MRClassNameKey = "class vtkColor3ub";
	}
}
