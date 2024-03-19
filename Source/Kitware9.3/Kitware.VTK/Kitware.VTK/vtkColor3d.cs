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
	// Token: 0x02000AF2 RID: 2802
	public class vtkColor3d : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D7FD RID: 120829 RVA: 0x0029AA27 File Offset: 0x00298C27
		static vtkColor3d()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkColor3d.MRClassNameKey, Type.GetType("Kitware.VTK.vtkColor3d"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D7FE RID: 120830 RVA: 0x0029AA4F File Offset: 0x00298C4F
		public vtkColor3d(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D7FF RID: 120831 RVA: 0x0029AA5D File Offset: 0x00298C5D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D800 RID: 120832
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColor3d_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount, float x, float y, float z);

		// Token: 0x0601D801 RID: 120833 RVA: 0x0029AA68 File Offset: 0x00298C68
		public vtkColor3d(float x, float y, float z) : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkColor3d.vtkColor3d_New(ref num, ref maxValue, ref num2, x, y, z);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F0B RID: 7947
		public new const string MRFullTypeName = "Kitware.VTK.vtkColor3d";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F0C RID: 7948
		public new static readonly string MRClassNameKey = "class vtkColor3d";
	}
}
