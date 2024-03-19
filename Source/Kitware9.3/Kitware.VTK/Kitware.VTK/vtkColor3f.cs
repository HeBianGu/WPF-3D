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
	// Token: 0x02000AF4 RID: 2804
	public class vtkColor3f : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D807 RID: 120839 RVA: 0x0029AB39 File Offset: 0x00298D39
		static vtkColor3f()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkColor3f.MRClassNameKey, Type.GetType("Kitware.VTK.vtkColor3f"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D808 RID: 120840 RVA: 0x0029AB61 File Offset: 0x00298D61
		public vtkColor3f(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D809 RID: 120841 RVA: 0x0029AB6F File Offset: 0x00298D6F
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D80A RID: 120842
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColor3f_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount, float x, float y, float z);

		// Token: 0x0601D80B RID: 120843 RVA: 0x0029AB7C File Offset: 0x00298D7C
		public vtkColor3f(float x, float y, float z) : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkColor3f.vtkColor3f_New(ref num, ref maxValue, ref num2, x, y, z);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F0F RID: 7951
		public new const string MRFullTypeName = "Kitware.VTK.vtkColor3f";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F10 RID: 7952
		public new static readonly string MRClassNameKey = "class vtkColor3f";
	}
}
